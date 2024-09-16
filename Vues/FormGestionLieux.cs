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
    public partial class FormGestionLieux : Form
    {
        public FormGestionLieux()
        {
            InitializeComponent();
        }

        private void FormGestionLieux_Load(object sender, EventArgs e)
        {
        }

        private void FormGestionLieux_Click(object sender, EventArgs e)
        {
            if (textBoxLibelle.Text.Length < 3)
            {
                MessageBox.Show("Le lieu doit être composé d'au moins 3 caractères");
                textBoxLibelle.Text = "";
                textBoxLibelle.Focus();
            }
            else if(textBoxTelephone.Text.Length == 0)
            {
                MessageBox.Show("Le numéro de téléphone est obligatoire");
                textBoxTelephone.Focus();
            }
            else if(textBoxCodePostal.Text.Length == 0)
            {
                MessageBox.Show("Le code postal est obligatoire");
                textBoxCodePostal.Focus();
            }
            else
            {
                dataGridViewListeLieu.DataSource = null;
                int numeroMax = 0;
                foreach (Lieu unLieu in Donnees.CollectionLieu)
                {
                    if (unLieu.Numero > numeroMax)
                        numeroMax = unLieu.Numero;
                }

                Lieu nouveauLieu = new Lieu(numeroMax + 1, textBoxLibelle.Text, textBoxCodePostal.Text, textBoxTelephone.Text);
                Donnees.CollectionLieu.Add(nouveauLieu);
                dataGridViewListeLieu.DataSource = Donnees.CollectionLieu;
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void libelle_Click(object sender, EventArgs e)
        {

        }

        private void FormGestionLieux_Load_1(object sender, EventArgs e)
        {
            dataGridViewListeLieu.DataSource = Donnees.CollectionLieu;
        }

        private void GroupBoxAjoutLieu_Enter(object sender, EventArgs e)
        {

        }

        

        private void ButtonAjoutLieux_Click(object sender, EventArgs e)
        {
            if (textBoxLibelle.Text.Length < 3)
            {
                MessageBox.Show("Le lieu doit être composé d'au moins 3 caractères");
                textBoxLibelle.Text = "";
                textBoxLibelle.Focus();
            }
            else if (textBoxTelephone.Text.Length == 0)
            {
                MessageBox.Show("Le numéro de téléphone est obligatoire");
                textBoxTelephone.Focus();
            }
            else if (textBoxCodePostal.Text.Length == 0)
            {
                MessageBox.Show("Le code postal est obligatoire");
                textBoxCodePostal.Focus();
            }
            else
            {
                dataGridViewListeLieu.DataSource = null;
                int numeroMax = 0;
                foreach (Lieu unLieu in Donnees.CollectionLieu)
                {
                    if (unLieu.Numero > numeroMax)
                        numeroMax = unLieu.Numero;
                }

                Lieu nouveauLieu = new Lieu(numeroMax + 1, textBoxLibelle.Text, textBoxCodePostal.Text, textBoxTelephone.Text);
                Donnees.CollectionLieu.Add(nouveauLieu);
                dataGridViewListeLieu.DataSource = Donnees.CollectionLieu;
            }
        }

        private void dataGridViewListeLieu1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormFenetrePrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            Donnees.SauvegardeDonnees();
        }
    }
}
