namespace Bul0056.Forms
{
    partial class DZamestnanec
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJm = new System.Windows.Forms.TextBox();
            this.txtPr = new System.Windows.Forms.TextBox();
            this.txtEm = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Day = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zpět";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Uložit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Příjmení:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum narození: ";
            // 
            // txtJm
            // 
            this.txtJm.Location = new System.Drawing.Point(120, 20);
            this.txtJm.Name = "txtJm";
            this.txtJm.Size = new System.Drawing.Size(125, 20);
            this.txtJm.TabIndex = 6;
            // 
            // txtPr
            // 
            this.txtPr.Location = new System.Drawing.Point(120, 64);
            this.txtPr.Name = "txtPr";
            this.txtPr.Size = new System.Drawing.Size(125, 20);
            this.txtPr.TabIndex = 7;
            // 
            // txtEm
            // 
            this.txtEm.Location = new System.Drawing.Point(120, 109);
            this.txtEm.Name = "txtEm";
            this.txtEm.Size = new System.Drawing.Size(125, 20);
            this.txtEm.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Year);
            this.panel1.Controls.Add(this.Month);
            this.panel1.Controls.Add(this.Day);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtJm);
            this.panel1.Controls.Add(this.txtPr);
            this.panel1.Controls.Add(this.txtEm);
            this.panel1.Location = new System.Drawing.Point(250, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 232);
            this.panel1.TabIndex = 10;
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(175, 146);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(70, 20);
            this.Day.TabIndex = 10;
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(175, 172);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(70, 20);
            this.Month.TabIndex = 11;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(175, 198);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(70, 20);
            this.Year.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Den:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Měsíc: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rok: ";
            // 
            // DZamestnanec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DZamestnanec";
            this.Text = "DZamestnanec";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJm;
        private System.Windows.Forms.TextBox txtPr;
        private System.Windows.Forms.TextBox txtEm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.TextBox Day;
    }
}