//using System;
//using System.Collections.Generic;
//using RimWorld;
//using Verse;

////namespace RJW_Unleashed_Gastronomy
////{
////    [DefOf]
////    public static class IngredientDefs
////    {
////        public static HashSet<ThingDef> _ingrDefs;
////        public static ThingDef RawSleepBerries;
////        public static ThingDef SleepBerries;
////        public static ThingDef Berries;

////        public static HashSet<ThingDef> AllIngredients
////        {
////            get
////            {
////                HashSet<ThingDef> ingrDefs = IngredientDefs._ingrDefs;
////                if (ingrDefs != null)
////                    return ingrDefs;
////                HashSet<ThingDef> allIngredients = new HashSet<ThingDef>();
////                allIngredients.Add(IngredientDefs.RawSleepBerries);
////                allIngredients.Add(IngredientDefs.SleepBerries);
////                allIngredients.Add(IngredientDefs.Berries);
////                IngredientDefs._ingrDefs = allIngredients;
////                return allIngredients;
////            }
////        }
////    }
////}

//namespace RJW_Unleashed_Gastronomy
//{
//    [DefOf]
//    public static class IngredientDefs
//    {
//        public static List<ThingDef> _ingrDefs;
//        public static ThingDef RawSleepBerries;
//        public static List<ThingDef> AllIngredients
//        {
//            get
//            {
//                if (_ingrDefs != null)
//                    return _ingrDefs;

//                _ingrDefs = new List<ThingDef>
//                {
//                    RawSleepBerries,
//                };

//                return _ingrDefs;
//            }
//        }
//    }
//}
using System.Collections.Generic;
using RimWorld;
using Verse;

//namespace RJW_Unleashed_Gastronomy
//{
//    [DefOf]
//    public static class IngredientDefs
//    {
//        public static ThingDef RawSleepBerries;

//        private static List<ThingDef> _ingrDefs;
//        public static List<ThingDef> AllIngredients
//        {
//            get
//            {
//                if (_ingrDefs == null)
//                {
//                    _ingrDefs = new List<ThingDef>
//                    {
//                        RawSleepBerries,
//                    };
//                }
//                return _ingrDefs;
//            }
//        }

//        static IngredientDefs()
//        {
//            DefOfHelper.EnsureInitializedInCtor(typeof(IngredientDefs));
//        }
//    }
//}

namespace RJW_Unleashed_Gastronomy
{
    [DefOf]
    public static class IngredientDefs
    {
        private static List<ThingDef> _ingrDefs;

        public static ThingDef RawSleepBerries = ThingDef.Named("RawSleepBerries");

        
        public static List<ThingDef> AllIngredients
        {
            get
            {
                List<ThingDef> ingrDefs = IngredientDefs._ingrDefs;
                if (ingrDefs != null)
                    return ingrDefs;
                List<ThingDef> allIngredients = new List<ThingDef>();
                allIngredients.Add(IngredientDefs.RawSleepBerries);

                IngredientDefs._ingrDefs = allIngredients;
                return allIngredients;
            }
        }
    }
}