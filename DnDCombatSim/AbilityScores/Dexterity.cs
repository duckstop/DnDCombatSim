using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCombatSim.AbilityScores
{
    public class Dexterity : AbstractAbilityScore
    {
        public override Dictionary<string, int> Skills { get; set; }

        public Dexterity(int score) : base(score)
        {
            SetAbilityModifier(this);
        }
    }
}
