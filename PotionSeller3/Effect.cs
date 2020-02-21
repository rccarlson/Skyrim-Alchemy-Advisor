using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotionSeller3
{
    public class Effect
    {
        public static List<Effect> effectList;

        public readonly string name, description;
        public readonly float baseCost, baseMag, baseDur;
        public readonly int maxValue;
        public readonly bool beneficial, powerAffectsMagnitude, powerAffectsDuration;
        //Effect (ID)	Description	Base_Cost	Base_Mag	Base_Dur	Gold Value at 100 Skill
        //Cure Disease	Cures all diseases.	0.5	5	0	21
        public Effect(string id,string description,string baseCost, string baseMag, string baseDur, string maxValue, string beneficial, string powerAffectsMagnitude, string powerAffectsDuration)
        {
            this.name = id;
            this.description = description;
            this.baseCost = Convert.ToSingle(baseCost);
            this.baseMag = Convert.ToSingle(baseMag);
            this.baseDur = Convert.ToSingle(baseDur);
            this.maxValue = Convert.ToInt32(maxValue);
            this.beneficial = beneficial == "Y";
            this.powerAffectsMagnitude = powerAffectsMagnitude == "Y";
            this.powerAffectsDuration = powerAffectsDuration == "Y";
        }
        public Effect(string id, string description, float baseCost, float baseMag, float baseDur, int maxValue,bool beneficial, bool powerAffectsMagnitude, bool powerAffectsDuration)
        {
            this.name = id;
            this.description = description;
            this.baseCost = baseCost;
            this.baseMag = baseMag;
            this.baseDur = baseDur;
            this.maxValue = maxValue;
            this.beneficial = beneficial;
            this.powerAffectsMagnitude = powerAffectsMagnitude;
            this.powerAffectsDuration = powerAffectsDuration;
        }
        public Effect(List<string> vs)
        {
            this.name = vs[0];
            this.description = vs[1];
            this.baseCost = Convert.ToSingle(vs[2]);
            this.baseMag = Convert.ToSingle(vs[3]);
            this.baseDur = Convert.ToSingle(vs[4]);
            this.maxValue = Convert.ToInt32(vs[5]);
            this.beneficial = vs[5] == "Y";
            this.powerAffectsMagnitude = vs[6] == "Y";
            this.powerAffectsDuration = vs[7] == "Y";
        }
        public override string ToString()
        {
            return name;
        }

        public static Effect GetEffect(string name)
        {
            return effectList.Find(e => e.name == name);
        }

    }
}

public class EffectExceptions
{
    //Ingredient	Effect	Magnitude	Duration	Value
    protected EffectExceptions(string ingredient, string effect, string magnitude, string duration, string value)
    {

    }

}