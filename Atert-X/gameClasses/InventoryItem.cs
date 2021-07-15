namespace Atert_X.gameClasses
{
    public class InventoryItem
    {
        public string slotAddr;
        public InventoryItem(string itemID)
        {
            this.slotAddr = itemID;
        }

        public bool isNull // SAFTY!
        {
            get
            {
                if (maxStackSize != 0 || currentStackSize != 0 || itemID != 0)
                    return false;
                return true;
            }
        }

        // -- : Item struct : --
        // m_CachedPtr
        // itemIcon
        // countLabel
        // debugLabel
        // moveScaleFeedback
        // moveScaleTimeFreeback
        // maxStackSize               [0x38]
        // currentStackSize           [0x3C]
        // itemID                     [0x40]
        // draggedByMouse
        // ownerWindow
        // originalSlot
        // ignoredFirstMouseDown
        // extraData
        // playScaleFeedbackSequence

        public int maxStackSize // 0
        {
            get => Form1.mem.ReadInt($"{Form1.novaItemList},{slotAddr},38");
            set => Form1.mem.WriteMemory($"{Form1.novaItemList},{slotAddr},38", "int", value.ToString());
        }

        public int currentStackSize // 4
        {
            get => Form1.mem.ReadInt($"{Form1.novaItemList},{slotAddr},3C"); 
            set => Form1.mem.WriteMemory($"{Form1.novaItemList},{slotAddr},3C", "int", value.ToString());
        }

        public int itemID // 8
        {
            get => Form1.mem.ReadInt($"{Form1.novaItemList},{slotAddr},40");
            set => Form1.mem.WriteMemory($"{Form1.novaItemList},{slotAddr},40", "int", value.ToString());
        }
    }
}
