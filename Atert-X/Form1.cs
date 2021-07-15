using Atert_X.gameClasses;
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
            var item = Inventory.getItemStackByHotbarID((int)slotID.Value); // Get item
            item.currentStackSize = (int)itemAmount.Value;
            item.itemID = ItemRegistry.getIDFromName(itemName.Text);
            Text = item.slotAddr;
        }
    }
}
