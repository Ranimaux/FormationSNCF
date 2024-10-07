using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormationSNCF.Vues;
using FormationSNCF.Modele;
using FormationSNCF.Ressources;
using FormationSNCF.Vues;

namespace FormationSNCF.Vues
{
    public partial class FormArchivageAgent : Form
    {
        public FormArchivageAgent()
        {
            InitializeComponent();
        }

        private void FormArchivageAgent_Load(object sender, EventArgs e)
        {
            dataGridViewListAgent.DataSource = Donnees.CollectionAgent;
            for (int i = 0; i < dataGridViewListAgent.Columns.Count; i++)
            {
                dataGridViewListAgent.Columns[i].Visible = false;
            }
            for (int i = 0; i < 4; i++)
            {
                dataGridViewListAgent.Columns[i].Visible = true;
            }
        }

        //private void ReinitialiserFormulaire()
        //{
        //    foreach (Control unControlDuFormulaire in ajoutAgentGroupBox.Controls)
        //    {
        //        if (unControlDuFormulaire.GetType() == typeof(TextBox))
        //        {
        //            (unControlDuFormulaire as TextBox).Clear();
        //        }
        //    }
        //    int max = 0;
        //    foreach (Agent unAgent in Donnees.CollectionAgent)
        //    {
        //        if (unAgent.Numero > max)
        //            max = unAgent.Numero;
        //    }
        //}

        private void dataGridViewListAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonArchiverAgent_Click(object sender, EventArgs e)
        {
            if(dataGridViewListAgent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionner un agent à archiver.");
            }
            else
            {
                dataGridViewListAgent.DataSource = null;
                Agent selectedAgent = null;
                foreach(DataGridViewRow uneLigneDuDataGridView in dataGridViewListAgent.SelectedRows)
                {
                    selectedAgent = uneLigneDuDataGridView.DataBoundItem as Agent;
                }
                dataGridViewListAgent.DataSource = selectedAgent;
                string message = "Etes vous sûr de vouloir archiver";
                string caption = "Error Detected";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if(result == System.Windows.Forms.DialogResult.Yes)
                {
                    Donnees.AgentArchive.Add(selectedAgent);
                    Donnees.CollectionAgent.Remove(selectedAgent);
                    this.Close();
                }
            }
        }

        private void dataGridViewListAgent_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewListAgent.DataSource = null;
            if(dataGridViewListAgent.SelectedRows.Count > 0)
            {
                Agent selectedAgent = dataGridViewListAgent.SelectedRows[0].DataBoundItem as Agent;
                dataGridViewListAgent.DataSource = selectedAgent;
            }
        }
    }
}
