using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atert_X.gameClasses
{
    public class Inventory
    {
        public static UniqueItem getItemStackByHotbarID(int slotID) => new UniqueItem((0x20 - 8 + (slotID * 8)).ToString("X"));
    }
}
