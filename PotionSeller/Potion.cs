﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionSeller
{
    public class Potion
    {
        public readonly List<string> effects;
        public readonly Ingredient[] ingredients;

        public Potion(Ingredient[] ingredients)
        {
            if (ingredients[1] == ingredients[2])
                this.ingredients = new Ingredient[] { ingredients[0], ingredients[1] };
            else
                this.ingredients = ingredients;
            ingredients = this.ingredients;

            int count = ingredients.Count();
            if (count > 3)
                count = 3;
            effects = new List<string>();
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    List<string> common = ingredients[i].GetCommonEffects(ingredients[j]);
                    foreach (string effect in common)
                        if (!effects.Contains(effect))
                            effects.Add(effect);
                }
            }

            List<Ingredient> contributingIngredients = new List<Ingredient>();
            foreach (Ingredient ingredient in this.ingredients)
            {
                foreach (string effect in this.effects)
                {
                    if (ingredient.HasEffect(effect) && !contributingIngredients.Contains(ingredient))
                        contributingIngredients.Add(ingredient);
                }
            }
            this.ingredients = contributingIngredients.ToArray();
        }

        public bool Equals(Potion potion)
        {
            //Compare effects
            foreach(string effect in effects)
                if (!potion.effects.Contains(effect))
                    return false;
            foreach(string effect in potion.effects)
                if (!effects.Contains(effect))
                    return false;
            //Compare ingredients
            foreach (Ingredient ingredient in ingredients)
                if (!potion.ingredients.Contains(ingredient))
                    return false;
            foreach (Ingredient ingredient in potion.ingredients)
                if (!ingredients.Contains(ingredient))
                    return false;
            //effects and ingredients are identical. return true
            return true;
        }
        public bool ContainedByList(List<Potion> potions)
        {
            foreach(Potion potion in potions)
            {
                if (Equals(potion))
                    return true;
            }
            return false;
        }

        public static List<Potion> GetAllPossiblePotions(Ingredient[] ingredients)
        {
            List<Potion> potions = new List<Potion>();
            int count = ingredients.Count();
            for (int i = 0; i < count; i++)
                for (int j = i + 1; j < count; j++)
                    for (int k = j; k < count; k++)
                    {
                        Potion potion = new Potion(new Ingredient[] { ingredients[i], ingredients[j], ingredients[k] });
                        if (potion.effects.Count > 0 /*&& !potion.ContainedByList(potions)*/)
                            potions.Add(potion);
                    }
            return new List<Potion>(potions.Distinct(new PotionComparer()));
        }

        static void SortEffectCountBubble(ref List<Potion> potions)
        {
            bool changeMade;
            do
            {
                changeMade = false;
                for(int i = 0; i < potions.Count - 1; i++)
                {
                    if (potions[i].effects.Count < potions[i + 1].effects.Count)
                    {
                        Potion temp = potions[i];
                        potions[i] = potions[i + 1];
                        potions[i + 1] = temp;
                        changeMade = true;
                    }
                }
            } while (changeMade);
        }

        #region EFFECT PROCESSING
        /// <summary>
        /// All effects from <paramref name="selectedEffects"/> are present in <paramref name="effectString"/>
        /// </summary>
        /// <param name="effectString">Full string representing all effects of a potion</param>
        /// <param name="selectedEffects">List of all effect strings</param>
        /// <returns>True if all effects are found</returns>
        public static bool AllEffectsPresent(string effectString, List<string> selectedEffects)
        {
            foreach (string effect in selectedEffects)
            {
                if (!effectString.Contains(effect))
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Only effects from <paramref name="selectedEffects"/> are present in <paramref name="effectString"/>
        /// </summary>
        /// <param name="effectString">Full string representing all effects of a potion</param>
        /// <param name="selectedEffects">List of all effect strings</param>
        /// <returns>True if effectString is comprised of all effects from <paramref name="selectedEffects"/></returns>
        public static bool AllEffectsPresentExclusive(string effectString, List<string> selectedEffects)
        {
            //if the count is different, then the two lists are not the same
            if (effectString.Count(ch => ch == ',') + 1 != selectedEffects.Count)
                return false;
            return AllEffectsPresent(effectString, selectedEffects);
        }
        public static List<string> GetUniqueEffects(List<Potion> potions)
        {
            List<Potion> uniquePotions = new List<Potion>();
            foreach(Potion potion in potions)
            {
                bool isUnique = true;
                int potionEffectHashCode = potion.GetEffectHashCode();
                foreach(Potion uniquePotion in uniquePotions)
                {
                    if (uniquePotion.GetEffectHashCode() == potionEffectHashCode)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    uniquePotions.Add(potion);
                }
            }
            List<string> uniqueEffects = new List<string>();
            foreach(Potion potion in uniquePotions)
            {
                uniqueEffects.Add(potion.ToString());
            }
            return uniqueEffects;
        }
        #endregion

        public int GetEffectHashCode()
        {
            int effectHash = 0;
            foreach (string effect in effects)
                effectHash ^= effect.GetHashCode();
            return effectHash;
        }
        public int GetIngredientHashCode()
        {
            int ingredientHash = 0;
            foreach (Ingredient ingredient in ingredients)
                ingredientHash ^= ingredient.name.GetHashCode();
            return ingredientHash;
        }
        public override string ToString()
        {
            if (effects.Count > 0)
            {
                StringBuilder builder = new StringBuilder(effects[0]);
                for (int i = 1; i < effects.Count; i++)
                {
                    builder.Append(", ");
                    builder.Append(effects[i]);
                }
                return builder.ToString();
            }
            else
                return base.ToString();

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
