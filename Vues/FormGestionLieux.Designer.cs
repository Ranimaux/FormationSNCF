
namespace FormationSNCF.Vues
{
    partial class FormGestionLieux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionLieux));
            this.GroupBoxAjoutLieu = new System.Windows.Forms.GroupBox();
            this.ButtonAjoutLieux = new System.Windows.Forms.Button();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxCodePostal = new System.Windows.Forms.TextBox();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.telePhone = new System.Windows.Forms.Label();
            this.codePostal = new System.Windows.Forms.Label();
            this.libelle = new System.Windows.Forms.Label();
            this.GroupBoxListeLieu = new System.Windows.Forms.GroupBox();
            this.dataGridViewListeLieu = new System.Windows.Forms.DataGridView();
            this.GroupBoxAjoutLieu.SuspendLayout();
            this.GroupBoxListeLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxAjoutLieu
            // 
            this.GroupBoxAjoutLieu.Controls.Add(this.ButtonAjoutLieux);
            this.GroupBoxAjoutLieu.Controls.Add(this.textBoxTelephone);
            this.GroupBoxAjoutLieu.Controls.Add(this.textBoxCodePostal);
            this.GroupBoxAjoutLieu.Controls.Add(this.textBoxLibelle);
            this.GroupBoxAjoutLieu.Controls.Add(this.telePhone);
            this.GroupBoxAjoutLieu.Controls.Add(this.codePostal);
            this.GroupBoxAjoutLieu.Controls.Add(this.libelle);
            resources.ApplyResources(this.GroupBoxAjoutLieu, "GroupBoxAjoutLieu");
            this.GroupBoxAjoutLieu.Name = "GroupBoxAjoutLieu";
            this.GroupBoxAjoutLieu.TabStop = false;
            this.GroupBoxAjoutLieu.Enter += new System.EventHandler(this.GroupBoxAjoutLieu_Enter);
            // 
            // ButtonAjoutLieux
            // 
            resources.ApplyResources(this.ButtonAjoutLieux, "ButtonAjoutLieux");
            this.ButtonAjoutLieux.Name = "ButtonAjoutLieux";
            this.ButtonAjoutLieux.UseVisualStyleBackColor = true;
            this.ButtonAjoutLieux.Click += new System.EventHandler(this.ButtonAjoutLieux_Click);
            // 
            // textBoxTelephone
            // 
            resources.ApplyResources(this.textBoxTelephone, "textBoxTelephone");
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCodePostal
            // 
            resources.ApplyResources(this.textBoxCodePostal, "textBoxCodePostal");
            this.textBoxCodePostal.Name = "textBoxCodePostal";
            // 
            // textBoxLibelle
            // 
            resources.ApplyResources(this.textBoxLibelle, "textBoxLibelle");
            this.textBoxLibelle.Name = "textBoxLibelle";
            // 
            // telePhone
            // 
            resources.ApplyResources(this.telePhone, "telePhone");
            this.telePhone.Name = "telePhone";
            // 
            // codePostal
            // 
            resources.ApplyResources(this.codePostal, "codePostal");
            this.codePostal.Name = "codePostal";
            // 
            // libelle
            // 
            resources.ApplyResources(this.libelle, "libelle");
            this.libelle.Name = "libelle";
            this.libelle.Click += new System.EventHandler(this.libelle_Click);
            // 
            // GroupBoxListeLieu
            // 
            this.GroupBoxListeLieu.Controls.Add(this.dataGridViewListeLieu);
            resources.ApplyResources(this.GroupBoxListeLieu, "GroupBoxListeLieu");
            this.GroupBoxListeLieu.Name = "GroupBoxListeLieu";
            this.GroupBoxListeLieu.TabStop = false;
            // 
            // dataGridViewListeLieu
            // 
            this.dataGridViewListeLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewListeLieu, "dataGridViewListeLieu");
            this.dataGridViewListeLieu.Name = "dataGridViewListeLieu";
            this.dataGridViewListeLieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListeLieu1_CellContentClick_1);
            // 
            // FormGestionLieux
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.GroupBoxListeLieu);
            this.Controls.Add(this.GroupBoxAjoutLieu);
            this.Name = "FormGestionLieux";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFenetrePrincipale_FormClosing);
            this.Load += new System.EventHandler(this.FormGestionLieux_Load_1);
            this.GroupBoxAjoutLieu.ResumeLayout(false);
            this.GroupBoxAjoutLieu.PerformLayout();
            this.GroupBoxListeLieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxAjoutLieu;
        private System.Windows.Forms.GroupBox GroupBoxListeLieu;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxCodePostal;
        private System.Windows.Forms.TextBox textBoxLibelle;
        private System.Windows.Forms.Label telePhone;
        private System.Windows.Forms.Label codePostal;
        private System.Windows.Forms.Label libelle;
        private System.Windows.Forms.Button ButtonAjoutLieux;
        private System.Windows.Forms.DataGridView dataGridViewListeLieu;
    }
}