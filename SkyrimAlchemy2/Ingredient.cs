using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyrimAlchemy
{
    public class Ingredient
    {
        public static readonly List<Ingredient> ingredients = GetIngredients("ingredients.csv");

        public readonly List<Effect> effects;
        public readonly float weight;
        public readonly int value;
        public readonly string name, obtained;

        protected Ingredient(string name, Effect effect1, Effect effect2, Effect effect3, Effect effect4, float weight, int value, string obtained)
        {
            this.name = name;
            this.effects = new List<Effect>() { effect1, effect2, effect3, effect4 };
            this.weight = weight;
            this.value = value;
            this.obtained = obtained;
        }

        public bool HasEffectByName(Effect effect)
        {
            return effects[0].name == effect.name
                || effects[1].name == effect.name
                || effects[2].name == effect.name
                || effects[3].name == effect.name;
        }

        static List<Ingredient> GetIngredients(string filename, bool ignoreFirstLine = true)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            using (Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(filename))
            {
                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                parser.SetDelimiters(",");
                if (ignoreFirstLine)
                    parser.ReadFields();
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields.Length == 20)
                    {
                        Effect effect1 = new Effect(fields[1], fields[2], fields[3], fields[4]);
                        Effect effect2 = new Effect(fields[5], fields[6], fields[7], fields[8]);
                        Effect effect3 = new Effect(fields[9], fields[10], fields[11], fields[12]);
                        Effect effect4 = new Effect(fields[13], fields[14], fields[15], fields[16]);
                        Ingredient e = new Ingredient(fields[0]//name
                            , effect1, effect2, effect3, effect4
                            , Convert.ToSingle(fields[17])//weight
                            , Convert.ToInt32(fields[18])//value
                            , fields[19] //obtained
                            );
                        ingredients.Add(e);
                    }
                }
            }
            return ingredients;
        }

        public static Ingredient GetIngredient(string name)
        {
            return ingredients.Find(i => i.name == name);
        }

        public override string ToString()
        {
            return name;
        }
    }
}
