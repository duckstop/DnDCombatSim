namespace DnDCombatSim.Items.Armor
{
    public abstract class AbstractArmor : AbstractItem
    {
        public int AC { get; set; }
        public bool DexModifier { get; set; }
        public int DexMax { get; set;}
        public GearProficiency Proficiency { get; set; }
    }
}
