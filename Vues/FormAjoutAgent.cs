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
using FormationSNCF.Properties;
using FormationSNCF.Ressources;
using FormationSNCF.Vues;

namespace FormationSNCF.Vues
{
    public partial class FormAjoutAgent : Form
    {
        public FormAjoutAgent()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void labelAdresse1_Click(object sender, EventArgs e)
        {

        }

        private void FormAjoutAgent_Load(object sender, EventArgs e)
        {
            comboBoxLieu.DataSource = Donnees.CollectionLieu;
            comboBoxLieu.DisplayMember = "LibelleLieu";
            int max = 0;
            foreach (Agent item in Donnees.CollectionAgent)
            {
                if (item.Numero > max)
                    max = item.Numero;
            }
            labelNumeroAgent.Text = Convert.ToString(max + 1);

        }

        private void ReinitialiserFormulaire()
        {
            foreach (Control unControlDuFormulaire in ajoutAgentGroupBox.Controls)
            {
                if (unControlDuFormulaire.GetType() == typeof(TextBox))
                {
                    (unControlDuFormulaire as TextBox).Clear();
                }
            }
            int max = 0;
            foreach (Agent unAgent in Donnees.CollectionAgent)
            {
                if (unAgent.Numero > max)
                    max = unAgent.Numero;
            }
            labelNumeroAgent.Text = Convert.ToString(max + 1);

            comboBoxCivilite.SelectedIndex = 0;
        }

        private void buttonAjoutAgent_Click(object sender, EventArgs e)
        {


            int numeroAgent = int.Parse(labelNumeroAgent.Text);
            string civilite = comboBoxCivilite.Text;
            string nomAgent = textBoxNom.Text;
            string prenomAgent = textBoxPrenom.Text;
            Agent unAgent = new Agent(numeroAgent, civilite, prenomAgent, nomAgent);

            unAgent.Adresse1 = textBoxAdresse1.Text;
            unAgent.Adresse2 = textBoxAdresse2.Text;
            unAgent.CodePostal = textBoxCodePostal.Text;
            unAgent.Ville = textBoxVille.Text;
            if (textBoxDateNaissance.Text != "")
            {
                unAgent.DateNaissance = Convert.ToDateTime(textBoxDateNaissance.Text);
            }
            if (textBoxDateEmbauche.Text != "")
            {
                unAgent.DateEmbauche = Convert.ToDateTime(textBoxDateEmbauche.Text);
            }

            if (comboBoxLieu.SelectedIndex != -1)
            {
                Lieu unLieu = null;
                foreach (Lieu lieu in Donnees.CollectionLieu)
                {
                    if (comboBoxLieu.Text == lieu.LibelleLieu)
                    {
                        unLieu = lieu;
                        break;
                    }
                }
                unAgent.LieuDeTravaille = unLieu;
            }
            Donnees.CollectionAgent.Add(unAgent);
            ReinitialiserFormulaire();
        }

        private void textBoxDateNaissance_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDateNaissance_Leave(object sender, EventArgs e)
        {

            if (!Utilitaire.EstAuFormatDateJJMMAAAA(textBoxDateNaissance.Text))
            {
                MessageBox.Show("Le format de la date est incorrect. Veuilliez respecter le format JJ/MM/AAAA. ");
                textBoxDateNaissance.Text = "";
                textBoxDateNaissance.Focus();
            }
        }

        private void textBoxDateEmbauche_Leave(object sender, EventArgs e)
        {
            if (!Utilitaire.EstAuFormatDateJJMMAAAA(textBoxDateEmbauche.Text))
            {
                MessageBox.Show("Le format de la date est incorrect. Veulliez respecter le format JJ/MM/AAAA");
                textBoxDateEmbauche.Text = "";
                textBoxDateEmbauche.Focus();
            }
        }

        private void textBoxCodePostal_Leave(object sender, EventArgs e)
        {
            if (!Utilitaire.EstAuFormatCodePostal(textBoxCodePostal.Text))
            {
                MessageBox.Show("Le format du Code Postal est incorrect. Veulliez respecter le format '12345' ");
                textBoxCodePostal.Text = "";
                textBoxCodePostal.Focus();
            }
        }

        private bool VerificationDuFormulaireAjoutAgent()
        {
            bool formChecked = true;

            if(comboBoxCivilite.SelectedIndex == -1) 
            {
                MessageBox.Show("Veuillez sélectionner une civilité.");
                comboBoxCivilite.Focus();
                formChecked = false;
            }

            if(textBoxNom.Text.Length < 3)
            {
                MessageBox.Show("Veuillez écrire plus de 3 caractères au Nom");
                textBoxNom.Text = "";
                textBoxNom.Focus();
                formChecked = false;
            }

            if(textBoxPrenom.Text.Length < 3)
            {
                MessageBox.Show("Veuillez écrire plus de 3 caractère au prénom");
                textBoxPrenom.Text = "";
                textBoxPrenom.Focus();
                formChecked = false;
            }

            return formChecked;
        }
    }
}
