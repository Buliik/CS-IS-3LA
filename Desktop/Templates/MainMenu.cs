using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bul0056.Templates
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void zbraněToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.LZbran form = new Forms.LZbran();
            form.MdiParent = this;
            form.Show();
        }

        private void zaměstnanciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.LZamestnanec form = new Forms.LZamestnanec();
            form.MdiParent = this;
            form.Show();
        }

        private void zákazníciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.LZakaznik form = new Forms.LZakaznik();
            form.MdiParent = this;
            form.Show();
        }

        private void střelbyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.LStrelba form = new Forms.LStrelba();
            form.MdiParent = this;
            form.Show();
        }
    }
}
