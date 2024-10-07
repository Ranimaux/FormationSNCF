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
    public partial class FormFenetrePrincipale : Form
    {
        private Form _mdiChild;

        private Form MdiChild
        {
            get { return _mdiChild; }
            set { if(_mdiChild != null)
                {
                    _mdiChild.Dispose();
                }
                _mdiChild = value;
                _mdiChild.MdiParent = this;
                _mdiChild.MaximumSize = _mdiChild.Size;
                _mdiChild.MinimumSize = _mdiChild.Size;
                _mdiChild.Show();
            }
        }
        public FormFenetrePrincipale()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuPrincipalMenuStripToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDesLieuxToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MdiChild = new FormGestionLieux();
        }

        private void gESTIONACTIVITEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDesActiviteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiChild = new FormGestionActivite();
        }

        private void aJOUTAGENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiChild = new FormAjoutAgent();
        }

        private void gestionDesActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiChild = new FormGestionActionFormation();
        }

        private void GestionSessionsDeFormationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiChild = new FormGestionSessionDeFormation();
        }

        private void InscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MdiChild = new FormGestionInscription();
        }

        private void sESSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ArchiveAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdiChild = new FormArchivageAgent();
        }
    }
}
