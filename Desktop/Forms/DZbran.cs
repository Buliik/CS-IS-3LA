using System;
using System.Windows.Forms;
using Bul0056.Aggregates;

namespace Bul0056.Forms
{
    public partial class DZbran : Form
    {
        private Zbran zbran;
        private bool newRecord;
        public DZbran()
        {
            InitializeComponent();
        }

        private void BindData()
        {
            txtNazev.Text = zbran.Nazev;
            txtTyp.Text = zbran.Typ;
            txtRaze.Text = zbran.Raze.ToString();
            txtRok.Text = zbran.Rok_vyroby.ToString();
        }

        public bool OpenRecord(object primaryKey)
        {
            if (primaryKey != null)
            {
                int idZbr = (int)primaryKey;
                zbran = Zbran.getById(idZbr);
                newRecord = false;
            }
            else
            {
                zbran = new Zbran();
                newRecord = true;
            }
            BindData();
            return true;
        }

        private bool GetData()
        {
            zbran.Nazev = txtNazev.Text;
            zbran.Typ = txtTyp.Text;
            zbran.Raze = double.Parse(txtRaze.Text);
            zbran.Rok_vyroby = Int32.Parse(txtRok.Text);
            return true;
        }

        protected bool SaveRecord()
        {
            if (GetData())
            {
                if (newRecord)
                {
                    Zbran.insert(zbran);
                }
                else
                {
                    Zbran.update(zbran);
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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveRecord();
            this.Close();
        }

        private void DZbran_Load(object sender, EventArgs e)
        {

        }
    }
}
