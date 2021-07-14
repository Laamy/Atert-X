using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atert_X.gameClasses
{
    public class Inventory
    {
        public static ItemStack getItemStackByHotbarID(int slotID) => new ItemStack((0x20 - 8 + (slotID * 8)).ToString("X"));
    }
}
