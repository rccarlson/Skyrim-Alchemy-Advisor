using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyrimAlchemy2
{
    public class Effect
    {
        public readonly string name, description;
        public readonly bool beneficial, poisonous, variableMagnitude, variableDuration;
        public readonly float magnitude, base_cost;
        public readonly int duration, value, base_duration, base_magnitude;
        readonly PartialEffect partialEffect;

        public Effect(string name, float magnitude, int duration, int value)
        {
            this.partialEffect = PartialEffect.partialEffects.Find(e => e.name == name);
            this.name = name;
            this.description = partialEffect.description;
            this.beneficial = partialEffect.beneficial;
            this.poisonous = partialEffect.poisonous;
            this.variableMagnitude = partialEffect.variableMagnitude;
            this.variableDuration = partialEffect.variableDuration;
            this.magnitude = magnitude;
            this.duration = duration;
            this.value = value;
        }
        public Effect(string name, string magnitude, string duration, string value)
        {
            this.partialEffect = PartialEffect.partialEffects.Find(e => e.name == name);
            this.name = name;
            this.description = partialEffect.description;
            this.beneficial = partialEffect.beneficial;
            this.poisonous = partialEffect.poisonous;
            this.variableMagnitude = partialEffect.variableMagnitude;
            this.variableDuration = partialEffect.variableDuration;
            this.magnitude = Convert.ToSingle(magnitude);
            this.duration = Convert.ToInt32(duration);
            this.value = Convert.ToInt32(value);
            this.base_cost = partialEffect.base_cost;
            this.base_magnitude = partialEffect.base_magnitude;
            this.base_duration = partialEffect.base_duration;
        }

        public override string ToString()
        {
            return name;
        }

    }
    struct PartialEffect
    {
        public static List<PartialEffect> partialEffects = GetPartialEffects("effects.csv");

        public readonly string name, description;
        public readonly bool beneficial, poisonous, variableMagnitude, variableDuration;
        public readonly float base_cost;
        public readonly int base_magnitude, base_duration;
        //Effect (ID),Description,Base_Cost,Base_Mag,Base_Dur,Beneficial,Poisonous,Power Affects Magnitude,Power Affects Duration
        public PartialEffect(string name, string description, string base_cost, string base_magnitude, string base_duration, string beneficial, string poisonous, string variableMagnitude, string variableDuration)
        {
            this.name = name;
            this.description = description;
            this.base_cost = Convert.ToSingle(base_cost);
            this.base_magnitude = Convert.ToInt32(base_magnitude);
            this.base_duration = Convert.ToInt32(base_duration);
            this.beneficial = beneficial == "Y";
            this.poisonous = poisonous == "Y";
            this.variableMagnitude = variableMagnitude == "Y";
            this.variableDuration = variableDuration == "Y";
        }

        static List<PartialEffect> GetPartialEffects(string filename, bool ignoreFirstLine = true)
        {
            List<PartialEffect> effects = new List<PartialEffect>();
            using (Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(filename))
            {
                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                parser.SetDelimiters(",");
                if (ignoreFirstLine)
                    parser.ReadFields();
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields.Length == 9)
                    {
                        PartialEffect e = new PartialEffect(fields[0],
                            fields[1],
                            fields[2],
                            fields[3],
                            fields[4],
                            fields[5],
                            fields[6],
                            fields[7],
                            fields[8]);
                        effects.Add(e);
                    }
                }
            }
            return effects;
        }
    }
}
