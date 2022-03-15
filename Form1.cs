using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3_vA
{
    public partial class Form1 : Form
    {
       private gsbrapports2021Entities mesDonnees;
        public Form1()
        {
            InitializeComponent();
            this.mesDonnees = new gsbrapports2021Entities();
        }

        private void rapportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGererMedecin f = new FrmGererMedecin(this.mesDonnees);
            f.Show();
        }

        private void dérnierRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapport f = new FrmRapport(this.mesDonnees);
            f.Show();
        }

        private void testerLinqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTestLinq f = new FrmTestLinq(this.mesDonnees);
            f.Show();
        }
    }
}
