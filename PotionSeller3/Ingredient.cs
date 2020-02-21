using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotionSeller3
{
    public class Ingredient
    {
        public static List<Ingredient> ingredientList;

        public readonly string name, obtained;
        public readonly Effect effect1, effect2, effect3, effect4;
        public readonly float weight;
        public readonly int value;
        public readonly List<Effect> effects;
        //Ingredient	Primary Effect	Secondary Effect	Tertiary Effect	Quaternary Effect	Weight 	Value 	Obtained
        public Ingredient(string name, string primaryEffectName, string secondaryEffectName, string tertiaryEffectName, string quaternaryEffectName, string weightString, string valueString, string obtained)
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
        public override string ToString()
        {
            return name;
        }
        public static Ingredient GetIngredient(string name)
        {
            return ingredientList.Find(i => i.name == name);
        }
    }
}
