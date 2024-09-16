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
        }

        private void textboxNomActivite_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxListeActivite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
