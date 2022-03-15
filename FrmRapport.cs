using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace Mission3_vA
{
    public partial class FrmRapport : Form
    {
        private gsbrapports2021Entities mesDonnees;
        public FrmRapport (gsbrapports2021Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgRapMed.DataSource = this.mesDonnees.medecin.ToList();
            this.bdgRapport.DataSource = this.mesDonnees.rapport.ToList();
            this.bdgRepMedic.DataSource = this.mesDonnees.offrir.ToList();


            for (int i = 1; i < 10; i++)
            {
                this.cmbDeparRpp.Items.Add(i);

            }
        }

    public FrmRapport()
    {
        InitializeComponent();
    }

    private void FrmRapport_Load(object sender, EventArgs e)
    {

    }

        private void cmbNomRapp_SelectedIndexChanged(object sender, EventArgs e)
        {

            string rechercheNom = cmbNomRapp.Text;

            var NomMedecin = (
                               from medecin in this.mesDonnees.medecin
                               where  medecin.nom == rechercheNom
                               select medecin);

        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
        
            try
            {

                //Verification champs vides
                if (cmbNomRapp.Text == "" || cmbDeparRpp.Text == "")
                {
                    MessageBox.Show("Erreur: Veuillez renseigner tous les champs.");
                }
                else
                {
                    //Récupération des critères de recherche
                    string rechercheNom = cmbNomRapp.Text;
                    int recherchDeaprt = Convert.ToInt32(cmbDeparRpp.Text);
                  

                    //Recherche via requête Linq
                    var leRapport = (from rapport in mesDonnees.rapport
                                     join medecin in mesDonnees.medecin on rapport.idMedecin equals medecin.id
                                     join visiteur in mesDonnees.visiteur on rapport.idVisiteur equals visiteur.id
                                     where medecin.nom == rechercheNom && medecin.departement == recherchDeaprt
                                     orderby rapport.date descending
                                     select rapport
                              );
                    foreach(rapport rapp in leRapport)
                    {
                        string motif = rapp.motif;
                        string bilan = rapp.bilan;
                        medecin medecin = rapp.medecin;
                        visiteur visit = rapp.visiteur;




                        // dateDataGridView.Text = rapp.date.ToString();
                      //  this.dataGridRapport.Columns.Add();
                          

                    }

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Erreur: aucun rapport trouvé.");
            }



        }

        private void grpRapport_Enter(object sender, EventArgs e)
        {

        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            //Récupération des critères de recherche
            string rechercheNom = cmbNomRapp.Text;
            int recherchDeaprt = Convert.ToInt32(cmbDeparRpp.Text);
            //Récupère la date et l'heure d'aujourd'hui pour le nom du .xml
            DateTime aujourdhui = DateTime.Now;
            //Recherche via requête Linq
            var leRapport = (from rapports in mesDonnees.rapport
                             join medecins in mesDonnees.medecin on rapports.idMedecin equals medecins.id
                             join visiteurs in mesDonnees.visiteur on rapports.idVisiteur equals visiteurs.id
                             orderby rapports.date descending
                             where medecins.nom == rechercheNom && medecins.departement == recherchDeaprt
                             select new
                             {
                                 NomMedecin = medecins.nom,
                                 DateRapport = rapports.date,
                                 Motif = rapports.motif,
                                 Bilan = rapports.bilan,
                                 NomVisiteur = visiteurs.nom
                             }).First();
            //Serialisation

            //Serialisation
            XElement nomMedecin = new XElement("NomMedecin", leRapport.NomMedecin);
            XElement nomVisiteur = new XElement("NomVisiteur", leRapport.NomVisiteur);
            XElement motif = new XElement("Motif", leRapport.Motif);
            XElement bilan = new XElement("Bilan", leRapport.Bilan);
            XElement date = new XElement("DateRapport", leRapport.DateRapport);
            XElement rapport = new XElement("Rapport");
            rapport.Add(nomMedecin);
            rapport.Add(nomVisiteur);
            rapport.Add(motif);
            rapport.Add(bilan);
            rapport.Add(date);
            XmlSerializer XmlSrlz = new XmlSerializer(typeof(XElement));
            using (StreamWriter sw = new StreamWriter("rapport.xml"))
            {
                XmlSrlz.Serialize(sw, rapport);
            }

            MessageBox.Show("Le fichier: rapport.xml à été enregistré.\r\nDescriptif:\n" + rapport.ToString());
        

    }

        private void dataGridRapport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
