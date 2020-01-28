using System.Collections.Generic;
using DnDCombatSim.AbilityScores;

namespace DnDCombatSim.Character.Classes
{
    public abstract class AbstractClass
    {
        protected AbstractClass(int level)
        {
            Level = level;
        }

        public  int Level {get; set;}
        public Dice HitDie { get; set; }
        public List<string> ClassFeatures { get; set;}
        public int Attacks {get; set;}
        public int ProfBonus {get; set;}
        public Dictionary<int, int> SpellSlots { get; set;}
        public List<string> Spells { get; set;}

        public void SetProfBonus()
        {
            //access DB?
            if (Level > 1)
            {
                ProfBonus = 2;
            }

            if (Level > 4)
            {
                ProfBonus = 3;
            }

            if (Level > 8)
            {
                ProfBonus = 4;
            }

            if (Level > 12)
            {
                ProfBonus = 5;
            }

            if (Level > 16)
            {
                ProfBonus = 6;
            }
        }
    }
}
