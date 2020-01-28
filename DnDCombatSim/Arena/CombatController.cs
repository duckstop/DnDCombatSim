using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDCombatSim.Actions;

namespace DnDCombatSim.Arena
{
    public class CombatController
    {
        public List<Character.Character> TurnOrder { get; set;}

        public int RoundCount { get; set; }

        public Character.Character CurrentCharacter { get; set; }

        public void DetermineTurnOrder(List<Character.Character> chars)
        {
            Dictionary<Character.Character, int> initiativeRolls = new Dictionary<Character.Character, int>();

            var d20 = new D20();

            foreach (var character in chars)
            {
                initiativeRolls.Add(character, d20.Roll() + character.InitiativeBonus);
            }

            var sortedRolls = initiativeRolls.ToList();

            sortedRolls.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            for (int i = 0; i <= sortedRolls.Count; i++)
            {
                TurnOrder.Insert(i, sortedRolls[i].Key);
            }
        }

        public void DoRoundOfCombat(List<Character.Character> characters)
        {
            RoundCount++;
            foreach (var character in TurnOrder)
            {
                CurrentCharacter = character;

                //TODO DetermineAction()
                AbstractAction chosenAction = new MeleeAttackAction();
                //ToDO DetermineTarget()
                var target = characters.FirstOrDefault(x => x.Team != CurrentCharacter.Team); //simple for now.

                chosenAction.DoAction(CurrentCharacter, target);
            }

        }
    }
}
