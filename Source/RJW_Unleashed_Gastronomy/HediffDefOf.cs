//using RimWorld;
//using System.Collections.Generic;

//namespace VanillaCookingExpanded
//{
//    [DefOf]
//    public static class ThoughtDefs
//    {
//        private static List<ThoughtDef> _thoughtDefs;
//        public static ThoughtDef VCE_ConsumedSugar;
//        public static ThoughtDef VCE_ConsumedChocolateSyrup;
//        public static ThoughtDef VCE_ConsumedInsectJelly;
//        public static ThoughtDef VCE_SmokeleafButterHigh;
//        public static ThoughtDef VCE_ConsumedSalt;
//        public static ThoughtDef VCE_ConsumedMayo;
//        public static ThoughtDef VCE_ConsumedAgave;
//        public static ThoughtDef VCE_ConsumedSpices;
//        public static ThoughtDef VCE_ConsumedDigestibleResurrectorNanites;
//        public static ThoughtDef VCE_AteFriedGoods;
//        public static ThoughtDef VCE_ConsumedCannedGoods;

//        public static List<ThoughtDef> AllThoughts
//        {
//            get
//            {
//                List<ThoughtDef> thoughtDefs = ThoughtDefs._thoughtDefs;
//                if (thoughtDefs != null)
//                    return thoughtDefs;
//                List<ThoughtDef> allThoughts = new List<ThoughtDef>();
//                allThoughts.Add(ThoughtDefs.VCE_ConsumedSugar);
//                allThoughts.Add(ThoughtDefs.VCE_ConsumedChocolateSyrup);
//                allThoughts.Add(ThoughtDefs.VCE_ConsumedInsectJelly);
//                allThoughts.Add(ThoughtDefs.VCE_SmokeleafButterHigh);
//                allThoughts.Add(ThoughtDefs.VCE_ConsumedSalt);
//                allThoughts.Add(ThoughtDefs.VCE_ConsumedMayo);
//                allThoughts.Add(ThoughtDefs.VCE_ConsumedAgave);
//                allThoughts.Add(ThoughtDefs.VCE_ConsumedSpices);
//                allThoughts.Add(ThoughtDefs.VCE_ConsumedDigestibleResurrectorNanites);
//                allThoughts.Add(ThoughtDefs.VCE_AteFriedGoods);
//                allThoughts.Add(ThoughtDefs.VCE_ConsumedCannedGoods);
//                ThoughtDefs._thoughtDefs = allThoughts;
//                return allThoughts;
//            }
//        }
//    }
//}