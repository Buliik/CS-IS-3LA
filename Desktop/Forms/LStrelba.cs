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
    public partial class LStrelba : Form
    {
        public LStrelba()
        {
            InitializeComponent();
            GetData();
        }

        protected void GetData()
        {
            Collection<Strelba> strelby = Strelba.SelectAll();
            Collection<StrelbaDTO> vystup = new Collection<StrelbaDTO>();
            foreach(Strelba strelba in strelby)
            {
                vystup.Add(new StrelbaDTO(strelba));
            }
            BindingList<StrelbaDTO> bindingList = new BindingList<StrelbaDTO>(vystup);
            dataGridView1.DataSource = bindingList;
        }

        private Strelba GetSelectedStr()
        {
            // The "SelectionMode" property of the data grid view must be set to "FullRowSelect".
            if (dataGridView1.SelectedRows.Count == 1)
            {
                StrelbaDTO strelba = dataGridView1.SelectedRows[0].DataBoundItem as StrelbaDTO;
                return Strelba.getById(strelba.Id);
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
                StrelbaDTO strelba = dataGridView1.SelectedRows[0].DataBoundItem as StrelbaDTO;
                Strelba.delete(Strelba.getById(strelba.Id));
                GetData();
            }
        }

        protected void EditRecord()
        {
            Strelba selectedStr = GetSelectedStr();
            if (selectedStr != null)
            {
                DStrelba form = new DStrelba();
                if (form.OpenRecord(selectedStr.Id))
                {
                    form.ShowDialog();
                    GetData();
                }
            }
            GetData();
        }
        protected void AddRecord()
        {
            DStrelba form = new DStrelba();
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

    }
}
