using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PotionSeller
{
    class Effect
    {
        public readonly string name, description;
        public readonly float base_cost;
        public readonly int base_mag, base_dur, value;
        public Effect(string entry)
        {

        }
    }
    public class EffectBrowser
    {
        public EffectBrowser()
        {
            using (FileStream file = new FileStream("effects.txt", FileMode.Open))
            {
                
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
    }
}
