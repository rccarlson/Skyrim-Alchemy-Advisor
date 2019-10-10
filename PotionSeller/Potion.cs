using System;
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
        public static List<string> GetUniqueEffects(List<Potion> potions)
        {
            List<string> unique = new List<string>();
            //SortEffectCountBubble(ref potions);
            foreach(Potion potion in potions)
            {
                string s = potion.ToString();
                if (!unique.Contains(s))
                {
                    unique.Add(s);
                }
            }
            return unique;
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
            int ingredientHash = 0;
            int effectHash = 0;
            foreach (Ingredient ingredient in potion.ingredients)
                ingredientHash ^= ingredient.name.GetHashCode();
            foreach (string effect in potion.effects)
                effectHash ^= effect.GetHashCode();
            return ingredientHash ^ effectHash;
        }
    }
}
