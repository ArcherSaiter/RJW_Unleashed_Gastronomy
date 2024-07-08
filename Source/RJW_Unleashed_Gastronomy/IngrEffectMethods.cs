using System.Collections.Generic;
using System;
using System.Linq;
using RimWorld;
using Verse;

namespace RJW_Unleashed_Gastronomy
{
    public class IngrEffectMethods
    {
        public static void RawSleepBerriesEffect(Pawn pawn, int ingestedcount)
        {
            if (pawn.needs?.rest != null && ingestedcount > 0)
            {
                pawn.needs.rest.CurLevel = 0f;
                if (EffectDefs.AllHediffs != null && EffectDefs.Test_hediff != null)
                {
                    HediffDef effectHediff = EffectDefs.Test_hediff;
                    float hediffFactor = 0.35f;
                    RJW_Unleashed_GastronomyIngestionOutcomeDoer.HediffGiver(pawn, ingestedcount, effectHediff, hediffFactor);
                }
                else
                {
                    Log.Warning($"Unable to add hediff Test_hediff for {pawn.Name}.");
                }
            }
            else
            {
                Log.Warning($"Unable to execute effect for {pawn.Name}.");
            }
        }
        public static void RawCocktusEffect(Pawn pawn, int ingestedcount)
        {
            if (pawn != null && ingestedcount > 0)
            {
                if (EffectDefs.AllHediffs != null && EffectDefs.CocktusHediff != null)
                {
                    HediffDef effectHediff = EffectDefs.CocktusHediff;
                    float hediffFactor = 0.35f;
                    RJW_Unleashed_GastronomyIngestionOutcomeDoer.HediffGiver(pawn, ingestedcount, effectHediff, hediffFactor);
                }
                else
                {
                    Log.Warning($"Unable to add hediff CocktusHediff for {pawn.Name}.");
                }
            }
            else
            {
                Log.Warning($"Unable to execute effect for {pawn.Name}.");
            }
        }
        public static void RawUdderfruitEffect(Pawn pawn, int ingestedcount)
        {
            if (pawn != null && ingestedcount > 0)
            {
                if (EffectDefs.AllHediffs != null && EffectDefs.UdderfruitHediff != null)
                {
                    HediffDef effectHediff = EffectDefs.UdderfruitHediff;
                    float hediffFactor = 0.35f;
                    RJW_Unleashed_GastronomyIngestionOutcomeDoer.HediffGiver(pawn, ingestedcount, effectHediff, hediffFactor);
                }
                else
                {
                    Log.Warning($"Unable to add hediff UdderfruitHediff for {pawn.Name}.");
                }
            }
            else
            {
                Log.Warning($"Unable to execute effect for {pawn.Name}.");
            }
        }
        public static void RawToxicleEffect(Pawn pawn, int ingestedcount)
        {
            if (pawn != null && ingestedcount > 0)
            {
                if (EffectDefs.AllHediffs != null && EffectDefs.ToxicBuildupHediff != null)
                {
                    HediffDef effectHediff = EffectDefs.ToxicBuildupHediff;
                    float hediffFactor = -0.15f;
                    RJW_Unleashed_GastronomyIngestionOutcomeDoer.HediffGiver(pawn, ingestedcount, effectHediff, hediffFactor);
                }
                else
                {
                    Log.Warning($"Unable to modify hediff ToxicBuildupHediff for {pawn.Name}.");
                }
            }
            else
            {
                Log.Warning($"Unable to execute effect for {pawn.Name}.");
            }
        }
        public static void RawFriginaEffect(Pawn pawn, int ingestedcount)
        {
            if (pawn != null && ingestedcount > 0)
            {
                if (EffectDefs.AllHediffs != null && EffectDefs.FriginaHediff != null)
                {
                    HediffDef effectHediff = EffectDefs.FriginaHediff;
                    float hediffFactor = 0.35f;
                    RJW_Unleashed_GastronomyIngestionOutcomeDoer.HediffGiver(pawn, ingestedcount, effectHediff, hediffFactor);
                }
                else
                {
                    Log.Warning($"Unable to add hediff FriginaHediff for {pawn.Name}.");
                }
            }
            else
            {
                Log.Warning($"Unable to execute effect for {pawn.Name}.");
            }
        }
        public static void SexperienceCumEffect(Pawn pawn, int ingestedcount)
        {
            if (pawn != null && ingestedcount > 0)
            {
                Need CumNeed = pawn.needs.TryGetNeed(DefDatabase<NeedDef>.GetNamed("Chemical_Cum", false));
                if (CumNeed != null)
                {
                    CumNeed.CurLevel = Math.Max(CumNeed.CurLevel - 0.1f, 0f); // Ensure the level doesn't go below 0
                }
                if (EffectDefs.AllHediffs != null && EffectDefs.CumToleranceHediff != null)
                {
                    HediffDef effectHediff = EffectDefs.CumToleranceHediff;
                    float hediffFactor = 0.15f;
                    RJW_Unleashed_GastronomyIngestionOutcomeDoer.HediffGiver(pawn, ingestedcount, effectHediff, hediffFactor);

                    HediffDef _effectHediff = EffectDefs.CumAddictionHediff;
                    float _hediffFactor = 0.15f;
                    RJW_Unleashed_GastronomyIngestionOutcomeDoer.HediffGiver(pawn, ingestedcount, _effectHediff, _hediffFactor); 
                    
                    ThoughtDef effectThought = EffectDefs.AteCumThought;
                    float durationDays = 0.5f;
                    RJW_Unleashed_GastronomyIngestionOutcomeDoer.ThoughtGiver(pawn, ingestedcount, effectThought, durationDays);
                }
                else
                {
                    Log.Warning($"Unable to add hediff CumToleranceHediff for {pawn.Name}.");
                }
            }
            else
            {
                Log.Warning($"Unable to execute effect for {pawn.Name}.");
            }
        }
    }
}