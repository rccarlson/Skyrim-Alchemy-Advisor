using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimAlchemy
{
    public class Potion
    {
        public List<Ingredient> ingredients;
        public readonly List<Effect> effects;
        List<EffectException> exceptions;

        const float fAlchemyIngredientInitMult = 4.0f,
            fAlchemySkillFactor = 1.5f;
        const bool applyExceptions = true;

        readonly int alchemySkill, fortifyAlchemy, alchemistPerk;
        readonly bool physicianPerk, benefactorPerk, poisonerPerk, seekerOfShadows, purityPerk;

        public Potion(Ingredient ingredient_a, Ingredient ingredient_b, Ingredient ingredient_c = null,
            int alchemySkill = 0, int fortifyAlchemy = 0, int alchemistPerk = 0, bool physicianPerk = false, bool benefactorPerk = false, bool poisonerPerk = false, bool seekerOfShadows = false, bool purity = false)
        {
            ingredients = ingredient_c == null ?
                new List<Ingredient> { ingredient_a, ingredient_b } :
                new List<Ingredient> { ingredient_a, ingredient_b, ingredient_c };

            //Remove all duplicate ingredients
            ingredients = new List<Ingredient>(ingredients.Distinct());

            this.effects = GetCommonEffects(ingredients);
            this.alchemySkill = alchemySkill;
            this.fortifyAlchemy = fortifyAlchemy;
            this.alchemistPerk = alchemistPerk;
            this.physicianPerk = physicianPerk;
            this.benefactorPerk = benefactorPerk;
            this.poisonerPerk = poisonerPerk;
            this.seekerOfShadows = seekerOfShadows;
            this.purityPerk = purity;

            //Get applicable exceptions
            this.exceptions = GetAllExceptions();//EffectException.GetExceptions(ingredients, effects);

            //Apply the purity perk to remove side effects
            if (purityPerk)
            {
                Effect highestValueEffect = HighestValueEffect;
                effects.RemoveAll(e => e.beneficial != highestValueEffect.beneficial);
            }

            //Remove all ingredients that have no contributing effects
            if (ingredients.Count > 2 && effects.Count > 1)
                ingredients.RemoveAll(i => i.effects.Count(e => this.effects.Contains(e)) == 0);
        }

        List<Effect> GetCommonEffects(List<Ingredient> ingredients)
        {
            List<Effect> effects = new List<Effect>();
            for (int i = 0; i < ingredients.Count; i++)
                for (int j = i + 1; j < ingredients.Count; j++)
                {
                    GetCommonEffects(ingredients[i], ingredients[j])
                        .ForEach(e =>
                            {
                                if (!effects.Contains(e))
                                    effects.Add(e);
                            }
                        );
                }
            return effects;
        }
        List<Effect> GetCommonEffects(Ingredient ingredient_a, Ingredient ingredient_b)
        {
            if (ingredient_a != null && ingredient_b != null && ingredient_a.name!=ingredient_b.name)
            {
                List<Effect> effects = new List<Effect>();
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                    {
                        if (ingredient_a.effects[i] == ingredient_b.effects[j] && !effects.Contains(ingredient_a.effects[i]))
                            effects.Add(ingredient_a.effects[i]);
                    }
                return effects;
            }
            else
            {
                return new List<Effect>();
            }
        }

        #region HELPER FUNCTIONS
        float GetBenefactorPerk(Effect effect)
        {
            return effect.beneficial && benefactorPerk && HighestValueEffect.beneficial ? 25.0f : 0;
        }
        float GetPoisonerPerk(Effect effect)
        {
            return !effect.beneficial && poisonerPerk && HighestValueEffect.poisonous ? 25.0f : 0;
        }
        float GetPhysicianPerk(Effect effect)
        {
            if (physicianPerk && (effect.name == "Restore Health" || effect.name == "Restore Magicka" || effect.name == "Restore Stamina"))
                return 25.0f;
            else
                return 0.0f;
        }
        float GetPowerFactor(Effect effect)
        {
            float power = fAlchemyIngredientInitMult *
                (1.0f + (fAlchemySkillFactor - 1.0f) * (float)alchemySkill / 100.0f) *
                (1.0f + (float)fortifyAlchemy / 100.0f) *
                (1.0f + (float)alchemistPerk / 100.0f) *
                (1.0f + GetPhysicianPerk(effect) / 100.0f) *
                (1.0f + GetBenefactorPerk(effect) / 100.0f + GetPoisonerPerk(effect) / 100.0f);
            return power;
        }
        #endregion

        float GetEffectMagnitude(Effect effect)
        {
            float mag = effect.baseMag;
            if (effect.powerAffectsMagnitude)
            {
                mag = effect.baseMag;
                mag *= fAlchemyIngredientInitMult;
                mag *= (1.0f + (fAlchemySkillFactor - 1.0f) * (alchemySkill / 100.0f)); //* (1.0f + (alchemySkill / 200.0f))
                mag *= (1.0f + fortifyAlchemy / 100.0f);
                mag *= (1.0f + alchemistPerk / 100.0f);
                mag *= (1.0f + GetPhysicianPerk(effect) / 100.0f);
                mag *= (1.0f + GetBenefactorPerk(effect) / 100.0f + GetPoisonerPerk(effect) / 100.0f);
                mag *= (1.0f + (seekerOfShadows ? 10.0f : 0) / 100.0f);
            }

            //apply exception
            EffectException exception = GetException(effect);
            if (exception != null)
                mag *= exception.magnitude;

            return mag;
        }
        float GetEffectDuration(Effect effect)
        {
            float durationFactor = 1.0f;
            if (effect.baseDur == 0 || effect.baseDur < 0)
                durationFactor = 1.0f;
            if (effect.powerAffectsDuration)
                durationFactor = GetPowerFactor(effect);
            float finalDuration = effect.baseDur * durationFactor;

            //apply exception
            EffectException exception = GetException(effect);
            if (exception != null)
                finalDuration *= exception.duration;

            return (int)Math.Round(finalDuration);
        }
        float GetEffectValue(Effect effect)
        {
            float magnitudeFactor = 1.0f,
                durationFactor = 1.0f,
                magnitude = GetEffectMagnitude(effect),
                duration = GetEffectDuration(effect);
            if (magnitude > 0)
                magnitudeFactor = magnitude;
            if (duration > 0)
                durationFactor = duration / 10.0f;
            float value = (float)((float)effect.baseCost * (float)Math.Pow(magnitudeFactor * durationFactor, 1.1f));

            //apply exception
            EffectException exception = GetException(effect);
            if (exception != null)
                value *= exception.value;

            return value;
        }

        float GetRelativeValue(Effect effect)
        {
            #region magnitude
            float mag = effect.baseMag;
            if (effect.powerAffectsMagnitude)
            {
                mag = effect.baseMag;
                mag *= fAlchemyIngredientInitMult;
                mag *= (1.0f + (fAlchemySkillFactor - 1.0f) * (alchemySkill / 100.0f)); //* (1.0f + (alchemySkill / 200.0f))
                mag *= (1.0f + fortifyAlchemy / 100.0f);
                mag *= (1.0f + alchemistPerk / 100.0f);
                mag *= (1.0f + GetPhysicianPerk(effect) / 100.0f);
                mag *= (1.0f + (seekerOfShadows ? 10.0f : 0) / 100.0f);
            }
            //apply exception
            IEnumerable<EffectException> exceptions = this.exceptions.Where(e => e.effect == effect.name);
            if (exceptions != null && exceptions.Count() > 0)
            {
                float multiplier = exceptions.Max(e => e.magnitude);
                if (multiplier == 1)
                    multiplier = exceptions.Min(e => e.magnitude);
                mag *= multiplier;
            }
            #endregion

            #region duration
            float durCalcFactor = 1.0f;
            if (effect.baseDur == 0 || effect.baseDur < 0)
                durCalcFactor = 1.0f;
            if (effect.powerAffectsDuration)
                durCalcFactor = fAlchemyIngredientInitMult *
                (1.0f + (fAlchemySkillFactor - 1.0f) * (float)alchemySkill / 100.0f) *
                (1.0f + (float)fortifyAlchemy / 100.0f) *
                (1.0f + (float)alchemistPerk / 100.0f) *
                (1.0f + GetPhysicianPerk(effect) / 100.0f);
            float dur = effect.baseDur * durCalcFactor;
            #endregion

            float magnitudeFactor = 1.0f,
                durationFactor = 1.0f;
            if (mag > 0)
                magnitudeFactor = mag;
            if (dur > 0)
                durationFactor = dur / 10.0f;
            float value = effect.baseCost * (float)Math.Pow(magnitudeFactor * durationFactor, 1.1);

            //apply exception
            if (exceptions != null && exceptions.Count() > 0)
            {
                float multiplier = exceptions.Max(e => e.value);
                if (multiplier == 1)
                    multiplier = exceptions.Min(e => e.value);
                value *= multiplier;
            }
            return value;
        }

        Effect GetHighestValueEffectDirect()
        {
            Effect maxEffect = effects[0];
            float maxValue = GetEffectValue(maxEffect);
            for (int i = 1; i < effects.Count; i++)
            {
                float currValue = GetEffectValue(effects[i]);
                if (currValue > maxValue)
                {
                    maxValue = currValue;
                    maxEffect = effects[i];
                }
            }
            return maxEffect;
        }
        Effect HighestValueEffect
        {
            get
            {
                if (effects.Count > 0)
                {
                    Effect maxEffect = effects[0];
                    float maxValue = GetRelativeValue(maxEffect);
                    for (int i = 1; i < effects.Count; i++)
                    {
                        float currValue = GetRelativeValue(effects[i]);
                        if (currValue > maxValue)
                        {
                            maxValue = currValue;
                            maxEffect = effects[i];
                        }
                    }
                    return maxEffect;
                }
                return null;
            }
        }
        /// <summary>
        /// Get the highest value ingredient with a given effect for this potion
        /// </summary>
        /// <param name="effect">Effect to be searched for</param>
        /// <returns></returns>
        Ingredient GetHighestValueIngredient(Effect effect)
        {
            var ings = ingredients.Where(i => i.effects.Contains(effect));
            Ingredient highestIngredient = ings.ElementAt(0);
            foreach (Ingredient ingredient in ings)
            {
                if (ingredient.value > highestIngredient.value)
                    highestIngredient = ingredient;
            }
            return highestIngredient;
        }
        EffectException GetException(Effect effect)
        {
            if (applyExceptions)
            {
                Ingredient highestValueIngredient = GetHighestValueIngredient(effect);
                var exception = EffectException.GetException(highestValueIngredient, effect);
                return exception;
            }
            else
            {
                return null;
            }
        }
        List<EffectException> GetAllExceptions()
        {
            List<EffectException> exceptions = new List<EffectException>();
            foreach(Effect effect in effects)
            {
                EffectException exception = GetException(effect);
                if (exception != null)
                    exceptions.Add(exception);
            }
            return exceptions;
        }
        public bool IsPotion
        {
            get
            {
                return HighestValueEffect.beneficial;
            }
        }
        public bool IsValid
        {
            get
            {
                return effects.Count > 0;
            }
        }
        public bool ExceptionsApplied { get
            {
                return exceptions.Count > 0;
            } }
        public int Value
        {
            get
            {
                float value = 0;
                if (purityPerk)
                {
                    bool isPotion = IsPotion;
                    effects.ForEach(e => { if (e.beneficial == isPotion) value += GetEffectValue(e); });
                    //((List<Effect>)effects.Where(e => e.beneficial == isPotion)).ForEach(e => value += GetEffectValue(e));
                }
                else
                {
                    effects.ForEach(e => value += GetEffectValue(e));
                }
                return (int)Math.Floor(value);
            }
        }
        public string Description
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                foreach (Effect effect in effects.OrderBy(e=>e.maxValue).Reverse())
                {
                    builder.Append(effect.description
                        .Replace("<dur>", Convert.ToString(GetEffectDuration(effect)))
                        .Replace("<mag>", Convert.ToString((int)Math.Round(GetEffectMagnitude(effect)))))
                        .Append(' ');
                }
                return builder.ToString().Trim();
            }
        }
        public override string ToString()
        {
            return (IsPotion ? "Potion" : "Poison") + " of " + HighestValueEffect.name;
        }

        public static List<Potion> GetPotions(List<string> ingredientStr, int alchemySkill = 0, int fortifyAlchemy = 0, int alchemistPerk = 0, bool physicianPerk = false, bool benefactorPerk = false, bool poisonerPerk = false, bool seekerOfShadows = false, bool purity = false)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredientStr.ForEach(i => ingredients.Add(Ingredient.GetIngredient(i)));
            return GetPotions(ingredients, alchemySkill, fortifyAlchemy, alchemistPerk, physicianPerk, benefactorPerk, poisonerPerk, seekerOfShadows, purity);
        }
        public static List<Potion> GetPotions(List<Ingredient> ingredients, int alchemySkill = 0, int fortifyAlchemy = 0, int alchemistPerk = 0, bool physicianPerk = false, bool benefactorPerk = false, bool poisonerPerk = false, bool seekerOfShadows = false, bool purity = false)
        {
            List<Potion> potions = new List<Potion>();
            for (int i = 0; i < ingredients.Count; i++)
                for (int j = i + 1; j < ingredients.Count; j++)
                    for (int k = j; k < ingredients.Count; k++)
                    {
                        Potion potion = new Potion(ingredients[i], ingredients[j], ingredients[k], alchemySkill, fortifyAlchemy, alchemistPerk, physicianPerk, benefactorPerk, poisonerPerk, seekerOfShadows, purity);
                        if (potion.IsValid)
                            potions.Add(potion);
                    }
            return potions;
        }
    }

    class EffectException
    {
        public static List<EffectException> exceptions = GetExceptions("effect_exceptions.csv");

        public readonly string ingredient, effect;
        public readonly float magnitude, duration, value;

        //Ingredient,Effect,Magnitude,Duration,Value
        protected EffectException(string ingredient, string effect, string magnitude, string duration, string value)
        {
            this.ingredient = ingredient;
            this.effect = effect;
            this.magnitude = Convert.ToSingle(magnitude);
            this.duration = Convert.ToSingle(duration);
            this.value = Convert.ToSingle(value);
        }

        static List<EffectException> GetExceptions(string filename, bool ignoreFirstLine = true)
        {
            List<EffectException> exceptions = new List<EffectException>();
            using (Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(filename))
            {
                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                parser.SetDelimiters(",");
                if (ignoreFirstLine)
                    parser.ReadFields();
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields.Length == 5)
                    {
                        EffectException e = new EffectException(fields[0],
                            fields[1],
                            fields[2],
                            fields[3],
                            fields[4]);
                        exceptions.Add(e);
                    }
                }
            }
            return exceptions;
        }

        public static EffectException GetException(string ingredientName, string effectName)
        {
            return exceptions.Find(e => e.ingredient == ingredientName && e.effect == effectName);
        }
        public static EffectException GetException(Ingredient ingredient, Effect effect)
        {
            return exceptions.Find(e => e.ingredient == ingredient.name && e.effect == effect.name);
        }

        public static List<EffectException> GetExceptions(List<Ingredient> ingredients, List<Effect> effects)
        {
            List<EffectException> exceptions = new List<EffectException>();
            foreach (Ingredient ingredient in ingredients)
                foreach(Effect effect in effects)
                {
                    EffectException exception = GetException(ingredient.name, effect.name);
                    if (exception != null && !exceptions.Contains(exception))
                        exceptions.Add(exception);
                }
            return exceptions;
        }

        public override string ToString()
        {
            return ingredient + ": " + effect;
        }
    }
}
