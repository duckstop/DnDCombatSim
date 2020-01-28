using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCombatSim.Items.Armor
{
    public class ScaleMail : AbstractArmor
    {
        public ScaleMail()
        {
            Type = ItemType.ARMOR;
            AC = 14;
            Description = "A coat of overlapping metal scales";
            DexMax = 2;
            DexModifier = true;
            IsMagical = false;
            Proficiency = GearProficiency.MEDIUM_ARMOR;
        }
    }
}
