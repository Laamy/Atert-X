using System;
using System.Windows.Forms;

namespace Atert_X
{
    public partial class Form1 : Form
    {
        public Mem mem = new Mem();

        public Form1()
        {
            InitializeComponent();

            mem.OpenProcess("Nova Islands.exe"); // Open up the game process
        }

        public string health = "GameAssembly.dll+01BCB850,B8,0,2A8,50,25C";

        private void gameTicks_Tick(object sender, EventArgs e)
        {
            if (godmodeBox.Checked)
                mem.WriteMemory(health, "float", "200");
        }

        private void godmodeBox_CheckedChanged(object sender, EventArgs e) { }
    }
}
