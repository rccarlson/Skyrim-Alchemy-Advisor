using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionSeller
{
    public class Ingredient
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
                for (int i = 0; i < 4; i++)
                    effects[i] = ReadToTab(reader);
                weight = (float)Convert.ToDecimal(ReadToTab(reader));
                value = (float)Convert.ToDecimal(ReadToTab(reader));
                obtained = ReadToTab(reader);
            }
        }
        static string ReadToTab(StringReader reader)
        {
            StringBuilder builder = new StringBuilder();
            char c = '\0';
            while ((c = (char)reader.Read()) != '\t' && c != 65535)
            {
                if ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,.- ".Contains(c))
                    builder.Append(c);
            }
            return builder.ToString();
        }
        public List<string> GetCommonEffects(Ingredient ingredient)
        {
            List<string> common = new List<string>();
            foreach (string selfEffect in effects)
            {
                foreach (string otherEffect in ingredient.effects)
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
        public override string ToString()
        {
            return name;
        }
    }
}
