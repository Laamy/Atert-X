
namespace Atert_X
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.godmodeBox = new System.Windows.Forms.CheckBox();
            this.gameTicks = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.itemAmount = new System.Windows.Forms.NumericUpDown();
            this.itemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.slotID = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotID)).BeginInit();
            this.SuspendLayout();
            // 
            // godmodeBox
            // 
            this.godmodeBox.AutoSize = true;
            this.godmodeBox.Location = new System.Drawing.Point(39, 12);
            this.godmodeBox.Name = "godmodeBox";
            this.godmodeBox.Size = new System.Drawing.Size(72, 17);
            this.godmodeBox.TabIndex = 0;
            this.godmodeBox.Text = "Godmode";
            this.godmodeBox.UseVisualStyleBackColor = true;
            this.godmodeBox.CheckedChanged += new System.EventHandler(this.godmodeBox_CheckedChanged);
            // 
            // gameTicks
            // 
            this.gameTicks.Enabled = true;
            this.gameTicks.Interval = 50;
            this.gameTicks.Tick += new System.EventHandler(this.gameTicks_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.itemAmount);
            this.groupBox1.Controls.Add(this.itemName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.slotID);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Editor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // itemAmount
            // 
            this.itemAmount.Location = new System.Drawing.Point(6, 60);
            this.itemAmount.Maximum = new decimal(new int[] {
            1998,
            0,
            0,
            0});
            this.itemAmount.Name = "itemAmount";
            this.itemAmount.Size = new System.Drawing.Size(76, 20);
            this.itemAmount.TabIndex = 5;
            this.itemAmount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // itemName
            // 
            this.itemName.Location = new System.Drawing.Point(6, 38);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(75, 20);
            this.itemName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ItemName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SlotID";
            // 
            // slotID
            // 
            this.slotID.Location = new System.Drawing.Point(6, 16);
            this.slotID.Name = "slotID";
            this.slotID.Size = new System.Drawing.Size(76, 20);
            this.slotID.TabIndex = 0;
            this.slotID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 158);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.godmodeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Atert X";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox godmodeBox;
        private System.Windows.Forms.Timer gameTicks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown slotID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown itemAmount;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

