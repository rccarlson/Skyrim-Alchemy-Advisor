using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionSeller2
{
    class Potion
    {
        readonly Effect[] effects;
        readonly Ingredient[] ingredients;
        public Potion(Ingredient[] ingredients)
        {
            //get all effects 2 or more ingredients have in common
            List<Effect> potionEffects = new List<Effect>();
            for (int i=0;i<ingredients.Count();i++)
                for(int j = i + 1; j < ingredients.Count(); j++)
                {
                    foreach (Effect effect in ingredients[i].GetCommonEffects(ingredients[j]))
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
            foreach(Ingredient ingredient in ingredients)
            {
                foreach(Effect effect in potionEffects)
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
                        Potion potion =new Potion(new Ingredient[] { ingredients[i], ingredients[j], ingredients[k] });
                        if (potion.effects.Count() > 0 && potion.ingredients.Count() > 0) ;
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
}
