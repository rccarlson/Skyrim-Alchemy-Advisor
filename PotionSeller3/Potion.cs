using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotionSeller3
{
    public class Potion
    {
        public readonly List<Effect> effects;
        public readonly List<Ingredient> ingredients;
        public readonly int magnitude, duration, value;

        const float fAlchemyIngredientInitMult = 4.0f,
            fAlchemySkillFactor = 1.5f;
        int alchemySkill, fortifyAlchemy, alchemistPerk;
        bool physicianPerk, benefactorPerk, poisonerPerk, seekerOfShadows, purityPerk;
        public Ingredient HighestValueIngredient
        {
            get
            {
                Ingredient ingredient = ingredients[0];
                int value = ingredients[0].value;
                for (int i = 1; i < ingredients.Count; i++)
                    if (ingredients[i].value > value)
                    {
                        ingredient = ingredients[i];
                        value = ingredient.value;
                    }
                return ingredient;
            }
        }
        public Potion(Ingredient ingredient1, Ingredient ingredient2, Ingredient ingredient3,
            int alchemySkill,int fortifyAlchemy,int alchemistPerk,bool physicianPerk,bool benefactorPerk,bool poisonerPerk,bool seekerOfShadows,bool purity)
        {
            ingredients = new List<Ingredient> { ingredient1, ingredient2, ingredient3 };

            List<Effect> effects = new List<Effect>();
            AddCommonEffects(ref effects, ingredient1, ingredient2);
            AddCommonEffects(ref effects, ingredient1, ingredient3);
            AddCommonEffects(ref effects, ingredient2, ingredient3);
            //RemoveDuplicateEffects(ref effects);
            this.effects = effects;
            this.alchemySkill = alchemySkill;
            this.fortifyAlchemy = fortifyAlchemy;
            this.alchemistPerk = alchemistPerk;
            this.physicianPerk = physicianPerk;
            this.benefactorPerk = benefactorPerk;
            this.poisonerPerk = poisonerPerk;
            this.seekerOfShadows = seekerOfShadows;
            this.purityPerk = purity;

            float effectMagnitude1 = GetEffectMagnitude(effects[0]);
            float effectDuration1 = GetEffectDuration(effects[0]);
            int effectValue1 = GetEffectValue(effects[0]);

            int value = Value;

            int dummy = 0;
        }
        void AddCommonEffects(ref List<Effect> effects, Ingredient ingredient1, Ingredient ingredient2)
        {
            if (ingredient1 != ingredient2)
                for (int i = 0; i < 4; i++)
                    for (int j = i; j < 4; j++)
                    {
                        if (ingredient1.effects[i] == ingredient2.effects[j] && !effects.Any(e => e == ingredient1.effects[i]))
                            effects.Add(ingredient1.effects[i]);
                    }
        }
        void RemoveDuplicateEffects(ref List<Effect> effects)
        {
            for (int i = 0; i < effects.Count; i++)
                for (int j = i + 1; j < effects.Count; j++)
                {
                    effects.RemoveAt(j);
                    j--;
                }
        }

        float GetBenefactorPerk(Effect effect)
        {
            return effect.beneficial && benefactorPerk ? 25.0f : 0;
        }
        float GetPoisonerPerk(Effect effect)
        {
            return !effect.beneficial && poisonerPerk ? 25.0f : 0;
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
        float GetEffectMagnitude(Effect effect)
        {
            float mag = effect.baseMag;
            if (effect.powerAffectsMagnitude)
            {
                mag = effect.baseMag
                    * fAlchemyIngredientInitMult
                    * (1.0f + (fAlchemySkillFactor - 1.0f) * (alchemySkill / 100.0f)) //* (1.0f + (alchemySkill / 200.0f))
                    * (1.0f + fortifyAlchemy / 100.0f)
                    * (1.0f + alchemistPerk / 100.0f)
                    * (1.0f + GetPhysicianPerk(effect) / 100.0f)
                    * (1.0f + GetBenefactorPerk(effect) / 100.0f + GetPoisonerPerk(effect) / 100.0f)
                    * (1.0f + (seekerOfShadows ? 10.0f : 0) / 100.0f);
            }
            return (int)Math.Round(mag);
            //return mag;
        }
        float GetEffectDuration(Effect effect)
        {
            float durationFactor = 1.0f;
            if (effect.baseDur == 0 || effect.baseDur < 0)
                durationFactor = 1.0f;
            if (effect.powerAffectsDuration)
                durationFactor = GetPowerFactor(effect);
            float finalDuration = effect.baseDur * durationFactor;
            return (int)Math.Round(finalDuration);
            //return finalDuration;
        }
        int GetEffectValue(Effect effect)
        {
            float magnitudeFactor = 1.0f,
                durationFactor = 1.0f,
                magnitude = GetEffectMagnitude(effect),
                duration = GetEffectDuration(effect);
            if (magnitude > 0)
                magnitudeFactor = magnitude;
            if (duration > 0)
                durationFactor = duration / 10.0f;
            float value = effect.baseCost * (float)Math.Pow(magnitudeFactor * durationFactor, 1.1);
            return (int)Math.Floor(value);
        }

        Effect HighestValueEffect { get
            {
                Effect maxEffect = effects[0];
                int maxValue = GetEffectValue(maxEffect);
                for(int i = 1; i < effects.Count; i++)
                {
                    int currValue = GetEffectValue(effects[i]);
                    if (currValue > maxValue)
                    {
                        maxValue = currValue;
                        maxEffect = effects[i];
                    }
                }
                return maxEffect;
            } }
        bool IsPotion { get
            {
                return HighestValueEffect.beneficial;
            } }
        public int Value
        {
            get
            {
                if (purityPerk)
                {
                    bool isPotion = IsPotion;
                    int totalValue = 0;
                    ((List<Effect>)effects.Where(e => e.beneficial == isPotion)).ForEach(e => totalValue += GetEffectValue(e));
                    return totalValue;
                }
                else
                {
                    List<int> values = new List<int>();
                    effects.ForEach(e => values.Add(GetEffectValue(e)));
                    return values.Sum();
                }
            }
        }
        
        public override string ToString()
        {
            return (IsPotion ? "Potion" : "Poison") + " of " + HighestValueEffect.name;
        }
        public string Description { get
            {
                StringBuilder builder = new StringBuilder();
                foreach(Effect effect in effects)
                {
                    builder.Append(effect.description
                        .Replace("<dur>", Convert.ToString(GetEffectDuration(effect)))
                        .Replace("<mag>", Convert.ToString(GetEffectMagnitude(effect))))
                        .Append(' ');
                }
                return builder.ToString().Trim();
            } }
    }
}
