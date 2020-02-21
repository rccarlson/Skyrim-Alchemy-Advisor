using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyrimAlchemy2
{
    public class Potion:IComparable<Potion>
    {
        public readonly List<Ingredient> ingredients;
        public readonly List<Effect> effects;
        const float fAlchemyIngredientInitMult = 4.0f,
            fAlchemySkillFactor = 1.5f;

        readonly int alchemySkill, fortifyAlchemy, alchemistPerk;
        readonly bool physicianPerk, benefactorPerk, poisonerPerk, seekerOfShadows, purityPerk;

        #region CONSTRUCTORS
        public Potion(Ingredient ingredient_a, Ingredient ingredient_b, Ingredient ingredient_c = null,
            int alchemySkill = 0, int fortifyAlchemy = 0, int alchemistPerk = 0, bool physicianPerk = false, bool benefactorPerk = false, bool poisonerPerk = false, bool seekerOfShadows = false, bool purity = false)
        {
            ingredients = ingredient_c == null ?
                new List<Ingredient> { ingredient_a, ingredient_b } :
                new List<Ingredient> { ingredient_a, ingredient_b, ingredient_c };

            //remove duplicate ingredients
            //ingredients = ingredients.Distinct().ToList(); //TODO: efficiency
            RemoveDuplicates(ref ingredients);

            effects = GetCommonEffects(ingredients);
            
            this.alchemySkill = alchemySkill;
            this.fortifyAlchemy = fortifyAlchemy;
            this.alchemistPerk = alchemistPerk;
            this.physicianPerk = physicianPerk;
            this.benefactorPerk = benefactorPerk;
            this.poisonerPerk = poisonerPerk;
            this.seekerOfShadows = seekerOfShadows;
            this.purityPerk = purity;

            //Apply the purity perk to remove side effects
            if (purityPerk)
            {
                Effect highestValueEffect = HighestValueEffect;
                effects.RemoveAll(e => e.beneficial != highestValueEffect.beneficial);
            }
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
        #endregion

        static void RemoveDuplicates(ref List<Ingredient> ingredients)
        {
            for(int i = 0; i < ingredients.Count; i++)
            {
                //remove any duplicate instances
                for(int j = i + 1; j < ingredients.Count; j++)
                {
                    if(ingredients[i].name == ingredients[j].name)
                    {
                        //collision found. remove the duplicate
                        if (ingredients[j].value > ingredients[i].value)
                        {
                            ingredients[i] = ingredients[j];
                        }
                        ingredients.RemoveAt(j);
                        j--;
                    }
                }
            }
        }
        List<Effect> GetCommonEffects(List<Ingredient> ingredients)
        {
            List<string> effectNames = new List<string>();
            for (int i = 0; i < ingredients.Count; i++)
                for (int j = i + 1; j < ingredients.Count; j++)
                {
                    List<string> common = GetCommonEffectNames(ingredients[i], ingredients[j]);
                    for(int k=0;k<common.Count;k++)
                        if (!effectNames.Contains(common[k]))
                            effectNames.Add(common[k]);
                }
            List<Effect> effects = new List<Effect>();
            effectNames.ForEach(name => {
                effects.Add(GetPriorityEffect(name));
            });

            return effects;
        }
        static List<string> GetCommonEffectNames(Ingredient ingredient_a, Ingredient ingredient_b)
        {
            List<string> effects = new List<string>();
            for(int i = 0; i < 4; i++)
            {
                if (ingredient_b.HasEffectByName(ingredient_a.effects[i]))
                    effects.Add(ingredient_a.effects[i].name);
            }
            return effects;
        }

        Effect GetPriorityEffect(string effectName)
        {
            Effect priorityEffect = null;
            foreach(Ingredient ingredient in ingredients)
            {
                Effect effect = ingredient.effects.Find(e => e.name == effectName);
                if (effect != null)
                {
                    //ingredient contains desired effect
                    if (priorityEffect == null)
                    {
                        //first found ingredient with desired effect
                        priorityEffect = effect;
                    }
                    else if(effect.value > priorityEffect.value)
                    {
                        priorityEffect = effect;
                    }
                }
            }
            return priorityEffect;
        }
        Ingredient GetPriorityIngredient(string effectName)
        {
            Effect priorityEffect = null;
            Ingredient priorityIngredient = null;
            foreach (Ingredient ingredient in ingredients)
            {
                Effect effect = ingredient.effects.Find(e => e.name == effectName);
                if (effect != null)
                {
                    //ingredient contains desired effect
                    if (priorityEffect == null)
                    {
                        //first found ingredient with desired effect
                        priorityEffect = effect;
                        priorityIngredient = ingredient;
                    }
                    else if (effect.value > priorityEffect.value)
                    {
                        priorityEffect = effect;
                        priorityIngredient = ingredient;
                    }
                }
            }
            return priorityIngredient;
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
        float GetPowerFactor(Effect effect, bool useRecursion = true)
        {
            float power = fAlchemyIngredientInitMult *
                (1.0f + (fAlchemySkillFactor - 1.0f) * (float)alchemySkill / 100.0f) *
                (1.0f + (float)fortifyAlchemy / 100.0f) *
                (1.0f + (float)alchemistPerk / 100.0f);
            power *= (1.0f + GetPhysicianPerk(effect) / 100.0f);
            if (useRecursion)
                power *= (1.0f + GetBenefactorPerk(effect) / 100.0f + GetPoisonerPerk(effect) / 100.0f);
            return power;
        }
        #endregion

        #region EFFECT PROPERTY FUNCTIONS
        float GetEffectMagnitude(Effect effect, bool useRecursion = true)
        {
            float mag = effect.magnitude;
            if (effect.variableMagnitude)
            {
                //mag = effect.magnitude;
                mag *= fAlchemyIngredientInitMult;
                mag *= (1.0f + (fAlchemySkillFactor - 1.0f) * (alchemySkill / 100.0f)); //* (1.0f + (alchemySkill / 200.0f))
                mag *= (1.0f + fortifyAlchemy / 100.0f);
                mag *= (1.0f + alchemistPerk / 100.0f);
                mag *= (1.0f + GetPhysicianPerk(effect) / 100.0f);
                if (useRecursion)
                    mag *= (1.0f + GetBenefactorPerk(effect) / 100.0f + GetPoisonerPerk(effect) / 100.0f);
                mag *= (1.0f + (seekerOfShadows ? 10.0f : 0) / 100.0f);
            }
            return mag;
        }
        float GetEffectDuration(Effect effect, bool useRecursion = true)
        {
            float durationFactor = 1.0f;
            if (effect.duration == 0 || effect.duration < 0)
                durationFactor = 1.0f;
            if (effect.variableDuration && useRecursion)
                durationFactor = GetPowerFactor(effect);
            float finalDuration = effect.duration * durationFactor;

            return finalDuration;
        }
        float GetEffectValue(Effect effect, bool useRecursion = true)
        {
            float magnitudeFactor = 1.0f,
                durationFactor = 1.0f,
                magnitude = GetEffectMagnitude(effect, useRecursion),
                duration = GetEffectDuration(effect, useRecursion);
            if (magnitude > 0)
                magnitudeFactor = magnitude;
            if (duration > 0)
                durationFactor = duration / 10.0f;
            float value = (effect.base_cost * (float)Math.Pow(magnitudeFactor * durationFactor, 1.1f));

            return value;
        }
        #endregion

        Effect HighestValueEffect { get
            {
                if (effects.Count > 0)
                {
                    Effect maxEffect = effects[0];
                    float maxValue = GetEffectValue(maxEffect, useRecursion: false);
                    for (int i = 1; i < effects.Count; i++)
                    {
                        float currValue = GetEffectValue(effects[i], useRecursion: false);
                        if (currValue > maxValue)
                        {
                            maxValue = currValue;
                            maxEffect = effects[i];
                        }
                    }
                    return maxEffect;
                }
                return null;
            } }

        #region PUBLIC PROPERTIES
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
        int cachedValue = int.MinValue;
        public int Value
        {
            get
            {
                if (cachedValue == int.MinValue)
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
                    cachedValue = (int)Math.Floor(value);
                    return (int)Math.Floor(value);
                }
                else
                {
                    return cachedValue;
                }
            }
        }
        public string Name { get
            {
                return (IsPotion ? "Potion" : "Poison") + " of " + HighestValueEffect.name;
            } }
        public string Description
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                foreach (Effect effect in effects.OrderBy(e => GetEffectValue(e)).Reverse())
                {
                    builder.Append(effect.description
                        .Replace("<dur>", Convert.ToString(GetEffectDuration(effect)))
                        .Replace("<mag>", Convert.ToString((int)Math.Round(GetEffectMagnitude(effect)))))
                        .Append(' ');
                }
                return builder.ToString().Trim();
            }
        }
        #endregion

        public override string ToString()
        {
            if (IsValid)
                return Name + ": " + Description;
            else
                return "Invalid Potion";
        }

        public int CompareTo(Potion other)
        {
            return Value.CompareTo(other.Value);
        }
    }
}
