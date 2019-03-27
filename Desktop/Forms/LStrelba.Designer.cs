namespace Bul0056.Forms
{
    partial class LStrelba
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zacatekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prostorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakaznikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamestnanecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zbranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strelbaDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strelbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strelbaDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strelbaDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strelbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strelbaDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.zacatekDataGridViewTextBoxColumn,
            this.konecDataGridViewTextBoxColumn,
            this.prostorDataGridViewTextBoxColumn,
            this.zakaznikDataGridViewTextBoxColumn,
            this.zamestnanecDataGridViewTextBoxColumn,
            this.zbranDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.strelbaDTOBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(25, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nová střelba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Odstranit záznam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // zacatekDataGridViewTextBoxColumn
            // 
            this.zacatekDataGridViewTextBoxColumn.DataPropertyName = "Zacatek";
            this.zacatekDataGridViewTextBoxColumn.HeaderText = "Zacatek";
            this.zacatekDataGridViewTextBoxColumn.Name = "zacatekDataGridViewTextBoxColumn";
            // 
            // konecDataGridViewTextBoxColumn
            // 
            this.konecDataGridViewTextBoxColumn.DataPropertyName = "Konec";
            this.konecDataGridViewTextBoxColumn.HeaderText = "Konec";
            this.konecDataGridViewTextBoxColumn.Name = "konecDataGridViewTextBoxColumn";
            // 
            // prostorDataGridViewTextBoxColumn
            // 
            this.prostorDataGridViewTextBoxColumn.DataPropertyName = "Prostor";
            this.prostorDataGridViewTextBoxColumn.HeaderText = "Prostor";
            this.prostorDataGridViewTextBoxColumn.Name = "prostorDataGridViewTextBoxColumn";
            // 
            // zakaznikDataGridViewTextBoxColumn
            // 
            this.zakaznikDataGridViewTextBoxColumn.DataPropertyName = "Zakaznik";
            this.zakaznikDataGridViewTextBoxColumn.HeaderText = "Zakaznik";
            this.zakaznikDataGridViewTextBoxColumn.Name = "zakaznikDataGridViewTextBoxColumn";
            // 
            // zamestnanecDataGridViewTextBoxColumn
            // 
            this.zamestnanecDataGridViewTextBoxColumn.DataPropertyName = "Zamestnanec";
            this.zamestnanecDataGridViewTextBoxColumn.HeaderText = "Zamestnanec";
            this.zamestnanecDataGridViewTextBoxColumn.Name = "zamestnanecDataGridViewTextBoxColumn";
            // 
            // zbranDataGridViewTextBoxColumn
            // 
            this.zbranDataGridViewTextBoxColumn.DataPropertyName = "Zbran";
            this.zbranDataGridViewTextBoxColumn.HeaderText = "Zbran";
            this.zbranDataGridViewTextBoxColumn.Name = "zbranDataGridViewTextBoxColumn";
            // 
            // strelbaDTOBindingSource
            // 
            this.strelbaDTOBindingSource.DataSource = typeof(Bul0056.Aggregates.StrelbaDTO);
            // 
            // strelbaBindingSource
            // 
            this.strelbaBindingSource.DataSource = typeof(Bul0056.Aggregates.Strelba);
            // 
            // strelbaDTOBindingSource1
            // 
            this.strelbaDTOBindingSource1.DataSource = typeof(Bul0056.Aggregates.StrelbaDTO);
            // 
            // LStrelba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LStrelba";
            this.Text = "LStrelba";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strelbaDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strelbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strelbaDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource strelbaBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource strelbaDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zacatekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prostorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakaznikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zamestnanecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zbranDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource strelbaDTOBindingSource1;
    }
}