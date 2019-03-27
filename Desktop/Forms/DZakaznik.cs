using System;
using System.Windows.Forms;
using Bul0056.Aggregates;

namespace Bul0056.Forms
{
    public partial class DZakaznik : Form
    {
        private Zakaznik zakaznik;
        private bool newRecord;
        public DZakaznik()
        {
            InitializeComponent();
        }

        private void BindData()
        {
            txtJm.Text = zakaznik.Jmeno;
            txtPr.Text = zakaznik.Prijmeni;
            txtEm.Text = zakaznik.Email;
            Year.Text = zakaznik.Datum_narozeni.Year.ToString();
            Month.Text = zakaznik.Datum_narozeni.Month.ToString();
            Day.Text = zakaznik.Datum_narozeni.Day.ToString();
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idZak = (int)primaryKey;
                zakaznik = Zakaznik.getById(idZak);
                newRecord = false;
            }
            else
            {
                zakaznik = new Zakaznik();
                newRecord = true;
            }
            BindData();
            return true;
        }

        private bool GetData()
        {
            zakaznik.Jmeno = txtJm.Text;
            zakaznik.Prijmeni = txtPr.Text;
            zakaznik.Email = txtEm.Text;
            zakaznik.Datum_narozeni = new DateTime(Int32.Parse(Year.Text), Int32.Parse(Month.Text), Int32.Parse(Day.Text));
            return true;
        }

        protected bool SaveRecord()
        {
            if (GetData())
            {
                if (newRecord)
                {
                    Zakaznik.insert(zakaznik);
                }
                else
                {
                    Zakaznik.update(zakaznik);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveRecord();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
