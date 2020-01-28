using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCombatSim.Character.Classes
{
    public class Fighter : AbstractClass
    {
        public Fighter(int level) : base(level)
        {
            Level = level;
            SetProfBonus();
            //get from DB
            Attacks = 1;
            HitDie = new D10();
        }

        //TODO Rest of the class
    }
}
