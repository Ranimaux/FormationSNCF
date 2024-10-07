namespace FormationSNCF.Vues
{
    partial class FormGestionSessionDeFormation
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
            this.groupBoxActiviteSession = new System.Windows.Forms.GroupBox();
            this.comboBoxListActivite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxActionActivite = new System.Windows.Forms.GroupBox();
            this.buttonAddSession = new System.Windows.Forms.Button();
            this.comboBoxListLieu = new System.Windows.Forms.ComboBox();
            this.textBoxCoutSession = new System.Windows.Forms.TextBox();
            this.textBoxDureeSession = new System.Windows.Forms.TextBox();
            this.textBoxCodeSession = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxListActionFormation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxListSession = new System.Windows.Forms.GroupBox();
            this.dataGridViewListSession = new System.Windows.Forms.DataGridView();
            this.groupBoxActiviteSession.SuspendLayout();
            this.groupBoxActionActivite.SuspendLayout();
            this.groupBoxListSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListSession)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxActiviteSession
            // 
            this.groupBoxActiviteSession.Controls.Add(this.comboBoxListActivite);
            this.groupBoxActiviteSession.Controls.Add(this.label1);
            this.groupBoxActiviteSession.Location = new System.Drawing.Point(44, 39);
            this.groupBoxActiviteSession.Name = "groupBoxActiviteSession";
            this.groupBoxActiviteSession.Size = new System.Drawing.Size(1080, 134);
            this.groupBoxActiviteSession.TabIndex = 0;
            this.groupBoxActiviteSession.TabStop = false;
            this.groupBoxActiviteSession.Text = "Activités";
            // 
            // comboBoxListActivite
            // 
            this.comboBoxListActivite.FormattingEnabled = true;
            this.comboBoxListActivite.Location = new System.Drawing.Point(369, 61);
            this.comboBoxListActivite.Name = "comboBoxListActivite";
            this.comboBoxListActivite.Size = new System.Drawing.Size(276, 21);
            this.comboBoxListActivite.TabIndex = 1;
            this.comboBoxListActivite.SelectedIndexChanged += new System.EventHandler(this.comboBoxListActivite_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sélectionnez une activitée";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxActionActivite
            // 
            this.groupBoxActionActivite.Controls.Add(this.buttonAddSession);
            this.groupBoxActionActivite.Controls.Add(this.comboBoxListLieu);
            this.groupBoxActionActivite.Controls.Add(this.textBoxCoutSession);
            this.groupBoxActionActivite.Controls.Add(this.textBoxDureeSession);
            this.groupBoxActionActivite.Controls.Add(this.textBoxCodeSession);
            this.groupBoxActionActivite.Controls.Add(this.label6);
            this.groupBoxActionActivite.Controls.Add(this.label5);
            this.groupBoxActionActivite.Controls.Add(this.label4);
            this.groupBoxActionActivite.Controls.Add(this.label3);
            this.groupBoxActionActivite.Controls.Add(this.comboBoxListActionFormation);
            this.groupBoxActionActivite.Controls.Add(this.label2);
            this.groupBoxActionActivite.Location = new System.Drawing.Point(44, 199);
            this.groupBoxActionActivite.Name = "groupBoxActionActivite";
            this.groupBoxActionActivite.Size = new System.Drawing.Size(1080, 196);
            this.groupBoxActionActivite.TabIndex = 1;
            this.groupBoxActionActivite.TabStop = false;
            this.groupBoxActionActivite.Text = "Action de l\'activité";
            // 
            // buttonAddSession
            // 
            this.buttonAddSession.Location = new System.Drawing.Point(468, 167);
            this.buttonAddSession.Name = "buttonAddSession";
            this.buttonAddSession.Size = new System.Drawing.Size(121, 23);
            this.buttonAddSession.TabIndex = 11;
            this.buttonAddSession.Text = "Ajouter une session";
            this.buttonAddSession.UseVisualStyleBackColor = true;
            // 
            // comboBoxListLieu
            // 
            this.comboBoxListLieu.FormattingEnabled = true;
            this.comboBoxListLieu.Location = new System.Drawing.Point(468, 86);
            this.comboBoxListLieu.Name = "comboBoxListLieu";
            this.comboBoxListLieu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListLieu.TabIndex = 10;
            // 
            // textBoxCoutSession
            // 
            this.textBoxCoutSession.Location = new System.Drawing.Point(468, 120);
            this.textBoxCoutSession.Name = "textBoxCoutSession";
            this.textBoxCoutSession.Size = new System.Drawing.Size(121, 20);
            this.textBoxCoutSession.TabIndex = 9;
            // 
            // textBoxDureeSession
            // 
            this.textBoxDureeSession.Location = new System.Drawing.Point(147, 123);
            this.textBoxDureeSession.Name = "textBoxDureeSession";
            this.textBoxDureeSession.Size = new System.Drawing.Size(113, 20);
            this.textBoxDureeSession.TabIndex = 7;
            // 
            // textBoxCodeSession
            // 
            this.textBoxCodeSession.Location = new System.Drawing.Point(147, 89);
            this.textBoxCodeSession.Name = "textBoxCodeSession";
            this.textBoxCodeSession.Size = new System.Drawing.Size(113, 20);
            this.textBoxCodeSession.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Coût";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de création";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code";
            // 
            // comboBoxListActionFormation
            // 
            this.comboBoxListActionFormation.FormattingEnabled = true;
            this.comboBoxListActionFormation.Location = new System.Drawing.Point(369, 40);
            this.comboBoxListActionFormation.Name = "comboBoxListActionFormation";
            this.comboBoxListActionFormation.Size = new System.Drawing.Size(276, 21);
            this.comboBoxListActionFormation.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sélectionnez une action de formation";
            // 
            // groupBoxListSession
            // 
            this.groupBoxListSession.Controls.Add(this.dataGridViewListSession);
            this.groupBoxListSession.Location = new System.Drawing.Point(44, 402);
            this.groupBoxListSession.Name = "groupBoxListSession";
            this.groupBoxListSession.Size = new System.Drawing.Size(1080, 255);
            this.groupBoxListSession.TabIndex = 2;
            this.groupBoxListSession.TabStop = false;
            this.groupBoxListSession.Text = "Liste des sessions de formation";
            // 
            // dataGridViewListSession
            // 
            this.dataGridViewListSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListSession.Location = new System.Drawing.Point(23, 30);
            this.dataGridViewListSession.Name = "dataGridViewListSession";
            this.dataGridViewListSession.Size = new System.Drawing.Size(1041, 206);
            this.dataGridViewListSession.TabIndex = 0;
            // 
            // FormGestionSessionDeFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1186, 669);
            this.Controls.Add(this.groupBoxListSession);
            this.Controls.Add(this.groupBoxActionActivite);
            this.Controls.Add(this.groupBoxActiviteSession);
            this.Name = "FormGestionSessionDeFormation";
            this.Text = "FormGestionSessionDeFormation";
            this.Load += new System.EventHandler(this.FormGestionSessionDeFormation_Load);
            this.groupBoxActiviteSession.ResumeLayout(false);
            this.groupBoxActiviteSession.PerformLayout();
            this.groupBoxActionActivite.ResumeLayout(false);
            this.groupBoxActionActivite.PerformLayout();
            this.groupBoxListSession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListSession)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxActiviteSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxListActivite;
        private System.Windows.Forms.GroupBox groupBoxActionActivite;
        private System.Windows.Forms.Button buttonAddSession;
        private System.Windows.Forms.ComboBox comboBoxListLieu;
        private System.Windows.Forms.TextBox textBoxCoutSession;
        private System.Windows.Forms.TextBox textBoxDureeSession;
        private System.Windows.Forms.TextBox textBoxCodeSession;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxListActionFormation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxListSession;
        private System.Windows.Forms.DataGridView dataGridViewListSession;
    }
}