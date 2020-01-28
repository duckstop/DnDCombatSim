using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Activation;
using DnDCombatSim.AbilityScores;
using DnDCombatSim.Character.Classes;
using DnDCombatSim.Items;
using DnDCombatSim.Items.Armor;
using DnDCombatSim.Items.Weapon;

namespace DnDCombatSim.Character
{
    public class Character
    {
        public string Name { get; set; }

        //ToDo races
        public string Race { get; set; }
        public Strength Str { get; set;}
        public Dexterity Dex { get; set;}
        public Constitution Con { get; set; }
        public Intelligence Int { get; set; }
        public Wisdom Wis { get; set; }
        public Charisma Cha { get; set; }
        public int AC { get; set; }
        public int AttackBonus { get; set; }
        public int HitPoints { get; set; }
        public AbstractClass Class { get; set; }
        public List<string> Proficiencies { get; set; }

        public AbstractWeapon EquippedWeapon { get; set;}
        public AbstractArmor EquippedArmor { get; set; }
        public bool ShieldEquipped { get; set;}
        
        public List<AbstractItem> Inventory { get; set;}
        public int[] DeathSaves { get; set;}
        public int InitiativeBonus { get; set;}
        public string Alignment { get; set;}
        public int Speed { get; set;}
        public List<string> Feats { get; set; }

        public int Team { get; set; }

        private Dictionary<string, int> Modifiers { get; set;} // modiferDict -> key: MemberName as string. Value: int modifier

        public Character(string name, string race, int str, int dex, int con, int intelligence, int wis, int cha, AbstractClass charClass, AbstractWeapon weapon, AbstractArmor armor, bool shield, int team, int level = 1)
        {
            Name = name;
            Race = race;

            Str = new Strength(str);
            Dex = new Dexterity(dex);
            Con = new Constitution(con);
            Int = new Intelligence(intelligence);
            Wis = new Wisdom(wis);
            Cha = new Charisma(cha);
            Class = new Fighter(level);

            EquippedArmor = armor;
            EquippedWeapon = weapon;
            ShieldEquipped = shield;

            CalculateHitPoints();
            CalculateAC();
            CalculateAttackBonus();

            Team = team;
        }


        public void CalculateAC()
        {
            var ac = EquippedArmor.AC;

            if (EquippedArmor.DexModifier)
            {
                ac += Dex.Modifier > EquippedArmor.DexMax ? EquippedArmor.DexMax : Dex.Modifier;
            }

            if (ShieldEquipped)
            {
                ac += 2;
            }

            AC = ac;
        }

        public void CalculateAttackBonus()
        {
            AttackBonus = Str.Modifier + Class.ProfBonus;
        }

        public void CalculateHitPoints()
        {
            if (Class.Level == 1)
            {
                //access DB?
                //TODO more than fighter
                HitPoints = 10 + Con.Modifier;
                return;
            }

            HitPoints += Class.HitDie.Roll() + Con.Modifier;
        }

    } 
    
   
}
