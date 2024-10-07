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
using FormationSNCF.Ressources;

namespace FormationSNCF.Vues
{
    public partial class FormGestionActionFormation : Form
    {
        public FormGestionActionFormation()
        {
            InitializeComponent();
        }

        private void FormGestionActionFormation_Load(object sender, EventArgs e)
        {
            comboBoxListeActivit.DataSource = Donnees.CollectionActivite;
            comboBoxListeActivit.DisplayMember = "LibelleActivite";

        }

        private void comboBoxListeActivit_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activite activiteSelectionnee = comboBoxListeActivit.SelectedItem as Activite;
            dataGridViewActionFormation.DataSource = activiteSelectionnee.LesActionsFormation;

        }

        private void buttonAjoutActionFormation_Click(object sender, EventArgs e)
        {
            if (comboBoxListeActivit.SelectedIndex == -1)
            {
                MessageBox.Show("Sélectionnez une activité de formation");
            }
            else if (textBoxIntituleActionDeFormation.Text == "")
            {
                MessageBox.Show("Saisir l'intitulé de l'action de formation");
            }
            else if (textBoxCodeAction.Text == "")
            {
                MessageBox.Show("Saisir le code de l'action de formation");
            }
            else if (textBoxCoutAction.Text == "")
            {
                MessageBox.Show("Saisir le coût de l'action de formation");
            }
            else if (textBoxDureeAction.Text == "")
            {
                MessageBox.Show("Saisir la durée de l'action de formation");
            }
            else
            {
                Activite activiteSelectionnee = comboBoxListeActivit.SelectedItem as Activite;
                if (activiteSelectionnee != null)
                {
                    activiteSelectionnee.AjouterActionFormation(
                                 textBoxCodeAction.Text,
                                 textBoxIntituleActionDeFormation.Text,
                                 decimal.Parse(textBoxCoutAction.Text),
                                 int.Parse(textBoxDureeAction.Text),
                                 DateTime.Parse(textBoxDateCreation.Text));
                }

                dataGridViewActionFormation.DataSource = activiteSelectionnee.LesActionsFormation;

                textBoxIntituleActionDeFormation.Clear();
                textBoxCodeAction.Clear();
                textBoxCoutAction.Clear();
                textBoxDureeAction.Clear();
                textBoxDateCreation.Clear();

            }
        }
    }
}
