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
    public partial class FormTestArchiveAgent : Form
    {
        public FormTestArchiveAgent()
        {
            InitializeComponent();
        }

        private void FormTestArchiveAgent_Load(object sender, EventArgs e)
        {
            dataGridViewListAgentArchiver.DataSource = Donnees.AgentArchive;
        }
    }
}
