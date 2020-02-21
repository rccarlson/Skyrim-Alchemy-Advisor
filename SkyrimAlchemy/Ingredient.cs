using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimAlchemy
{
    public class Ingredient
    {
        public static List<Ingredient> ingredients = GetIngredients("ingredients.csv");

        #region INSTANCE VARIABLES
        public readonly string name, obtained;
        public readonly Effect effect1, effect2, effect3, effect4;
        public readonly float weight;
        public readonly int value;
        public readonly List<Effect> effects;
        #endregion

        //Ingredient	Primary Effect	Secondary Effect	Tertiary Effect	Quaternary Effect	Weight 	Value 	Obtained
        protected Ingredient(string name, string primaryEffectName, string secondaryEffectName, string tertiaryEffectName, string quaternaryEffectName, string weightString, string valueString, string obtained)
        {
            this.name = name;
            effect1 = Effect.GetEffect(primaryEffectName);
            effect2 = Effect.GetEffect(secondaryEffectName);
            effect3 = Effect.GetEffect(tertiaryEffectName);
            effect4 = Effect.GetEffect(quaternaryEffectName);
            this.weight = Convert.ToSingle(weightString);
            this.value = Convert.ToInt32(valueString);
            this.obtained = obtained;
            effects = new List<Effect> { effect1, effect2, effect3, effect4 };
        }

        private static List<Ingredient> GetIngredients(string filename, bool ignoreFirstLine = true)
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
                    if (fields.Length == 8)
                    {
                        Ingredient i = new Ingredient(fields[0],
                            fields[1],
                            fields[2],
                            fields[3],
                            fields[4],
                            fields[5],
                            fields[6],
                            fields[7]);
                        ingredients.Add(i);
                    }
                }
            }
            return ingredients;
        }

        public override string ToString()
        {
            return name;
        }

        public static Ingredient GetIngredient(string name)
        {
            return ingredients.Find(i => i.name == name);
        }

    }

    //class EffectException
    //{
    //    public static List<EffectException> exceptions = GetExceptions("effect_exceptions.csv");

    //    public readonly string ingredient, effect;
    //    public readonly float magnitude, duration, value;

    //    //Ingredient,Effect,Magnitude,Duration,Value
    //    protected EffectException(string ingredient, string effect, string magnitude, string duration, string value)
    //    {
    //        this.ingredient = ingredient;
    //        this.effect = effect;
    //        this.magnitude = Convert.ToSingle(magnitude);
    //        this.duration = Convert.ToSingle(duration);
    //        this.value = Convert.ToSingle(value);
    //    }

    //    static List<EffectException> GetExceptions(string filename, bool ignoreFirstLine = true)
    //    {
    //        List<EffectException> exceptions = new List<EffectException>();
    //        using (Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(filename))
    //        {
    //            parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
    //            parser.SetDelimiters(",");
    //            if (ignoreFirstLine)
    //                parser.ReadFields();
    //            while (!parser.EndOfData)
    //            {
    //                string[] fields = parser.ReadFields();
    //                if (fields.Length == 9)
    //                {
    //                    EffectException e = new EffectException(fields[0],
    //                        fields[1],
    //                        fields[2],
    //                        fields[3],
    //                        fields[4]);
    //                    exceptions.Add(e);
    //                }
    //            }
    //        }
    //        return exceptions;
    //    }

    //    public static EffectException GetException(string ingredientName, string effectName)
    //    {
    //        return exceptions.Find(e => e.ingredient == ingredientName && e.effect == effectName);
    //    }

    //}
}
