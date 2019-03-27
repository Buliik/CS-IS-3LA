using System;
using System.Windows.Forms;
using Bul0056.Aggregates;

namespace Bul0056.Forms
{
    public partial class DZamestnanec : Form
    {
        private Zamestnanec zamestnanec;
        private bool newRecord;
        public DZamestnanec()
        {
            InitializeComponent();
        }

        private void BindData()
        {
            txtJm.Text = zamestnanec.Jmeno;
            txtPr.Text = zamestnanec.Prijmeni;
            txtEm.Text = zamestnanec.Email;
            Year.Text = zamestnanec.Datum_narozeni.Year.ToString();
            Month.Text = zamestnanec.Datum_narozeni.Month.ToString();
            Day.Text = zamestnanec.Datum_narozeni.Day.ToString();
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idZam = (int)primaryKey;
                zamestnanec = Zamestnanec.getById(idZam);
                newRecord = false;
            }
            else
            {
                zamestnanec = new Zamestnanec();
                newRecord = true;
            }
            BindData();
            return true;
        }

        private bool GetData()
        {
            zamestnanec.Jmeno = txtJm.Text;
            zamestnanec.Prijmeni = txtPr.Text;
            zamestnanec.Email = txtEm.Text;
            zamestnanec.Datum_narozeni = new DateTime(Int32.Parse(Year.Text), Int32.Parse(Month.Text), Int32.Parse(Day.Text));
            return true;
        }

        protected bool SaveRecord()
        {
            if (GetData())
            {
                if (newRecord)
                {
                    Zamestnanec.insert(zamestnanec);
                }
                else
                {
                    Zamestnanec.update(zamestnanec);
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
