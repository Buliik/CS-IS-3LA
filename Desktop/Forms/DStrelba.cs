using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bul0056.Aggregates;

namespace Bul0056.Forms
{
    public partial class DStrelba : Form
    {
        private Strelba strelba;
        private bool newRecord;
        public DStrelba()
        {
            InitializeComponent();
        }

        private void BindData()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

            Collection<Prostor> prostory = Prostor.SelectAll();
            Collection<Zbran> zbrane = Zbran.SelectAvailable(strelba.Zacatek, strelba.Zacatek.AddMinutes(double.Parse(txtMin.Text)));
            Collection<Zakaznik> zakaznici = Zakaznik.SelectAll();
            Collection<Zamestnanec> zamestnanci = Zamestnanec.SelectAll();

            foreach (Prostor prostor in prostory)
            {
                comboBox1.Items.Add(prostor.Id.ToString() + " " + prostor.Vzdalenost.ToString() + "m");
                if (prostor.Id == strelba.Prostor.Id) comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }


            foreach (Zbran zbran in zbrane)
            {
                comboBox2.Items.Add(zbran.Nazev);
                if (zbran.Id == strelba.Zbran.Id) comboBox2.SelectedIndex = comboBox2.Items.Count - 1;
            }
           
            foreach (Zakaznik zakaznik in zakaznici)
            {
                comboBox3.Items.Add(zakaznik.Email);
                if (zakaznik.Id == strelba.Zakaznik.Id) comboBox3.SelectedIndex = comboBox3.Items.Count - 1;
            }

            foreach (Zamestnanec zamestnanec in zamestnanci)
            {
                comboBox4.Items.Add(zamestnanec.Email);
                if (zamestnanec.Id == strelba.Zamestnanec.Id) comboBox4.SelectedIndex = comboBox4.Items.Count - 1;
            }

           
        }

        private bool GetData()
        {
            Collection<Zakaznik> zakaznici = Zakaznik.SelectAll();
            Collection<Zamestnanec> zamestnanci = Zamestnanec.SelectAll();
            Collection<Zbran> zbrane = Zbran.SelectAvailable(DateTime.Now, DateTime.Now.AddMinutes(double.Parse(txtMin.Text)));
            Collection<Prostor> prostory = Prostor.SelectAll();

            strelba.Zacatek = DateTime.Now;
            strelba.Konec = DateTime.Now.AddMinutes(Double.Parse(txtMin.Text));
            strelba.Zakaznik = zakaznici[comboBox3.SelectedIndex];
            strelba.Zamestnanec = zamestnanci[comboBox4.SelectedIndex];
            strelba.Prostor = prostory[comboBox1.SelectedIndex];
            strelba.Zbran = zbrane[comboBox2.SelectedIndex];

            return true;
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idStr = (int)primaryKey;
                strelba = Strelba.getById(idStr);
                newRecord = false;
            }
            else
            {
                strelba = new Strelba();
                newRecord = true;
            }

            TimeSpan span = strelba.Konec.Subtract(strelba.Zacatek);

            txtMin.Text = span.TotalMinutes.ToString();

            BindData();
            return true;
        }

        protected bool SaveRecord()
        {
            if (GetData())
            {
                if (newRecord)
                {
                    Strelba.insert(strelba);
                }
                else
                {
                    Strelba.update(strelba);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveRecord();
            this.Close();
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
