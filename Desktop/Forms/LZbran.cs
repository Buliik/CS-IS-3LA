using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bul0056.Aggregates;
using System.Collections.ObjectModel;

namespace Bul0056.Forms
{
    public partial class LZbran : Form
    {
        public LZbran()
        {
            InitializeComponent();
            GetData();
        }

        protected void GetData()
        {
            Collection<Zbran> zbrane = Zbran.SelectAll();
            BindingList<Zbran> bindingList = new BindingList<Zbran>(zbrane);
            dataGridView1.DataSource = bindingList;
        }

        private Zbran GetSelectedZbr()
        {
            // The "SelectionMode" property of the data grid view must be set to "FullRowSelect".
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Zbran zbran = dataGridView1.SelectedRows[0].DataBoundItem as Zbran;
                return zbran;
            }
            else
            {
                return null;
            }
        }

        protected void EditRecord()
        {
            Zbran selectedZbr = GetSelectedZbr();
            if (selectedZbr != null)
            {
                DZbran form = new DZbran();
                if (form.OpenRecord(selectedZbr.Id))
                {
                    form.ShowDialog();
                    GetData();
                }
            }
            GetData();
        }

        protected void DeleteRecord()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Zbran zbran = dataGridView1.SelectedRows[0].DataBoundItem as Zbran;
                Zbran.delete(zbran);
                GetData();
            }
        }

        protected void AddRecord()
        {
            DZbran form = new DZbran();
            if (form.OpenRecord(null))
            {
                form.ShowDialog();
                GetData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRecord();
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

    }
}
