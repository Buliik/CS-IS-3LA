﻿namespace Bul0056.Forms
{
    partial class LZbran
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
            this.zbranBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.zbranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zbranBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokvyrobyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zbranBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zbranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zbranBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // zbranBindingSource1
            // 
            this.zbranBindingSource1.DataSource = typeof(Bul0056.Aggregates.Zbran);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Přidat zbraň";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zbranBindingSource
            // 
            this.zbranBindingSource.DataSource = typeof(Bul0056.Aggregates.Zbran);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(537, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Odstranit zbraň";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazevDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn,
            this.razeDataGridViewTextBoxColumn,
            this.rokvyrobyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zbranBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(130, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // zbranBindingSource2
            // 
            this.zbranBindingSource2.DataSource = typeof(Bul0056.Aggregates.Zbran);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nazevDataGridViewTextBoxColumn
            // 
            this.nazevDataGridViewTextBoxColumn.DataPropertyName = "Nazev";
            this.nazevDataGridViewTextBoxColumn.HeaderText = "Nazev";
            this.nazevDataGridViewTextBoxColumn.Name = "nazevDataGridViewTextBoxColumn";
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            // 
            // razeDataGridViewTextBoxColumn
            // 
            this.razeDataGridViewTextBoxColumn.DataPropertyName = "Raze";
            this.razeDataGridViewTextBoxColumn.HeaderText = "Raze";
            this.razeDataGridViewTextBoxColumn.Name = "razeDataGridViewTextBoxColumn";
            // 
            // rokvyrobyDataGridViewTextBoxColumn
            // 
            this.rokvyrobyDataGridViewTextBoxColumn.DataPropertyName = "Rok_vyroby";
            this.rokvyrobyDataGridViewTextBoxColumn.HeaderText = "Rok_vyroby";
            this.rokvyrobyDataGridViewTextBoxColumn.Name = "rokvyrobyDataGridViewTextBoxColumn";
            // 
            // LZbran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "LZbran";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.zbranBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zbranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zbranBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource zbranBindingSource1;
        private System.Windows.Forms.BindingSource zbranBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokvyrobyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zbranBindingSource2;
    }
}