using RimWorld;
using Verse;
using RJW_Unleashed_Framework;

namespace RJW_Unleashed_Gastronomy
{
    public class RJW_Unleashed_GastronomyIngestionOutcomeDoer : IngestionOutcomeDoer
    {
        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing thing, int ingestedcount)
        {
            if (thing == null) return;
            if (pawn == null) return;
            CompIngredients compIngredients = thing.TryGetComp<CompIngredients>();
            if (compIngredients == null) return;
            ThingDef thingDef = thing.def;

            for (int i = 0; i < ingestedcount; i++)
            {
                foreach (ThingDef ingredient in compIngredients.ingredients)
                {
                    ApplyEffect.FullExtension(pawn, ingredient);
                    if (ingredient.GetModExtension<TransformationAddon>() != null)
                    {
                        ApplyEffect.ExtensionApplierGenetic(pawn, ingredient);
                    }
                }
            }
        }
    }
}