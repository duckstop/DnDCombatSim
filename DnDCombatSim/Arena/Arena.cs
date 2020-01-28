using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCombatSim.Arena
{
    public class Arena
    {
        public CombatController CombatController { get; set;}

        public List<Character.Character> Characters { get; set; }

        public void StartEncounter()
        {
            CombatController.DetermineTurnOrder(Characters);

            //TODO Pre-round checks
            CombatController.DoRoundOfCombat(Characters);
            //TODO Post-round checks
        }

    }
}
