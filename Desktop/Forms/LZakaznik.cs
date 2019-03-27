using System;
using System.ComponentModel;
using System.Windows.Forms;
using Bul0056.Aggregates;
using System.Collections.ObjectModel;

namespace Bul0056.Forms
{
    public partial class LZakaznik : Form
    {
        public LZakaznik()
        {
            InitializeComponent();
            GetData();
        }

        protected void GetData()
        {
            Collection<Zakaznik> zakaznici = Zakaznik.SelectAll();
            Collection<Zakaznik> odpadlici = Zakaznik.Requests();
            BindingList<Zakaznik> bindingList = new BindingList<Zakaznik>(zakaznici);
            BindingList<Zakaznik> bindingList2 = new BindingList<Zakaznik>(odpadlici);
            dataGridView1.DataSource = bindingList;
            dataGridView2.DataSource = bindingList2;
        }

        private Zakaznik GetSelectedZak()
        {
            // The "SelectionMode" property of the data grid view must be set to "FullRowSelect".
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Zakaznik zakaznik = dataGridView1.SelectedRows[0].DataBoundItem as Zakaznik;
                return zakaznik;
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
                Zakaznik zakaznik = dataGridView1.SelectedRows[0].DataBoundItem as Zakaznik;
                Zakaznik.delete(zakaznik);
                GetData();
            }
        }

        protected void DeleteRequest()
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                Zakaznik zakaznik = dataGridView2.SelectedRows[0].DataBoundItem as Zakaznik;
                Zakaznik.delete(zakaznik);
                GetData();
            }
        }

        protected void DeleteAll()
        {
           
             Collection<Zakaznik> odpadlici = Zakaznik.Requests();
             foreach(Zakaznik zakaznik in odpadlici)
             {
                Zakaznik.delete(zakaznik);
             }              
             GetData();

        }

        protected void EditRecord()
        {
            Zakaznik selectedZak = GetSelectedZak();
            if (selectedZak != null)
            {
                DZakaznik form = new DZakaznik();
                if (form.OpenRecord(selectedZak.Id))
                {
                    form.ShowDialog();
                    GetData();
                }
            }
            GetData();
        }
        protected void AddRecord()
        {
            DZakaznik form = new DZakaznik();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteRequest();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteAll();
        }
    }
}
