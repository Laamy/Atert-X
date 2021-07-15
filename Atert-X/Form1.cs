using Atert_X.gameClasses;
using Atert_X.gameClasses.CClasses;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Atert_X
{
    public partial class Form1 : Form
    {
        public static Mem mem = new Mem();

        public Form1()
        {
            InitializeComponent();

            mem.OpenProcess("Nova Islands.exe"); // Open up the game process

            new Thread(() => {
                Thread.CurrentThread.IsBackground = true;
                while (true)
                {
                    if (godmodeBox.Checked)
                        mem.WriteMemory(health, "float", "200");
                }
            }).Start();
        }

        public string health = "GameAssembly.dll+01BCB850,B8,0,2A8,50,25C";
        public static string novaItemList = "GameAssembly.dll+01BB0A78,B8,0,40,5F0,10";

        private void gameTicks_Tick(object sender, EventArgs e) { }

        private void godmodeBox_CheckedChanged(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inv = NovaIsland.inventory;
            int slot = (int)slotID.Value;
            if (inv.getItemStackByHotbarID(slot).isNull == false)
            {
                var item = new CInventoryItem(itemName.Text); // Create new Client Item with presearched ItemRegistry ID
                item.currentStackSize = (int)itemAmount.Value; // How many items we want

                inv.addItem(item, slot); // Add item to our inventory
            }
        }
    }
}
