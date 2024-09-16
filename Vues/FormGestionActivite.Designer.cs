
namespace FormationSNCF.Vues
{
    partial class FormGestionActivite
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
            this.groupboxAjoutConsultationActivite = new System.Windows.Forms.GroupBox();
            this.NomActiviteAjout = new System.Windows.Forms.Label();
            this.textboxNomActivite = new System.Windows.Forms.TextBox();
            this.ListeActivites = new System.Windows.Forms.Label();
            this.listBoxListeActivite = new System.Windows.Forms.ListBox();
            this.buttonAjoutActivite = new System.Windows.Forms.Button();
            this.groupboxAjoutConsultationActivite.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxAjoutConsultationActivite
            // 
            this.groupboxAjoutConsultationActivite.Controls.Add(this.buttonAjoutActivite);
            this.groupboxAjoutConsultationActivite.Controls.Add(this.listBoxListeActivite);
            this.groupboxAjoutConsultationActivite.Controls.Add(this.ListeActivites);
            this.groupboxAjoutConsultationActivite.Controls.Add(this.textboxNomActivite);
            this.groupboxAjoutConsultationActivite.Controls.Add(this.NomActiviteAjout);
            this.groupboxAjoutConsultationActivite.Location = new System.Drawing.Point(31, 32);
            this.groupboxAjoutConsultationActivite.Name = "groupboxAjoutConsultationActivite";
            this.groupboxAjoutConsultationActivite.Size = new System.Drawing.Size(715, 381);
            this.groupboxAjoutConsultationActivite.TabIndex = 0;
            this.groupboxAjoutConsultationActivite.TabStop = false;
            this.groupboxAjoutConsultationActivite.Text = "Ajout et consultation d\'actvités";
            this.groupboxAjoutConsultationActivite.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NomActiviteAjout
            // 
            this.NomActiviteAjout.AutoSize = true;
            this.NomActiviteAjout.Location = new System.Drawing.Point(118, 64);
            this.NomActiviteAjout.Name = "NomActiviteAjout";
            this.NomActiviteAjout.Size = new System.Drawing.Size(129, 13);
            this.NomActiviteAjout.TabIndex = 0;
            this.NomActiviteAjout.Text = "Nom de l\'activite à ajouter";
            // 
            // textboxNomActivite
            // 
            this.textboxNomActivite.Location = new System.Drawing.Point(264, 64);
            this.textboxNomActivite.Name = "textboxNomActivite";
            this.textboxNomActivite.Size = new System.Drawing.Size(219, 20);
            this.textboxNomActivite.TabIndex = 1;
            this.textboxNomActivite.TextChanged += new System.EventHandler(this.textboxNomActivite_TextChanged);
            // 
            // ListeActivites
            // 
            this.ListeActivites.AutoSize = true;
            this.ListeActivites.Location = new System.Drawing.Point(118, 97);
            this.ListeActivites.Name = "ListeActivites";
            this.ListeActivites.Size = new System.Drawing.Size(91, 13);
            this.ListeActivites.TabIndex = 2;
            this.ListeActivites.Text = "Liste des activités";
            // 
            // listBoxListeActivite
            // 
            this.listBoxListeActivite.FormattingEnabled = true;
            this.listBoxListeActivite.Items.AddRange(new object[] {
            "INFORMATIQUE",
            "COMPTABILITE"});
            this.listBoxListeActivite.Location = new System.Drawing.Point(264, 97);
            this.listBoxListeActivite.Name = "listBoxListeActivite";
            this.listBoxListeActivite.Size = new System.Drawing.Size(219, 173);
            this.listBoxListeActivite.TabIndex = 3;
            this.listBoxListeActivite.SelectedIndexChanged += new System.EventHandler(this.listBoxListeActivite_SelectedIndexChanged);
            // 
            // buttonAjoutActivite
            // 
            this.buttonAjoutActivite.Location = new System.Drawing.Point(591, 64);
            this.buttonAjoutActivite.Name = "buttonAjoutActivite";
            this.buttonAjoutActivite.Size = new System.Drawing.Size(75, 23);
            this.buttonAjoutActivite.TabIndex = 4;
            this.buttonAjoutActivite.Text = "AJOUTER";
            this.buttonAjoutActivite.UseVisualStyleBackColor = true;
            this.buttonAjoutActivite.Click += new System.EventHandler(this.buttonAjoutActivite_Click);
            // 
            // FormGestionActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupboxAjoutConsultationActivite);
            this.Name = "FormGestionActivite";
            this.Text = "FormGestionActivite";
            this.groupboxAjoutConsultationActivite.ResumeLayout(false);
            this.groupboxAjoutConsultationActivite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxAjoutConsultationActivite;
        private System.Windows.Forms.Button buttonAjoutActivite;
        private System.Windows.Forms.ListBox listBoxListeActivite;
        private System.Windows.Forms.Label ListeActivites;
        private System.Windows.Forms.TextBox textboxNomActivite;
        private System.Windows.Forms.Label NomActiviteAjout;
    }
}