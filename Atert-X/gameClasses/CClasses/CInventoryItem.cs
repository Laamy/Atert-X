using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atert_X.gameClasses.CClasses
{
    public class CInventoryItem
    {
        public CInventoryItem(InventoryItem item)
        {
            maxStackSize = item.maxStackSize;
            currentStackSize = item.currentStackSize;
            itemID = item.itemID;
        }
        public CInventoryItem()
        {
            maxStackSize = 0;
            currentStackSize = 0;
            itemID = 0;
        }
        public CInventoryItem(string itemType)
        {
            maxStackSize = 0;
            currentStackSize = 0;
            itemID = NovaIsland.inventory.getRegistry().getIDFromName(itemType);
        }
        public int maxStackSize;
        public int currentStackSize;
        public int itemID;
    }
}
