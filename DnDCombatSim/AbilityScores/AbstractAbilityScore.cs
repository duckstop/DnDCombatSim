using System.Collections.Generic;

namespace DnDCombatSim.AbilityScores
{
    public abstract class AbstractAbilityScore
    {

        public  int Score { get; set;}
        public  int Modifier { get; set;}
        public  bool SavingThrowProficiency { get; set;}
        //key: skill name. value: proficient
        public abstract Dictionary<string, int> Skills { get; set;}

        protected AbstractAbilityScore(int score)
        {
            Score = score;
        }

        public int AbilityCheck(Character.Character character)
        {
            var d20 = new D20();
            return d20.Roll() + Modifier;
        }

        public int SavingThrow(Character.Character character)
        {
            var d20 = new D20();
            var roll = d20.Roll() + Modifier;
            if (SavingThrowProficiency)
            {
                roll += character.Class.ProfBonus;
            }

            return roll;
        }

        public void SetAbilityModifier(AbstractAbilityScore abScore)
        {
            Dictionary<Range<int>, int> abilityScoreRanges = new Dictionary<Range<int>, int>
            {
                {new Range<int>(1, 1), -5},
                {new Range<int>(2, 3), -4},
                {new Range<int>(4, 5), -3},
                {new Range<int>(6, 7), -2},
                {new Range<int>(8, 9), -1},
                {new Range<int>(10, 11), 0},
                {new Range<int>(12, 13), 1},
                {new Range<int>(14, 15), 2},
                {new Range<int>(16, 17), 3},
                {new Range<int>(18, 19), 4},
                {new Range<int>(20, 21), 5},
                {new Range<int>(22, 23), 6},
                {new Range<int>(24, 25), 7},
                {new Range<int>(26, 27), 8},
                {new Range<int>(28, 29), 9},
                {new Range<int>(30, 30), 10}
            };

            foreach (var abRange in abilityScoreRanges)
            {
                if (abRange.Key.ContainsValue(abScore.Score))
                {
                    abScore.Modifier = abRange.Value;
                    break;
                }
            }
        }
    }
}
