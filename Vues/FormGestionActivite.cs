using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormationSNCF.Modele;
using FormationSNCF.Vues;
using FormationSNCF.Ressources;
using FormationSNCF.Properties;

namespace FormationSNCF.Vues
{
    public partial class FormGestionActivite : Form
    {
        public FormGestionActivite()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAjoutActivite_Click(object sender, EventArgs e)
        {
            if (textboxNomActivite.Text.Length < 3)
            {
                MessageBox.Show("Le nom d'activité doit être composé d'au moins 3 caractères");
                textboxNomActivite.Text = "";
                textboxNomActivite.Focus();
            }
            else
            {
                Activite uneActivite = new Activite(textboxNomActivite.Text);
                if(!Donnees.CollectionActivite.Contains(uneActivite))
                {
                    Donnees.CollectionActivite.Add(uneActivite);
                }
                listBoxListeActivite.DataSource = null;
                listBoxListeActivite.DataSource = Donnees.CollectionActivite;
                
                listBoxListeActivite.DisplayMember = "LibelleActivite";

                //foreach (Activite uneCollectionActivite in Donnees.CollectionActivite)
                //{
                //    if (textboxNomActivite.Text != uneCollectionActivite.LibelleActivite)
                //    {
                //        Activite uneActivite = new Activite(textboxNomActivite.Text);
                //        Donnees.CollectionActivite.Add(uneActivite);
                //    }
                //}
            }
        }

        private void textboxNomActivite_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxListeActivite_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxListeActivite.DataSource = Donnees.CollectionActivite;
        }

        private void FormGestionActivite_Load(object sender, EventArgs e)
        {
            listBoxListeActivite.DataSource = Donnees.CollectionActivite;
            listBoxListeActivite.DisplayMember = "LibelleActivite";
        }

        private void FormFenetrePrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            Donnees.SauvegardeDonnees();
        }
    }
}
