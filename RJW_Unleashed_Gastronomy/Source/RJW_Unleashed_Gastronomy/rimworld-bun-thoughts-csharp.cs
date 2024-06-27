using RimWorld;
using Verse;

//namespace BunThoughts
//{
//    public class IngestionOutcomeDoer_BunThought : IngestionOutcomeDoer
//    {
//        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int ingestedCount)
//        {
//            if (pawn.needs.mood == null)
//                return;

//            string thoughtDefName = GetThoughtDefName(ingested.def.defName);
//            if (!string.IsNullOrEmpty(thoughtDefName))
//            {
//                ThoughtDef thoughtDef = DefDatabase<ThoughtDef>.GetNamed(thoughtDefName);
//                if (thoughtDef != null)
//                {
//                    pawn.needs.mood.thoughts.memories.TryGainMemory(thoughtDef);
//                }
//            }
//        }

//        private string GetThoughtDefName(string ingestedDefName)
//        {
//            if (ingestedDefName == "MilkyStuffedRiceBun")
//                return "AteMilkyStuffedRiceBun";
//            else if (ingestedDefName == "RiceBun")
//                return "AteRiceBun";
//            else
//                return null;
//        }
//    }
//}
namespace BunThoughts
{
    public class IngestionOutcomeDoer_BunThought : IngestionOutcomeDoer
    {
        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int ingestedCount)
        {
            if (pawn.needs.mood != null)
            {
                string thoughtDefName = GetThoughtDefName(ingested.def.defName);
                if (!string.IsNullOrEmpty(thoughtDefName))
                {
                    ThoughtDef thoughtDef = DefDatabase<ThoughtDef>.GetNamed(thoughtDefName);
                    if (thoughtDef != null)
                    {
                        pawn.needs.mood.thoughts.memories.TryGainMemory(thoughtDef);
                    }
                }
            }
        }

        static string GetThoughtDefName(string ingestedDefName)
        {
            if (ingestedDefName == "MilkyStuffedRiceBun")
                return "AteMilkyStuffedRiceBun";
            else if (ingestedDefName == "RiceBun")
                return "AteRiceBun";
            else
                return null;
        }
    }
}