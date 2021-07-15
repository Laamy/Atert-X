namespace Atert_X.gameClasses
{
    public class UniqueItem
    {
        public string itemAddr;
        public UniqueItem(string itemID)
        {
            this.itemAddr = itemID;
        }

        public int itemstackID
        {
            get => Form1.mem.ReadInt($"{Form1.novaItemList},{itemAddr},28");
            set => Form1.mem.WriteMemory($"{Form1.novaItemList},{itemAddr},28", "int", value.ToString());
        }

        public int maxItemAmount
        {
            get => Form1.mem.ReadInt($"{Form1.novaItemList},{itemAddr},38");
            set => Form1.mem.WriteMemory($"{Form1.novaItemList},{itemAddr},38", "int", value.ToString());
        }

        public int itemAmount
        {
            get => Form1.mem.ReadInt($"{Form1.novaItemList},{itemAddr},3C");
            set => Form1.mem.WriteMemory($"{Form1.novaItemList},{itemAddr},3C", "int", value.ToString());
        }

        public int itemID
        {
            get => Form1.mem.ReadInt($"{Form1.novaItemList},{itemAddr},40");
            set => Form1.mem.WriteMemory($"{Form1.novaItemList},{itemAddr},40", "int", value.ToString());
        }
    }
}
