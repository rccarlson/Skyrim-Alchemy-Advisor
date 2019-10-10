using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get all ingredients from text file
            List<Ingredient> ingredients = new List<Ingredient>();
            using (FileStream file = new FileStream("ingredients.txt", FileMode.Open))
            using(StreamReader reader = new StreamReader(file))
            {
                reader.ReadLine();
                while (file.Position < file.Length)
                {
                    ingredients.Add(new Ingredient(reader.ReadLine()));
                }
            }

            //List all possible potions
            List<Potion> potions = new List<Potion>();
            int count = ingredients.Count;
            for (int i = 0; i < count; i++)
                for (int j = i + 1; j < count; j++)
                    for(int k = j; k < count; k++)
                    {
                        Potion potion = new Potion(new Ingredient[] { ingredients[i], ingredients[j], ingredients[k] });
                        if (potion.effects.Count > 0)
                            potions.Add(potion);
                    }

            //Categorize by number of effects
            List<List<Potion>> potionsByEffectCount = new List<List<Potion>>();
            for(int i = 0; i < 2;i++)
            {
                potionsByEffectCount.Add(new List<Potion>());
            }
            for(int i = 0; i < potions.Count; i++)
            {
                int effectCount = potions[i].effects.Count;
                while(potionsByEffectCount.Count <= effectCount)
                    potionsByEffectCount.Add(new List<Potion>());
                potionsByEffectCount[effectCount].Add(potions[i]);
            }

            //Print the 5 ingredient combos
            foreach(Potion maxPotion in potionsByEffectCount[5])
            {
                Console.WriteLine("Potion:");
                Console.WriteLine("\tEffects:");
                foreach(string effect in maxPotion.effects)
                {
                    Console.WriteLine("\t\t" + effect);
                }
                Console.WriteLine("\tIngredients:");
                foreach(Ingredient ingredient in maxPotion.ingredients)
                {
                    Console.WriteLine("\t\t" + ingredient.name);
                }
            }
        }
    }
    class Ingredient
    {
        public readonly string name;
        public readonly string[] effects;
        public readonly float weight;
        public readonly float value;
        public readonly string obtained;
        public Ingredient(string s)
        {
            effects = new string[4];
            using (StringReader reader = new StringReader(s))
            {
                name = ReadToTab(reader);
                for(int i = 0; i < 4; i++)
                    effects[i] = ReadToTab(reader);
                weight = (float)Convert.ToDecimal(ReadToTab(reader));
                value = (float)Convert.ToDecimal(ReadToTab(reader));
                obtained = ReadToTab(reader);
                //Console.WriteLine(name);
            }
        }
        static string ReadToTab(StringReader reader)
        {
            StringBuilder builder = new StringBuilder();
            char c = '\0';
            while((c=(char)reader.Read())!='\t' && c!=65535)
            {
                if ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,.- ".Contains(c))
                    builder.Append(c);
            }
            return builder.ToString();
        }
        public override string ToString()
        {
            return name;
        }
        public List<string> GetCommonEffects(Ingredient ingredient)
        {
            List<string> common = new List<string>();
            foreach(string selfEffect in effects)
            {
                foreach(string otherEffect in ingredient.effects)
                {
                    if (selfEffect == otherEffect && !common.Contains(selfEffect))
                        common.Add(selfEffect);
                }
            }
            return common;
        }
        public bool HasEffect(string effect)
        {
            return effects.Contains(effect);
        }
    }
    class Potion
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
            for(int i = 0; i < count; i++)
            {
                for(int j = i + 1; j < count; j++)
                {
                    List<string> common = ingredients[i].GetCommonEffects(ingredients[j]);
                    foreach (string effect in common)
                        if (!effects.Contains(effect))
                            effects.Add(effect);
                }
            }

            List<Ingredient> contributingIngredients = new List<Ingredient>();
            foreach(Ingredient ingredient in this.ingredients)
            {
                foreach(string effect in this.effects)
                {
                    if (ingredient.HasEffect(effect) && !contributingIngredients.Contains(ingredient))
                        contributingIngredients.Add(ingredient);
                }
            }
            this.ingredients = contributingIngredients.ToArray();
        }
        public override string ToString()
        {
            if (effects.Count > 0)
            {
                StringBuilder builder = new StringBuilder(effects[0]);
                for(int i = 1; i < effects.Count; i++)
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
}
