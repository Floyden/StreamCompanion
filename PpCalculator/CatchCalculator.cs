using System.Collections.Generic;
using osu.Game.Rulesets;
using osu.Game.Rulesets.Catch;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Scoring;

namespace PpCalculator
{
    public class CatchCalculator : PpCalculator
    {
        public override Ruleset Ruleset { get; } = new CatchRuleset();

        protected override int GetMaxCombo(IReadOnlyList<HitObject> hitObjects) => 0;

        protected override Dictionary<HitResult, int> GenerateHitResults(double accuracy, IReadOnlyList<HitObject> hitObjects, int countMiss, int? countMeh, int? countGood)
        {
            var totalHits = hitObjects.Count;

            // Only total number of hits is considered currently, so specifics don't matter
            return new Dictionary<HitResult, int>
            {
                { HitResult.Perfect, totalHits },
                { HitResult.Miss, 0 }
            };
        }

        protected override double GetAccuracy(Dictionary<HitResult, int> statistics) => 0;
    }
}