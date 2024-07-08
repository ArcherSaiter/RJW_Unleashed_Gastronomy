using System.Collections.Generic;
using RimWorld;
using Verse;

namespace RJW_Unleashed_Gastronomy
{
    [DefOf]
    public static class IngredientDefs
    {
        private static List<ThingDef> _ingrDefs;

        // Test object
		public static ThingDef RawSleepBerries = ThingDef.Named("RawSleepBerries");
		// SeXpanded Core
        public static ThingDef RJWseXpandedCore_RawCocktus = ThingDef.Named("RJWReProduce_RawCocktus");
		public static ThingDef RJWseXpandedCore_RawUdderfruit = ThingDef.Named("RJWReProduce_RawUdderfruit");
		public static ThingDef RJWseXpandedCore_RawToxicle = ThingDef.Named("RJWReProduce_RawToxicle");
		public static ThingDef RJWseXpandedCore_RawFrigina = ThingDef.Named("RJWReProduce_RawFrigina");
		// Sexperience
        public static ThingDef SexperienceCum = ThingDef.Named("GatheredCum");

        public static List<ThingDef> AllIngredients
        {
            get
            {
                List<ThingDef> ingrDefs = IngredientDefs._ingrDefs;
                if (ingrDefs != null)
                    return ingrDefs;
                List<ThingDef> allIngredients = new List<ThingDef>();
                allIngredients.Add(IngredientDefs.RawSleepBerries);
				allIngredients.Add(IngredientDefs.RJWseXpandedCore_RawCocktus);
				allIngredients.Add(IngredientDefs.RJWseXpandedCore_RawUdderfruit);
				allIngredients.Add(IngredientDefs.RJWseXpandedCore_RawToxicle);
				allIngredients.Add(IngredientDefs.RJWseXpandedCore_RawFrigina);
				allIngredients.Add(IngredientDefs.SexperienceCum);
                IngredientDefs._ingrDefs = allIngredients;
                return allIngredients;
            }
        }
    }
}