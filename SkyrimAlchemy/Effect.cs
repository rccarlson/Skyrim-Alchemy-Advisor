using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimAlchemy
{
    public class Effect
    {
        public static readonly List<Effect> effects = GetEffects("effects.csv");

        public readonly string name, description;
        public readonly float baseCost, baseMag, baseDur;
        public readonly int maxValue;
        public readonly bool beneficial, poisonous, powerAffectsMagnitude, powerAffectsDuration;

        protected Effect(string id, string description, string baseCost, string baseMag, string baseDur, string maxValue, string beneficial, string poisonous, string powerAffectsMagnitude, string powerAffectsDuration)
        {
            this.name = id;
            this.description = description;
            this.baseCost = Convert.ToSingle(baseCost);
            this.baseMag = Convert.ToSingle(baseMag);
            this.baseDur = Convert.ToSingle(baseDur);
            this.maxValue = Convert.ToInt32(maxValue);
            this.beneficial = beneficial == "Y";
            this.poisonous = poisonous == "Y";
            this.powerAffectsMagnitude = powerAffectsMagnitude == "Y";
            this.powerAffectsDuration = powerAffectsDuration == "Y";
        }
        protected Effect(string name, string description, float baseCost, float baseMag, float baseDur, int maxValue, bool beneficial, bool poisonous, bool powerAffectsMagnitude, bool powerAffectsDuration)
        {
            this.name = name;
            this.description = description;
            this.baseCost = baseCost;
            this.baseMag = baseMag;
            this.baseDur = baseDur;
            this.maxValue = maxValue;
            this.beneficial = beneficial;
            this.poisonous = poisonous;
            this.powerAffectsMagnitude = powerAffectsMagnitude;
            this.powerAffectsDuration = powerAffectsDuration;
        }

        static List<Effect> GetEffects(string filename, bool ignoreFirstLine = true)
        {
            List<Effect> effects = new List<Effect>();
            using(Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(filename))
            {
                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                parser.SetDelimiters(",");
                if (ignoreFirstLine)
                    parser.ReadFields();
                while(!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if(fields.Length == 10)
                    {
                        Effect e = new Effect(fields[0],
                            fields[1],
                            fields[2],
                            fields[3],
                            fields[4],
                            fields[5],
                            fields[6],
                            fields[7],
                            fields[8],
                            fields[9]);
                        effects.Add(e);
                    }
                }
            }
            return effects;
        }

        public static Effect GetEffect(string name)
        {
            return effects.Find(e => e.name == name);
        }

        //public static Effect GetEffectByIngredient(string ingredient, string effectName)
        //{
        //    EffectException exception = EffectException.GetException(ingredient, effectName);
        //    Effect effect = GetEffect(effectName);
        //    if (exception != null)
        //    {
        //        return new Effect(effect.name,
        //            effect.description,
        //            effect.baseCost * exception.value,
        //            effect.baseMag * exception.magnitude,
        //            effect.baseDur * exception.duration,
        //            effect.maxValue,
        //            effect.beneficial,
        //            effect.powerAffectsMagnitude,
        //            effect.powerAffectsDuration);
        //    }
        //    else
        //    {
        //        return effect;
        //    }
        //}

        public override string ToString()
        {
            return name;
        }
    }
}
