using DnDCombatSim.Items;
using DnDCombatSim.Items.Weapon;

namespace DnDCombatSim.Actions
{
    public class MeleeAttackAction : AbstractAction
    {

        public MeleeAttackAction()
        {
            ActionType = ActionTypes.ACTION;
        }
        public override void DoAction(Character.Character attacker, Character.Character defender)
        {
            var d20 = new D20();
            var attackRoll = d20.Roll();

            if (attackRoll == 20)
            {
                var damage = RollDamage(attacker.EquippedWeapon, 2);
                defender.HitPoints -= damage + attacker.Str.Modifier;
            }
            else
            {
                attackRoll += attacker.Str.Modifier + attacker.Class.ProfBonus;

                if (attackRoll >= defender.AC)
                {
                    var damage = RollDamage(attacker.EquippedWeapon, 1);
                    defender.HitPoints -= damage + attacker.Str.Modifier;
                }
            }
        }

        public  int RollDamage(AbstractWeapon weapon, int criticalMultiplier)
        {
            var rolledDamage = 0;

            for (int i = 0; i < criticalMultiplier; i++)
            {
                rolledDamage += weapon.DamageDie.Roll();
            }
            return rolledDamage;
        }

    }
}
