using System.Collections.Generic;

namespace DnDCombatSim.Items.Weapon
{
    public abstract class AbstractWeapon : AbstractItem
    {
        public Dice DamageDie { get; set; }

        public DamageType DamageType { get; set; }

        public int NrOfDamageDice { get; set; }

        public GearProficiency Proficiency { get; set;}

        public abstract List<string> Properties { get; set; }

        public int MagicalModifier { get; set;}

        public Dice MagicEnchantmentDamage { get; set; }
        public int NrOfMagicEnchantmentDamageDie { get; set;}
        public DamageType MagicEnchantmentDamageType { get; set; }

    }
}
