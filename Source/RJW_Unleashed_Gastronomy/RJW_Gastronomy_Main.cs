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
        public void InitializeIngredientEffects()
        {
            ingredientEffects = new Dictionary<ThingDef, Action<Pawn, int>>
            {
                { IngredientDefs.RawSleepBerries, IngrEffectMethods.RawSleepBerriesEffect },
                { IngredientDefs.RJWseXpandedCore_RawCocktus, IngrEffectMethods.RawCocktusEffect },
                { IngredientDefs.RJWseXpandedCore_RawUdderfruit, IngrEffectMethods.RawUdderfruitEffect },
                { IngredientDefs.RJWseXpandedCore_RawToxicle, IngrEffectMethods.RawToxicleEffect },
                { IngredientDefs.RJWseXpandedCore_RawFrigina, IngrEffectMethods.RawFriginaEffect },
                { IngredientDefs.SexperienceCum, IngrEffectMethods.SexperienceCumEffect }
            };
        }
        public void ApplyIngredientEffect(Pawn pawn, ThingDef ingredient, int ingestedcount)
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
        public static void HediffGiver(Pawn pawn, int ingestedcount, HediffDef effectHediff, float hediffFactor)
        {
            float severity = ((1f / pawn.BodySize) * ingestedcount * hediffFactor);
            HealthUtility.AdjustSeverity(pawn, effectHediff, severity);
        }
        public static void ThoughtGiver(Pawn pawn, int ingestedcount, ThoughtDef effectThought, float durationDays = -1f)
        {
            if (pawn?.needs?.mood != null)
            {
                Thought_Memory existingThought = pawn.needs.mood.thoughts.memories.GetFirstMemoryOfDef(effectThought);

                if (existingThought != null)
                {
                    int newStage = Math.Max(0, Math.Min(effectThought.stages.Count - 1, existingThought.CurStageIndex + ingestedcount));
                    existingThought.SetForcedStage(newStage);

                    if (durationDays > 0)
                    {
                        existingThought.moodPowerFactor = 1f;
                        existingThought.durationTicksOverride = (int)(durationDays * GenDate.TicksPerDay);
                    }
                }
                else
                {
                    Thought_Memory newThought = (Thought_Memory)ThoughtMaker.MakeThought(effectThought);
                    int stage = Math.Max(0, Math.Min(effectThought.stages.Count - 1, ingestedcount));
                    newThought.SetForcedStage(stage);

                    if (durationDays > 0)
                    {
                        newThought.moodPowerFactor = 1f;
                        newThought.durationTicksOverride = (int)(durationDays * GenDate.TicksPerDay);
                    }

                    pawn.needs.mood.thoughts.memories.TryGainMemory(newThought);
                }
            }
        }
    }
    public class IngestionOutcomeDoer_RestoreFertilin : IngestionOutcomeDoer
    {
        public HediffDef hediffDef;
        public float severity;

        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int ingestedCount)
        {
            Hediff fertilinLost = pawn.health.hediffSet.GetFirstHediffOfDef(this.hediffDef);
            if (fertilinLost != null)
            {
                fertilinLost.Severity = (fertilinLost.Severity -= this.severity);
            }
        }
    }
}