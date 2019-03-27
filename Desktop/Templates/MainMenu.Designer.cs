namespace Bul0056.Templates
{
    partial class MainMenu
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
            System.Windows.Forms.MenuStrip menuStrip1;
            this.zbraněToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zákazníciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.střelbyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.střelnéProstoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaměstnanciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zbraněToolStripMenuItem,
            this.zákazníciToolStripMenuItem,
            this.rezervaceToolStripMenuItem,
            this.střelbyToolStripMenuItem,
            this.střelnéProstoryToolStripMenuItem,
            this.zaměstnanciToolStripMenuItem});
            menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(790, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // zbraněToolStripMenuItem
            // 
            this.zbraněToolStripMenuItem.Name = "zbraněToolStripMenuItem";
            this.zbraněToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.zbraněToolStripMenuItem.Text = "Zbraně";
            this.zbraněToolStripMenuItem.Click += new System.EventHandler(this.zbraněToolStripMenuItem_Click);
            // 
            // zákazníciToolStripMenuItem
            // 
            this.zákazníciToolStripMenuItem.Name = "zákazníciToolStripMenuItem";
            this.zákazníciToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.zákazníciToolStripMenuItem.Text = "Zákazníci";
            this.zákazníciToolStripMenuItem.Click += new System.EventHandler(this.zákazníciToolStripMenuItem_Click);
            // 
            // rezervaceToolStripMenuItem
            // 
            this.rezervaceToolStripMenuItem.Name = "rezervaceToolStripMenuItem";
            this.rezervaceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.rezervaceToolStripMenuItem.Text = "Rezervace";
            // 
            // střelbyToolStripMenuItem
            // 
            this.střelbyToolStripMenuItem.Name = "střelbyToolStripMenuItem";
            this.střelbyToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.střelbyToolStripMenuItem.Text = "Střelby";
            this.střelbyToolStripMenuItem.Click += new System.EventHandler(this.střelbyToolStripMenuItem_Click);
            // 
            // střelnéProstoryToolStripMenuItem
            // 
            this.střelnéProstoryToolStripMenuItem.Name = "střelnéProstoryToolStripMenuItem";
            this.střelnéProstoryToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.střelnéProstoryToolStripMenuItem.Text = "Střelné prostory";
            // 
            // zaměstnanciToolStripMenuItem
            // 
            this.zaměstnanciToolStripMenuItem.Name = "zaměstnanciToolStripMenuItem";
            this.zaměstnanciToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.zaměstnanciToolStripMenuItem.Text = "Zaměstnanci";
            this.zaměstnanciToolStripMenuItem.Click += new System.EventHandler(this.zaměstnanciToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 556);
            this.Controls.Add(menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem zbraněToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zákazníciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem střelbyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem střelnéProstoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaměstnanciToolStripMenuItem;
    }
}