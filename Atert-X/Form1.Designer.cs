
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
            this.SuspendLayout();
            // 
            // godmodeBox
            // 
            this.godmodeBox.AutoSize = true;
            this.godmodeBox.Location = new System.Drawing.Point(12, 12);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 233);
            this.Controls.Add(this.godmodeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Atert X";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox godmodeBox;
        private System.Windows.Forms.Timer gameTicks;
    }
}

