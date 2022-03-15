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
    public partial class FrmAjouterMedecin : Form
    {
        private gsbrapports2021Entities mesDonnees;
        public FrmAjouterMedecin()
        {
            InitializeComponent();
        }

        public FrmAjouterMedecin(gsbrapports2021Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            for (int i = 1; i < 10; i++)
            {
                this.cmbDepaErg.Items.Add(i);
                

            }
        }

        private void FrmAjouterMedecin_Load(object sender, EventArgs e)
        {

        }

        private int newNumMedecin()
        {
            int n;
            int dernier = (from med in this.mesDonnees.medecin
                           select med.id).Max();
            n = dernier + 1;
            return n;
        }

        private medecin AjouteMedecin()
        {
            medecin l = new medecin();
            int n = newNumMedecin();

            string nom = this.txtNomAjou.Text;
            string prenom = this.txtPrenomajou.Text;
            string adresse = this.txtAdressAjou.Text;
            string tel = this.txtTelAjou.Text;
            string spc = this.txtSpcAjou.Text;
            int dep = Convert.ToInt32(this.cmbDepaErg.SelectedItem);

            l.nom = nom;
            l.prenom = prenom;
            l.adresse = adresse;
            l.tel = tel;
            l.specialiteComplementaire = spc;
            l.departement = dep;

            return l;

        }

        private void grpAjoutMedecin_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.mesDonnees.medecin.Add(AjouteMedecin());
            this.mesDonnees.SaveChanges();
            MessageBox.Show("L'application à Ajouter un medecin.");

        }
    }
}
