
namespace FormationSNCF.Vues
{
    partial class FormGestionActionFormation
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
            this.comboBoxListeActivit = new System.Windows.Forms.ComboBox();
            this.groupBoxListeActivit = new System.Windows.Forms.GroupBox();
            this.labelActivit = new System.Windows.Forms.Label();
            this.groupBoxIntituleActionFormation = new System.Windows.Forms.GroupBox();
            this.textBoxIntituleActionDeFormation = new System.Windows.Forms.TextBox();
            this.labelIntituleDeAction = new System.Windows.Forms.Label();
            this.textBoxCodeAction = new System.Windows.Forms.TextBox();
            this.textBoxDateCreation = new System.Windows.Forms.TextBox();
            this.textBoxDureeAction = new System.Windows.Forms.TextBox();
            this.textBoxCoutAction = new System.Windows.Forms.TextBox();
            this.buttonAjoutActionFormation = new System.Windows.Forms.Button();
            this.labelCodeAction = new System.Windows.Forms.Label();
            this.labelDateCreation = new System.Windows.Forms.Label();
            this.labelDureeAction = new System.Windows.Forms.Label();
            this.labelCoutAction = new System.Windows.Forms.Label();
            this.groupBoxListActionActivit = new System.Windows.Forms.GroupBox();
            this.dataGridViewActionFormation = new System.Windows.Forms.DataGridView();
            this.groupBoxListeActivit.SuspendLayout();
            this.groupBoxIntituleActionFormation.SuspendLayout();
            this.groupBoxListActionActivit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActionFormation)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxListeActivit
            // 
            this.comboBoxListeActivit.FormattingEnabled = true;
            this.comboBoxListeActivit.Location = new System.Drawing.Point(242, 43);
            this.comboBoxListeActivit.Name = "comboBoxListeActivit";
            this.comboBoxListeActivit.Size = new System.Drawing.Size(193, 21);
            this.comboBoxListeActivit.TabIndex = 0;
            this.comboBoxListeActivit.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeActivit_SelectedIndexChanged);
            // 
            // groupBoxListeActivit
            // 
            this.groupBoxListeActivit.Controls.Add(this.labelActivit);
            this.groupBoxListeActivit.Controls.Add(this.comboBoxListeActivit);
            this.groupBoxListeActivit.Location = new System.Drawing.Point(37, 23);
            this.groupBoxListeActivit.Name = "groupBoxListeActivit";
            this.groupBoxListeActivit.Size = new System.Drawing.Size(727, 99);
            this.groupBoxListeActivit.TabIndex = 1;
            this.groupBoxListeActivit.TabStop = false;
            this.groupBoxListeActivit.Text = "Liste des activités";
            // 
            // labelActivit
            // 
            this.labelActivit.AutoSize = true;
            this.labelActivit.Location = new System.Drawing.Point(23, 43);
            this.labelActivit.Name = "labelActivit";
            this.labelActivit.Size = new System.Drawing.Size(126, 13);
            this.labelActivit.TabIndex = 1;
            this.labelActivit.Text = "Sélectionnez une activité";
            // 
            // groupBoxIntituleActionFormation
            // 
            this.groupBoxIntituleActionFormation.Controls.Add(this.labelCoutAction);
            this.groupBoxIntituleActionFormation.Controls.Add(this.labelDureeAction);
            this.groupBoxIntituleActionFormation.Controls.Add(this.labelDateCreation);
            this.groupBoxIntituleActionFormation.Controls.Add(this.labelCodeAction);
            this.groupBoxIntituleActionFormation.Controls.Add(this.buttonAjoutActionFormation);
            this.groupBoxIntituleActionFormation.Controls.Add(this.textBoxCoutAction);
            this.groupBoxIntituleActionFormation.Controls.Add(this.textBoxDureeAction);
            this.groupBoxIntituleActionFormation.Controls.Add(this.textBoxDateCreation);
            this.groupBoxIntituleActionFormation.Controls.Add(this.textBoxCodeAction);
            this.groupBoxIntituleActionFormation.Controls.Add(this.labelIntituleDeAction);
            this.groupBoxIntituleActionFormation.Controls.Add(this.textBoxIntituleActionDeFormation);
            this.groupBoxIntituleActionFormation.Location = new System.Drawing.Point(37, 145);
            this.groupBoxIntituleActionFormation.Name = "groupBoxIntituleActionFormation";
            this.groupBoxIntituleActionFormation.Size = new System.Drawing.Size(727, 105);
            this.groupBoxIntituleActionFormation.TabIndex = 2;
            this.groupBoxIntituleActionFormation.TabStop = false;
            this.groupBoxIntituleActionFormation.Text = "Action de l\'activité";
            // 
            // textBoxIntituleActionDeFormation
            // 
            this.textBoxIntituleActionDeFormation.Location = new System.Drawing.Point(307, 24);
            this.textBoxIntituleActionDeFormation.Name = "textBoxIntituleActionDeFormation";
            this.textBoxIntituleActionDeFormation.Size = new System.Drawing.Size(372, 20);
            this.textBoxIntituleActionDeFormation.TabIndex = 0;
            // 
            // labelIntituleDeAction
            // 
            this.labelIntituleDeAction.AutoSize = true;
            this.labelIntituleDeAction.Location = new System.Drawing.Point(60, 24);
            this.labelIntituleDeAction.Name = "labelIntituleDeAction";
            this.labelIntituleDeAction.Size = new System.Drawing.Size(89, 13);
            this.labelIntituleDeAction.TabIndex = 1;
            this.labelIntituleDeAction.Text = "Intitulé de l\'action";
            // 
            // textBoxCodeAction
            // 
            this.textBoxCodeAction.Location = new System.Drawing.Point(63, 78);
            this.textBoxCodeAction.Name = "textBoxCodeAction";
            this.textBoxCodeAction.Size = new System.Drawing.Size(66, 20);
            this.textBoxCodeAction.TabIndex = 2;
            // 
            // textBoxDateCreation
            // 
            this.textBoxDateCreation.Location = new System.Drawing.Point(171, 78);
            this.textBoxDateCreation.Name = "textBoxDateCreation";
            this.textBoxDateCreation.Size = new System.Drawing.Size(75, 20);
            this.textBoxDateCreation.TabIndex = 3;
            // 
            // textBoxDureeAction
            // 
            this.textBoxDureeAction.Location = new System.Drawing.Point(283, 78);
            this.textBoxDureeAction.Name = "textBoxDureeAction";
            this.textBoxDureeAction.Size = new System.Drawing.Size(65, 20);
            this.textBoxDureeAction.TabIndex = 4;
            // 
            // textBoxCoutAction
            // 
            this.textBoxCoutAction.Location = new System.Drawing.Point(385, 78);
            this.textBoxCoutAction.Name = "textBoxCoutAction";
            this.textBoxCoutAction.Size = new System.Drawing.Size(93, 20);
            this.textBoxCoutAction.TabIndex = 5;
            // 
            // buttonAjoutActionFormation
            // 
            this.buttonAjoutActionFormation.Location = new System.Drawing.Point(506, 75);
            this.buttonAjoutActionFormation.Name = "buttonAjoutActionFormation";
            this.buttonAjoutActionFormation.Size = new System.Drawing.Size(173, 23);
            this.buttonAjoutActionFormation.TabIndex = 6;
            this.buttonAjoutActionFormation.Text = "Ajout d\'une action de formation";
            this.buttonAjoutActionFormation.UseVisualStyleBackColor = true;
            this.buttonAjoutActionFormation.Click += new System.EventHandler(this.buttonAjoutActionFormation_Click);
            // 
            // labelCodeAction
            // 
            this.labelCodeAction.AutoSize = true;
            this.labelCodeAction.Location = new System.Drawing.Point(60, 60);
            this.labelCodeAction.Name = "labelCodeAction";
            this.labelCodeAction.Size = new System.Drawing.Size(32, 13);
            this.labelCodeAction.TabIndex = 7;
            this.labelCodeAction.Text = "Code";
            // 
            // labelDateCreation
            // 
            this.labelDateCreation.AutoSize = true;
            this.labelDateCreation.Location = new System.Drawing.Point(168, 60);
            this.labelDateCreation.Name = "labelDateCreation";
            this.labelDateCreation.Size = new System.Drawing.Size(30, 13);
            this.labelDateCreation.TabIndex = 8;
            this.labelDateCreation.Text = "Date";
            // 
            // labelDureeAction
            // 
            this.labelDureeAction.AutoSize = true;
            this.labelDureeAction.Location = new System.Drawing.Point(280, 60);
            this.labelDureeAction.Name = "labelDureeAction";
            this.labelDureeAction.Size = new System.Drawing.Size(36, 13);
            this.labelDureeAction.TabIndex = 9;
            this.labelDureeAction.Text = "Durée";
            // 
            // labelCoutAction
            // 
            this.labelCoutAction.AutoSize = true;
            this.labelCoutAction.Location = new System.Drawing.Point(382, 60);
            this.labelCoutAction.Name = "labelCoutAction";
            this.labelCoutAction.Size = new System.Drawing.Size(29, 13);
            this.labelCoutAction.TabIndex = 10;
            this.labelCoutAction.Text = "Cout";
            // 
            // groupBoxListActionActivit
            // 
            this.groupBoxListActionActivit.Controls.Add(this.dataGridViewActionFormation);
            this.groupBoxListActionActivit.Location = new System.Drawing.Point(37, 280);
            this.groupBoxListActionActivit.Name = "groupBoxListActionActivit";
            this.groupBoxListActionActivit.Size = new System.Drawing.Size(727, 291);
            this.groupBoxListActionActivit.TabIndex = 3;
            this.groupBoxListActionActivit.TabStop = false;
            this.groupBoxListActionActivit.Text = "Liste des actions de formations de l\'activité sélectionnée";
            // 
            // dataGridViewActionFormation
            // 
            this.dataGridViewActionFormation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActionFormation.Location = new System.Drawing.Point(26, 29);
            this.dataGridViewActionFormation.Name = "dataGridViewActionFormation";
            this.dataGridViewActionFormation.Size = new System.Drawing.Size(672, 235);
            this.dataGridViewActionFormation.TabIndex = 0;
            // 
            // FormGestionActionFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 740);
            this.Controls.Add(this.groupBoxListActionActivit);
            this.Controls.Add(this.groupBoxIntituleActionFormation);
            this.Controls.Add(this.groupBoxListeActivit);
            this.Name = "FormGestionActionFormation";
            this.Text = "FormGestionActionFormation";
            this.Load += new System.EventHandler(this.FormGestionActionFormation_Load);
            this.groupBoxListeActivit.ResumeLayout(false);
            this.groupBoxListeActivit.PerformLayout();
            this.groupBoxIntituleActionFormation.ResumeLayout(false);
            this.groupBoxIntituleActionFormation.PerformLayout();
            this.groupBoxListActionActivit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActionFormation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxListeActivit;
        private System.Windows.Forms.GroupBox groupBoxListeActivit;
        private System.Windows.Forms.Label labelActivit;
        private System.Windows.Forms.GroupBox groupBoxIntituleActionFormation;
        private System.Windows.Forms.Label labelCoutAction;
        private System.Windows.Forms.Label labelDureeAction;
        private System.Windows.Forms.Label labelDateCreation;
        private System.Windows.Forms.Label labelCodeAction;
        private System.Windows.Forms.Button buttonAjoutActionFormation;
        private System.Windows.Forms.TextBox textBoxCoutAction;
        private System.Windows.Forms.TextBox textBoxDureeAction;
        private System.Windows.Forms.TextBox textBoxDateCreation;
        private System.Windows.Forms.TextBox textBoxCodeAction;
        private System.Windows.Forms.Label labelIntituleDeAction;
        private System.Windows.Forms.TextBox textBoxIntituleActionDeFormation;
        private System.Windows.Forms.GroupBox groupBoxListActionActivit;
        private System.Windows.Forms.DataGridView dataGridViewActionFormation;
    }
}