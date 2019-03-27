using System;
using System.ComponentModel;
using System.Windows.Forms;
using Bul0056.Aggregates;
using System.Collections.ObjectModel;

namespace Bul0056.Forms
{
    public partial class LZamestnanec : Form
    {
        public LZamestnanec()
        {
            InitializeComponent();
            GetData();
        }

        protected void GetData()
        {
            Collection<Zamestnanec> zamestnanci = Zamestnanec.SelectAll();
            BindingList<Zamestnanec> bindingList = new BindingList<Zamestnanec>(zamestnanci);
            dataGridView1.DataSource = bindingList;
        }

        private Zamestnanec GetSelectedZam()
        {
            // The "SelectionMode" property of the data grid view must be set to "FullRowSelect".
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Zamestnanec zamestnanec = dataGridView1.SelectedRows[0].DataBoundItem as Zamestnanec;
                return zamestnanec;
            }
            else
            {
                return null;
            }
        }


        protected void DeleteRecord()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Zamestnanec zamestnanec = dataGridView1.SelectedRows[0].DataBoundItem as Zamestnanec;
                Zamestnanec.delete(zamestnanec);
                GetData();
            }
        }

        protected void EditRecord()
        {
            Zamestnanec selectedZam = GetSelectedZam();
            if (selectedZam != null)
            {
                DZamestnanec form = new DZamestnanec();
                if (form.OpenRecord(selectedZam.Id))
                {
                    form.ShowDialog();
                    GetData();
                }
            }
            GetData();
        }
        protected void AddRecord()
        {
            DZamestnanec form = new DZamestnanec();
            if (form.OpenRecord(null))
            {
                form.ShowDialog();
                GetData();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zamestnanec.sXML();
        }
    }
}
