using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionSeller2
{
    public class Ingredient
    {
        //Ingredient Primary Effect Secondary Effect Tertiary Effect Quaternary Effect Weight  Value Obtained
        public readonly string name, obtained;
        public readonly Effect[] effects;
        public readonly float weight;
        public readonly int value;
        internal Ingredient(string name, string effect1, string effect2, string effect3, string effect4, float weight, int value, string obtained, EffectBrowser effectBrowser)
        {
            this.name = name;
            this.effects = new Effect[4] { effectBrowser.GetEffect(effect1),
                effectBrowser.GetEffect(effect2),
                effectBrowser.GetEffect(effect3),
                effectBrowser.GetEffect(effect4)
            };
            this.weight = weight;
            this.value = value;
            this.obtained = obtained;
        }

        public bool HasEffect(Effect effect)
        {
            foreach(Effect e in effects)
            {
                if (e.name == effect.name)
                    return true;
            }
            return false;
        }
        public Effect[] GetCommonEffects(Ingredient ingredient)
        {
            List<Effect> common = new List<Effect>();
            foreach(Effect effect in effects)
            {
                if (ingredient.HasEffect(effect))
                    common.Add(effect);
            }
            return common.ToArray();
        }

        public override string ToString()
        {
            return name;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
    public class IngredientBrowser
    {
        readonly List<Ingredient> ingredients = new List<Ingredient>();
        readonly EffectBrowser effectBrowser = new EffectBrowser("effects.txt");
        internal IngredientBrowser(string filename)
        {
            using (FileParser parser = new FileParser("ingredients.txt"))
            {
                string[] ingredient = parser.ParseLine();   //dummy read to pass headers
                while ((ingredient = parser.ParseLine()) != null)
                {
                    ingredients.Add(new Ingredient(ingredient[0],   //name
                        ingredient[1],  //effect1
                        ingredient[2],  //effect2
                        ingredient[3],  //effect3
                        ingredient[4],  //effect4
                        (float)Convert.ToDouble(ingredient[5]),  //weight
                        Convert.ToInt32(ingredient[6]),  //value
                        ingredient[7],  //obtained
                        effectBrowser  //effectbrowser
                        ));
                }
            }
        }
        public Ingredient GetIngredient(string name)
        {
            foreach (Ingredient ingredient in ingredients)
            {
                if (ingredient.name == name)
                {
                    return ingredient;
                }
            }
            return null;
        }
        public Ingredient[] GetAllIngredients()
        {
            return ingredients.ToArray();
        }
    }
}
