﻿using FormationSNCF.Modele;
using FormationSNCF.Ressources;

namespace FormationSNCF.Vues
{
    partial class FormFenetrePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFenetrePrincipale));
            this.menuPrincipalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.lieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesLieuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONACTIVITEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesActiviteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipalMenuStrip
            // 
            this.menuPrincipalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lieuToolStripMenuItem,
            this.gESTIONACTIVITEToolStripMenuItem});
            this.menuPrincipalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipalMenuStrip.Name = "menuPrincipalMenuStrip";
            this.menuPrincipalMenuStrip.Size = new System.Drawing.Size(815, 24);
            this.menuPrincipalMenuStrip.TabIndex = 1;
            this.menuPrincipalMenuStrip.Text = "menuStrip1";
            this.menuPrincipalMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // lieuToolStripMenuItem
            // 
            this.lieuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesLieuxToolStripMenuItem});
            this.lieuToolStripMenuItem.Name = "lieuToolStripMenuItem";
            this.lieuToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.lieuToolStripMenuItem.Text = "LIEUX";
            this.lieuToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalMenuStripToolStripMenuItem_Click);
            // 
            // gestionDesLieuxToolStripMenuItem
            // 
            this.gestionDesLieuxToolStripMenuItem.Name = "gestionDesLieuxToolStripMenuItem";
            this.gestionDesLieuxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDesLieuxToolStripMenuItem.Text = "GESTION DES LIEUX";
            this.gestionDesLieuxToolStripMenuItem.Click += new System.EventHandler(this.gestionDesLieuxToolStripMenuItem_Click_1);
            // 
            // gESTIONACTIVITEToolStripMenuItem
            // 
            this.gESTIONACTIVITEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesActiviteToolStripMenuItem});
            this.gESTIONACTIVITEToolStripMenuItem.Name = "gESTIONACTIVITEToolStripMenuItem";
            this.gESTIONACTIVITEToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.gESTIONACTIVITEToolStripMenuItem.Text = "ACTIVITE";
            this.gESTIONACTIVITEToolStripMenuItem.Click += new System.EventHandler(this.gESTIONACTIVITEToolStripMenuItem_Click);
            // 
            // gestionDesActiviteToolStripMenuItem
            // 
            this.gestionDesActiviteToolStripMenuItem.Name = "gestionDesActiviteToolStripMenuItem";
            this.gestionDesActiviteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.gestionDesActiviteToolStripMenuItem.Text = "GESTION DES ACTIVITE";
            this.gestionDesActiviteToolStripMenuItem.Click += new System.EventHandler(this.gestionDesActiviteToolStripMenuItem_Click);
            // 
            // FormFenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.menuPrincipalMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipalMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFenetrePrincipale";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormationSNCF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipalMenuStrip.ResumeLayout(false);
            this.menuPrincipalMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem lieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesLieuxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONACTIVITEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesActiviteToolStripMenuItem;
    }
}