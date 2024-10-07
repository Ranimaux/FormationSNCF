
namespace FormationSNCF.Vues
{
    partial class FormArchivageAgent
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
            this.groupBoxListAgent = new System.Windows.Forms.GroupBox();
            this.dataGridViewListAgent = new System.Windows.Forms.DataGridView();
            this.buttonArchiverAgent = new System.Windows.Forms.Button();
            this.groupBoxListAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAgent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListAgent
            // 
            this.groupBoxListAgent.Controls.Add(this.buttonArchiverAgent);
            this.groupBoxListAgent.Controls.Add(this.dataGridViewListAgent);
            this.groupBoxListAgent.Location = new System.Drawing.Point(56, 28);
            this.groupBoxListAgent.Name = "groupBoxListAgent";
            this.groupBoxListAgent.Size = new System.Drawing.Size(710, 377);
            this.groupBoxListAgent.TabIndex = 0;
            this.groupBoxListAgent.TabStop = false;
            this.groupBoxListAgent.Text = "Listes des agents";
            // 
            // dataGridViewListAgent
            // 
            this.dataGridViewListAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAgent.Location = new System.Drawing.Point(30, 30);
            this.dataGridViewListAgent.Name = "dataGridViewListAgent";
            this.dataGridViewListAgent.Size = new System.Drawing.Size(650, 140);
            this.dataGridViewListAgent.TabIndex = 0;
            this.dataGridViewListAgent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListAgent_CellContentClick);
            this.dataGridViewListAgent.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListAgent_RowEnter);
            // 
            // buttonArchiverAgent
            // 
            this.buttonArchiverAgent.Location = new System.Drawing.Point(512, 276);
            this.buttonArchiverAgent.Name = "buttonArchiverAgent";
            this.buttonArchiverAgent.Size = new System.Drawing.Size(168, 23);
            this.buttonArchiverAgent.TabIndex = 1;
            this.buttonArchiverAgent.Text = "Archiver Agent";
            this.buttonArchiverAgent.UseVisualStyleBackColor = true;
            this.buttonArchiverAgent.Click += new System.EventHandler(this.buttonArchiverAgent_Click);
            // 
            // FormArchivageAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxListAgent);
            this.Name = "FormArchivageAgent";
            this.Text = "FormArchivageAgent";
            this.Load += new System.EventHandler(this.FormArchivageAgent_Load);
            this.groupBoxListAgent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAgent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListAgent;
        private System.Windows.Forms.DataGridView dataGridViewListAgent;
        private System.Windows.Forms.Button buttonArchiverAgent;
    }
}