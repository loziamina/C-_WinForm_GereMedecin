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
    public partial class FrmGererMedecin : Form
    {
        private  gsbrapports2021Entities mesDonnees;
        

        public FrmGererMedecin(gsbrapports2021Entities mesDonnees)
        {
            InitializeComponent();

            this.mesDonnees = mesDonnees;
            this.bdgMedecin.DataSource = this.mesDonnees.medecin.ToList();
        
            
            for (int i = 1; i < 10; i++)
            {
                this.cmbDepart.Items.Add(i);
                this.cmbDepaMod.Items.Add(i);

            }
        }

        private void FrmGererMedecin_Load(object sender, EventArgs e)
        {

        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            FrmAjouterMedecin f = new FrmAjouterMedecin(mesDonnees);
            f.Show();
        }

    

        private void btnChercher_Click(object sender, EventArgs e)
        {
            //txtDeprt = Convert.ToInt32(txtDepart.Text);
             string rechercheNom = cmbNomCh.Text;
             int recherchDeaprt = Convert.ToInt32(cmbDepart.Text);
            
             var leMedecin =(
                                from medecin in this.mesDonnees.medecin where medecin.departement == recherchDeaprt && medecin.nom == rechercheNom 
                                select medecin);

             foreach (medecin m in leMedecin)
             {
               
                txtNomMod.Text =  m.nom;
                txtPrenom.Text = m.prenom;
                txtAdress.Text = m.adresse;
                txtTel.Text = m.tel;
                txtSpc.Text = m.specialiteComplementaire;
                cmbDepaMod.SelectedIndex = recherchDeaprt;

             }


        }

        private void cmbNomCh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSupprime_Click(object sender, EventArgs e)
        {
            
            string rechercheNom = cmbNomCh.Text;
            int recherchDeaprt = Convert.ToInt32(cmbDepart.Text);
            rapport rapp = new rapport();
            var supMedecin = ( from medecin in this.mesDonnees.medecin
                              join rapport in mesDonnees.medecin on medecin.id equals rapport.id
                              where medecin.departement == recherchDeaprt && medecin.nom == rechercheNom
                             select medecin).Count();

            var supUnMedecin = (from medecin in this.mesDonnees.medecin
                               
                                where medecin.departement == recherchDeaprt && medecin.nom == rechercheNom
                               select medecin);


            foreach ( medecin m  in supUnMedecin)
            {
                if (supMedecin > 0)
                {
                    MessageBox.Show("Ce medecin il posséde des rapports ");
                }
                else
                {
                    // supUnMedecin.Where( m.nom == rechercheNom , m.departement == recherchDeaprt )
                    MessageBox.Show(m.ToString());
                }

            }
           
           
        }

        private int ModNumMedecin()
        {
            int n;
            int dernier = (from med in this.mesDonnees.medecin
                           select med.id).Max();
            n = dernier + 1;
                return n; 
        }
        private medecin ModifMedecin()
        {
            int n = ModNumMedecin();
            medecin med = (medecin)cmbNomCh.SelectedValue;
            medecin mede = (medecin)cmbDepart.SelectedValue;

            string nom = this.txtNomMod.Text;
            string prenom = this.txtPrenom.Text;
            string adresse = this.txtAdress.Text;
            string tel = this.txtTel.Text;
            string spc = this.txtSpc.Text;
            int dep = Convert.ToInt32(this.cmbDepaMod.SelectedItem);

            medecin l = new medecin();

            l.nom = nom;
            l.prenom = prenom;
            l.adresse = adresse;
            l.tel = tel;
            l.specialiteComplementaire = spc;
            l.departement = dep;

            return l; 


        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            this.mesDonnees.medecin.Add(ModifMedecin());
            this.mesDonnees.SaveChanges();
            MessageBox.Show("L'application à sauvegardée les modifications.");
        }
    }
}
