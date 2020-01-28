using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCombatSim.Items.Weapon
{
    public class Longsword : AbstractWeapon
    {
        public Longsword()
        {
            Type = ItemType.WEAPON;
            Description = "A longsword";
            DamageDie = new D8();
            DamageType = DamageType.SLASHING;
            NrOfDamageDice = 1;
            Proficiency = GearProficiency.MARTIAL;
        }

        public override List<string> Properties { get; set; }
    }
}
