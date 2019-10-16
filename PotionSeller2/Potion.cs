using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionSeller2
{
    class Potion
    {
        public readonly Effect[] effects;
        public readonly Ingredient[] ingredients;
        readonly int alchemySkill, fortifyAlchemy;
        readonly bool physicianPerk, poisonerPerk, purityPerk;
        public enum PotionType { POTION, POISON };
        public Potion(Ingredient[] ingredients, int alchemySkill = 15, int fortifyAlchemy = 0, bool physicianPerk = false, bool poisonerPerk = false, bool purityPerk = false)
        {
            //Copy variables
            this.alchemySkill = alchemySkill;
            this.fortifyAlchemy = fortifyAlchemy;
            this.physicianPerk = physicianPerk;
            this.poisonerPerk = poisonerPerk;
            this.purityPerk = purityPerk;

            //Get a list of unique ingredients
            List<Ingredient> cleanedIngredients = new List<Ingredient>();
            foreach (Ingredient inputIngredient in ingredients)
            {
                bool unique = true;
                foreach (Ingredient internalIngredient in cleanedIngredients)
                    if (inputIngredient.GetHashCode() == internalIngredient.GetHashCode())
                    {
                        unique = false;
                        break;
                    }
                if (unique)
                    cleanedIngredients.Add(inputIngredient);
            }
            //get all effects 2 or more ingredients have in common
            List<Effect> potionEffects = new List<Effect>();
            for (int i = 0; i < cleanedIngredients.Count(); i++)
                for (int j = i + 1; j < cleanedIngredients.Count(); j++)
                {
                    Ingredient a = cleanedIngredients[i];
                    Ingredient b = cleanedIngredients[j];
                    foreach (Effect effect in cleanedIngredients[i].GetCommonEffects(cleanedIngredients[j]))
                        potionEffects.Add(effect);
                }
            //clean duplicate effects
            for (int i = potionEffects.Count - 1; i >= 0; i--)
                for (int j = i + 1; j < potionEffects.Count; j++)
                {
                    if (potionEffects[i].GetHashCode() == potionEffects[j].GetHashCode())
                        potionEffects.RemoveAt(j);
                }
            //Collect only contributing ingredients
            List<Ingredient> contributingIngredients = new List<Ingredient>();
            foreach (Ingredient ingredient in cleanedIngredients)
            {
                foreach (Effect effect in potionEffects)
                {
                    if (ingredient.HasEffect(effect))
                    {
                        contributingIngredients.Add(ingredient);
                        break;
                    }
                }
            }
            //clean duplicate ingredients
            for (int i = contributingIngredients.Count - 1; i >= 0; i--)
                for (int j = i + 1; j < contributingIngredients.Count; j++)
                {
                    if (contributingIngredients[i].GetHashCode() == contributingIngredients[j].GetHashCode())
                        contributingIngredients.RemoveAt(j);
                }
            //Save to memory
            this.ingredients = contributingIngredients.ToArray();
            this.effects = potionEffects.ToArray();
        }

        public static List<Potion> GetAllPotions(List<Ingredient> ingredients)
        {
            List<Potion> potions = new List<Potion>();
            for(int i = 0; i < ingredients.Count; i++)
            {
                for(int j = i + 1; j < ingredients.Count; j++)
                {
                    for(int k = j; k < ingredients.Count; k++)
                    {
                        Ingredient[] ingredientArray = new Ingredient[] { ingredients[i], ingredients[j], ingredients[k] };
                        Potion potion = new Potion(ingredientArray);
                        if (potion.effects.Count() > 0 && potion.ingredients.Count() > 0)
                            potions.Add(potion);
                    }
                }
            }
            return new List<Potion>(potions.Distinct(new PotionComparer()));
        }

        #region HASHING
        public int GetIngredientHashCode()
        {
            int hash = 0;
            foreach (Ingredient ingredient in ingredients)
                hash ^= ingredient.name.GetHashCode();
            return hash;
        }
        public int GetEffectHashCode()
        {
            int hash = 0;
            foreach (Effect effect in effects)
                hash ^= effect.name.GetHashCode();
            return hash;
        }
        public override int GetHashCode()
        {
            return GetIngredientHashCode() ^ GetEffectHashCode();
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Potion))
                return GetHashCode() == ((Potion)obj).GetHashCode();
            else
                return base.Equals(obj);
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < effects.Count()-1; i++)
            {
                builder.Append(effects[i]);
                builder.Append(',');
            }
            builder.Append(effects[effects.Count() - 1]);
            return builder.ToString();
        }
    }
    internal class PotionComparer : IEqualityComparer<Potion>
    {
        public bool Equals(Potion a, Potion b)
        {
            return a.Equals(b);
        }
        public int GetHashCode(Potion potion)
        {
            int ingredientHash = potion.GetIngredientHashCode();
            int effectHash = potion.GetEffectHashCode();
            return ingredientHash ^ effectHash;
        }
    }
    internal class PotionEffectComparer : IEqualityComparer<Potion>
    {
        public bool Equals(Potion a, Potion b)
        {
            return a.GetEffectHashCode() == b.GetEffectHashCode();
        }
        public int GetHashCode(Potion potion)
        {
            return potion.GetEffectHashCode();
        }
    }
}
