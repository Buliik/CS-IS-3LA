namespace Bul0056.Forms
{
    partial class LZamestnanec
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijmeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumnarozeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamestnanecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.jmenoDataGridViewTextBoxColumn,
            this.prijmeniDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.datumnarozeniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zamestnanecBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(150, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // jmenoDataGridViewTextBoxColumn
            // 
            this.jmenoDataGridViewTextBoxColumn.DataPropertyName = "Jmeno";
            this.jmenoDataGridViewTextBoxColumn.HeaderText = "Jmeno";
            this.jmenoDataGridViewTextBoxColumn.Name = "jmenoDataGridViewTextBoxColumn";
            // 
            // prijmeniDataGridViewTextBoxColumn
            // 
            this.prijmeniDataGridViewTextBoxColumn.DataPropertyName = "Prijmeni";
            this.prijmeniDataGridViewTextBoxColumn.HeaderText = "Prijmeni";
            this.prijmeniDataGridViewTextBoxColumn.Name = "prijmeniDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // datumnarozeniDataGridViewTextBoxColumn
            // 
            this.datumnarozeniDataGridViewTextBoxColumn.DataPropertyName = "Datum_narozeni";
            this.datumnarozeniDataGridViewTextBoxColumn.HeaderText = "Datum_narozeni";
            this.datumnarozeniDataGridViewTextBoxColumn.Name = "datumnarozeniDataGridViewTextBoxColumn";
            // 
            // zamestnanecBindingSource
            // 
            this.zamestnanecBindingSource.DataSource = typeof(Bul0056.Aggregates.Zamestnanec);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Přidání zaměstnance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Odebrání zaměstnance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exportovat do XML";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LZamestnanec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LZamestnanec";
            this.Text = "LZamestnanec";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamestnanecBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijmeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumnarozeniDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zamestnanecBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}