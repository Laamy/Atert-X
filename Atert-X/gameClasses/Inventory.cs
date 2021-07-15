using Atert_X.gameClasses.CClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atert_X.gameClasses
{
    public class Inventory
    {
        public InventoryItem getItemStackByHotbarID(int slotID) => new InventoryItem((0x20 - 8 + (slotID * 8)).ToString("X"));
        public void addItem(CInventoryItem item, int itemSlot)
        {
            var slotItem = getItemStackByHotbarID(itemSlot);
            slotItem.maxStackSize = item.maxStackSize;
            slotItem.currentStackSize = item.currentStackSize;
            slotItem.itemID = item.itemID;
        }
        public ItemRegistry getRegistry() => new ItemRegistry();
    }
}
