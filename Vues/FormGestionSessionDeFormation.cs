using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormationSNCF.Ressources;
using FormationSNCF.Vues;
using FormationSNCF.Modele;

namespace FormationSNCF.Vues
{
    public partial class FormGestionSessionDeFormation : Form
    {
        private Activite _activiteSelectionnee;
        private ActionFormation _actionFormationSelectionnee;
        public FormGestionSessionDeFormation()
        {
            InitializeComponent();
        }
        private void ReinitialiserLesChampsTexte()
        {
            foreach (Control unControlDuFormulaire in Controls)
            {
                if (unControlDuFormulaire.GetType() == typeof(TextBox))
                {
                    (unControlDuFormulaire as TextBox).Clear();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGestionSessionDeFormation_Load(object sender, EventArgs e)
        {
            comboBoxListActivite.DataSource = Donnees.CollectionActivite;
            comboBoxListActivite.DisplayMember = "LibelleActivite";
            
            comboBoxListLieu.DataSource = Donnees.CollectionLieu;
            comboBoxListLieu.DisplayMember = "LibelleLieu";
            comboBoxListLieu.ValueMember = "Numero";

        }

        private void comboBoxListActivite_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReinitialiserLesChampsTexte();
            comboBoxListActionFormation.DataSource = null;
            

            _activiteSelectionnee = comboBoxListActivite.SelectedItem as Activite;
            if (_activiteSelectionnee != null)
            {
                if (_activiteSelectionnee.LesActionsFormation.Count > 0)
                {
                    comboBoxListActionFormation.DataSource = _activiteSelectionnee.LesActionsFormation;
                    comboBoxListActionFormation.DisplayMember = "Intitule";
                }
            }

        }
    }
}
