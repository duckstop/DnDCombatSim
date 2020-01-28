using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCombatSim.AbilityScores
{
    public class Constitution : AbstractAbilityScore
    {
        public override Dictionary<string, int> Skills { get; set; }

        public Constitution(int score) : base(score)
        {
            SetAbilityModifier(this);
        }
    }
}
