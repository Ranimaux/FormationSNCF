
namespace FormationSNCF.Vues
{
    partial class FormTestArchiveAgent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxListeAgentArchiver = new System.Windows.Forms.GroupBox();
            this.dataGridViewListAgentArchiver = new System.Windows.Forms.DataGridView();
            this.groupBoxListeAgentArchiver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAgentArchiver)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListeAgentArchiver
            // 
            this.groupBoxListeAgentArchiver.Controls.Add(this.dataGridViewListAgentArchiver);
            this.groupBoxListeAgentArchiver.Location = new System.Drawing.Point(34, 22);
            this.groupBoxListeAgentArchiver.Name = "groupBoxListeAgentArchiver";
            this.groupBoxListeAgentArchiver.Size = new System.Drawing.Size(732, 389);
            this.groupBoxListeAgentArchiver.TabIndex = 0;
            this.groupBoxListeAgentArchiver.TabStop = false;
            this.groupBoxListeAgentArchiver.Text = "Liste agent archiver";
            // 
            // dataGridViewListAgentArchiver
            // 
            this.dataGridViewListAgentArchiver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAgentArchiver.Location = new System.Drawing.Point(29, 34);
            this.dataGridViewListAgentArchiver.Name = "dataGridViewListAgentArchiver";
            this.dataGridViewListAgentArchiver.Size = new System.Drawing.Size(671, 322);
            this.dataGridViewListAgentArchiver.TabIndex = 0;
            // 
            // FormTestArchiveAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxListeAgentArchiver);
            this.Name = "FormTestArchiveAgent";
            this.Text = "FormTestArchiveAgent";
            this.Load += new System.EventHandler(this.FormTestArchiveAgent_Load);
            this.groupBoxListeAgentArchiver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAgentArchiver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListeAgentArchiver;
        private System.Windows.Forms.DataGridView dataGridViewListAgentArchiver;
    }
}