using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCombatSim.AbilityScores
{
    public class Wisdom : AbstractAbilityScore
    {
        public override Dictionary<string, int> Skills { get; set; }

        public Wisdom(int score) : base(score)
        {
            SetAbilityModifier(this);
        }
    }
}
