using System.Collections.Generic;
using RimWorld;
using Verse;

namespace RJW_Unleashed_Gastronomy
{
    [DefOf]
    public static class EffectDefs
    {
        private static List<ThoughtDef> _thoughtDefs;

        public static ThoughtDef thought = ThoughtDef.Named("thought");
        // Sexpanded
        public static ThoughtDef CocktusThought = ThoughtDef.Named("CocktusEffect");
        public static ThoughtDef FriginaThought = ThoughtDef.Named("FriginaEffect");
        public static ThoughtDef AteCumThought = ThoughtDef.Named("AteCum");
        

        private static List<HediffDef> _hediffDefs;

        public static HediffDef Test_hediff = HediffDef.Named("hediff");
        public static HediffDef ToxicBuildupHediff = HediffDef.Named("ToxicBuildup");
        // Sexpanded
        public static HediffDef CocktusHediff = HediffDef.Named("CocktusEffect");
        public static HediffDef UdderfruitHediff = HediffDef.Named("UdderfruitEffect");
        public static HediffDef FriginaHediff = HediffDef.Named("FriginaEffect");
        // Sexperience
        public static HediffDef CumToleranceHediff = HediffDef.Named("CumTolerance");
        public static HediffDef CumAddictionHediff = HediffDef.Named("CumAddiction");
        public static NeedDef Chemical_Cum = DefDatabase<NeedDef>.GetNamed("Chemical_Cum");


        public static List<ThoughtDef> AllThoughts
        {
            get
            {
                List<ThoughtDef> thoughtDefs = EffectDefs._thoughtDefs;
                if (thoughtDefs != null)
                    return thoughtDefs;
                List<ThoughtDef> allThoughts = new List<ThoughtDef>();
                allThoughts.Add(EffectDefs.thought);
                allThoughts.Add(EffectDefs.CocktusThought);
                allThoughts.Add(EffectDefs.FriginaThought);
                EffectDefs._thoughtDefs = allThoughts;
                return allThoughts;
            }
        }
        public static List<HediffDef> AllHediffs
        {
            get
            {
                List<HediffDef> hediffDefs = EffectDefs._hediffDefs;
                if (hediffDefs != null)
                    return hediffDefs;
                List<HediffDef> allHediffs = new List<HediffDef>();
                allHediffs.Add(EffectDefs.Test_hediff);
                allHediffs.Add(EffectDefs.CocktusHediff);
                allHediffs.Add(EffectDefs.UdderfruitHediff);
                allHediffs.Add(EffectDefs.FriginaHediff);
                EffectDefs._hediffDefs = allHediffs;
                return allHediffs;
            }
        }
    }
}