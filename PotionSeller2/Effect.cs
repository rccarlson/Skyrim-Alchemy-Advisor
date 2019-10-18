using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionSeller2
{
    public class Effect
    {
        public readonly string name, description;
        public readonly float base_cost;
        public readonly int base_mag, base_dur, value;
        internal Effect(string name, string description, float base_cost, int base_mag, int base_dur, int value)
        {
            this.name = name;
            this.description = description;
            this.base_cost = base_cost;
            this.base_mag = base_mag;
            this.base_dur = base_dur;
            this.value = value;
        }
        public static string GetEffectString(List<Effect> effects)
        {
            return GetEffectString(effects.ToArray());
        }
        public static string GetEffectString(Effect[] effects)
        {
            if (effects.Length == 0)
                return null;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < effects.Length - 2; i++)
                builder.Append(effects[i].name + ",");
            builder.Append(effects[effects.Length - 1]);
            return builder.ToString();
        }
        
        public static Effect GetHighestValueEffect(Effect[] effects)
        {
            if (effects.Length == 0)
                return null;
            Effect highest = effects[0];
            foreach(Effect effect in effects)
                if (effect.value > highest.value)
                    highest = effect;
            return highest;
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
    internal class EffectBrowser
    {
        //Effect (ID)	Description	        Base_Cost	Base_Mag	Base_Dur	Gold Value at 100 Skill
        //Cure Disease	Cures all diseases.	0.5	        5	        0	        21
        readonly List<Effect> effects = new List<Effect>();
        internal EffectBrowser(string filename)
        {
            using(FileParser parser = new FileParser("effects.txt"))
            {
                string[] effect = parser.ParseLine();   //dummy read to pass headers
                while ((effect = parser.ParseLine()) != null)
                {
                    effects.Add(new Effect(effect[0],   //name
                        effect[1],  //description
                        (float)Convert.ToDouble(effect[2]), //cost
                        Convert.ToInt32(effect[3]),    //mag
                        Convert.ToInt32(effect[4]),    //dur
                        Convert.ToInt32(effect[5])     //value
                        ));
                }
            }
        }

        /// <summary>
        /// Returns <see cref="Effect"/> where <see cref="Effect.name"/> is equal to <paramref name="name"/>
        /// </summary>
        /// <param name="name">Name of <see cref="Effect"/></param>
        /// <returns><see cref="Effect"/> with matching name</returns>
        public Effect GetEffect(string name)
        {
            foreach(Effect effect in effects)
            {
                if (effect.name == name)
                {
                    return effect;
                }
            }
            return null;
        }
        public Effect[] GetAllEffects()
        {
            return effects.ToArray();
        }
    }
}
