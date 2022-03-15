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
    public partial class FrmTestLinq : Form
    {
        private gsbrapports2021Entities mesDonnees;
        public FrmTestLinq(gsbrapports2021Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
          

            //Recherche via requête Linq
            var leRapport = (from rapport in mesDonnees.rapport
                             join medecin in mesDonnees.medecin on rapport.idMedecin equals medecin.id
                             join visiteur in mesDonnees.visiteur on rapport.idVisiteur equals visiteur.id
                             orderby rapport.date descending
                             where medecin.nom == "Casson" && medecin.departement == 1
                             select new
                             {
                                 txtMedcin = medecin.nom + " " + medecin.prenom,
                                 dateRapp = rapport.date,
                                 txtMotif = rapport.motif,
                                 txtBilan = rapport.bilan,
                                 txtVisiteur = visiteur.nom + " " + visiteur.prenom
                             }).First();




            //bdgTestLinq.DataSource = leRapport.ToL;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           

        }

        private void FrmTestLinq_Load(object sender, EventArgs e)
        {

        }
    }
}
