namespace DnDCombatSim.Items
{
    public abstract class AbstractItem
    {
        public ItemType Type { get; set;}
        public string Description { get; set; }
        public bool IsMagical { get; set;}

    }
}
