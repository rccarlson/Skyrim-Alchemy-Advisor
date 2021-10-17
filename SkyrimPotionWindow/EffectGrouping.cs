using SkyrimAlchemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyrimPotionWindow
{
    class EffectGrouping
    {
        public readonly List<string> effects = new List<string>();
        public readonly List<int> values = new List<int>();
        public readonly List<List<Potion>> potions = new List<List<Potion>>();
        int maxIndex = -1;
        public EffectGrouping() { }
        public EffectGrouping(IEnumerable<Potion> potions)
        {
            foreach (Potion potion in potions)
                Add(potion);
        }
        int IndexOfEffect(string effectString, int value)
        {
            for (int i = 0; i < effects.Count; i++)
            {
                if (effects[i] == effectString && values[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Add(Potion potion)
        {
            string effectString = GetEffectGroupString(potion);
            int value = potion.Value;
            int index = IndexOfEffect(effectString, value);
            if (index < 0)
            {
                effects.Add(effectString);
                values.Add(value);
                potions.Add(new List<Potion>() { potion });
                maxIndex++;
            }
            else
            {
                potions[index].Add(potion);
            }
        }
        public List<Potion> GetPotions(string effectString, int value)
        {
            int index = IndexOfEffect(effectString, value);
            if (index < 0)
                return null;
            else
            {
                return potions[index].OrderBy(l => l.ingredients.Count).ToList();
            }
        }

        protected static string GetEffectGroupString(Potion potion)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < potion.effects.Count; i++)
            {
                if (i != 0)
                {
                    builder.Append(", ");
                }
                builder.Append(potion.effects[i].name);
            }
            return builder.ToString();
        }
    }

}
