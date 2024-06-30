using System.Collections.Generic;
using System;
using System.Linq;
using RimWorld;
using Verse;

namespace RJW_Unleashed_Gastronomy
{
    public class RJW_Unleashed_GastronomyIngestionOutcomeDoer : IngestionOutcomeDoer
    {
        private Dictionary<ThingDef, Action<Pawn, int>> ingredientEffects;
        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int ingestedcount)
        {
            InitializeIngredientEffects();
            CompIngredients compIngredients = ingested.TryGetComp<CompIngredients>();

            if (compIngredients != null && IngredientDefs.AllIngredients != null && pawn != null)
            {
                foreach (ThingDef ingredient in compIngredients.ingredients)
                {
                    if (IngredientDefs.AllIngredients.Contains(ingredient))
                    {
                        ApplyIngredientEffect(pawn, ingredient, ingestedcount);
                    }
                }
            }
        }
        private void InitializeIngredientEffects()
        {
            ingredientEffects = new Dictionary<ThingDef, Action<Pawn, int>>
            {
                { IngredientDefs.RawSleepBerries, RawSleepBerriesEffect }
            };
        }
        private void ApplyIngredientEffect(Pawn pawn, ThingDef ingredient, int ingestedcount)
        {
            if (ingredientEffects.TryGetValue(ingredient, out Action<Pawn, int> effect))
            {
                effect(pawn, ingestedcount);
            }
            else
            {
                Log.Warning($"No effect defined for ingredient: {ingredient.defName}");
            }
        }
        //private void RawSleepBerriesEffect(Pawn pawn, int ingestedcount)
        //{
        //    // Implement the effect for Raw Sleep Berries
        //    // For example, add a hediff or modify a need

        //    Log.Message($"{pawn.Name} ingested Raw Sleep Berries. Applying effect...");
        //}
        private void RawSleepBerriesEffect(Pawn pawn, int ingestedcount)
        {
            if (pawn.needs?.rest != null)
            {
                pawn.needs.rest.CurLevel = 0f;
                Log.Message($"{pawn.Name}'s rest need has been completely drained due to ingesting Raw Sleep Berries.");
            }
            else
            {
                Log.Warning($"Unable to modify rest need for {pawn.Name}. Rest need is null.");
            }
        }
    }
}