namespace App
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbContenu = new System.Windows.Forms.GroupBox();
            this.btnAjouterUtil = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnNouvelEmprunt = new System.Windows.Forms.Button();
            this.tabCtrlListes = new System.Windows.Forms.TabControl();
            this.tabUtils = new System.Windows.Forms.TabPage();
            this.dgvUtils = new System.Windows.Forms.DataGridView();
            this.colUtilId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUtilNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUtilPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabLivres = new System.Windows.Forms.TabPage();
            this.dgvLivres = new System.Windows.Forms.DataGridView();
            this.colLivreIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLivreTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLivreAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEmprunts = new System.Windows.Forms.TabPage();
            this.dgvEmprunts = new System.Windows.Forms.DataGridView();
            this.colEmpruntDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpruntUtil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpruntLivre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpruntRendu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAjouterLivre = new System.Windows.Forms.Button();
            this.gbContenu.SuspendLayout();
            this.tabCtrlListes.SuspendLayout();
            this.tabUtils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtils)).BeginInit();
            this.tabLivres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).BeginInit();
            this.tabEmprunts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprunts)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContenu
            // 
            this.gbContenu.Controls.Add(this.btnAjouterUtil);
            this.gbContenu.Controls.Add(this.btnRetour);
            this.gbContenu.Controls.Add(this.btnNouvelEmprunt);
            this.gbContenu.Controls.Add(this.tabCtrlListes);
            this.gbContenu.Location = new System.Drawing.Point(17, 16);
            this.gbContenu.Name = "gbContenu";
            this.gbContenu.Size = new System.Drawing.Size(669, 306);
            this.gbContenu.TabIndex = 0;
            this.gbContenu.TabStop = false;
            this.gbContenu.Text = "Contenu de la bibliothèque";
            // 
            // btnAjouterUtil
            // 
            this.btnAjouterUtil.Location = new System.Drawing.Point(545, 177);
            this.btnAjouterUtil.Name = "btnAjouterUtil";
            this.btnAjouterUtil.Size = new System.Drawing.Size(109, 47);
            this.btnAjouterUtil.TabIndex = 3;
            this.btnAjouterUtil.Text = "Ajouter un utilisateur";
            this.btnAjouterUtil.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(545, 108);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(109, 47);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Enregistrer un retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnNouvelEmprunt
            // 
            this.btnNouvelEmprunt.Location = new System.Drawing.Point(545, 41);
            this.btnNouvelEmprunt.Name = "btnNouvelEmprunt";
            this.btnNouvelEmprunt.Size = new System.Drawing.Size(109, 47);
            this.btnNouvelEmprunt.TabIndex = 1;
            this.btnNouvelEmprunt.Text = "Ajouter un nouvel emprunt";
            this.btnNouvelEmprunt.UseVisualStyleBackColor = true;
            this.btnNouvelEmprunt.Click += new System.EventHandler(this.btnNouvelEmprunt_Click);
            // 
            // tabCtrlListes
            // 
            this.tabCtrlListes.Controls.Add(this.tabUtils);
            this.tabCtrlListes.Controls.Add(this.tabLivres);
            this.tabCtrlListes.Controls.Add(this.tabEmprunts);
            this.tabCtrlListes.Location = new System.Drawing.Point(6, 19);
            this.tabCtrlListes.Name = "tabCtrlListes";
            this.tabCtrlListes.SelectedIndex = 0;
            this.tabCtrlListes.Size = new System.Drawing.Size(522, 271);
            this.tabCtrlListes.TabIndex = 0;
            // 
            // tabUtils
            // 
            this.tabUtils.Controls.Add(this.dgvUtils);
            this.tabUtils.Location = new System.Drawing.Point(4, 22);
            this.tabUtils.Name = "tabUtils";
            this.tabUtils.Padding = new System.Windows.Forms.Padding(3);
            this.tabUtils.Size = new System.Drawing.Size(514, 245);
            this.tabUtils.TabIndex = 0;
            this.tabUtils.Text = "Utilisateurs";
            this.tabUtils.UseVisualStyleBackColor = true;
            // 
            // dgvUtils
            // 
            this.dgvUtils.AllowUserToAddRows = false;
            this.dgvUtils.AllowUserToDeleteRows = false;
            this.dgvUtils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUtilId,
            this.colUtilNom,
            this.colUtilPrenom});
            this.dgvUtils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUtils.Location = new System.Drawing.Point(3, 3);
            this.dgvUtils.Name = "dgvUtils";
            this.dgvUtils.ReadOnly = true;
            this.dgvUtils.Size = new System.Drawing.Size(508, 239);
            this.dgvUtils.TabIndex = 0;
            // 
            // colUtilId
            // 
            this.colUtilId.Frozen = true;
            this.colUtilId.HeaderText = "Identifiant";
            this.colUtilId.Name = "colUtilId";
            this.colUtilId.ReadOnly = true;
            // 
            // colUtilNom
            // 
            this.colUtilNom.Frozen = true;
            this.colUtilNom.HeaderText = "Nom";
            this.colUtilNom.Name = "colUtilNom";
            this.colUtilNom.ReadOnly = true;
            // 
            // colUtilPrenom
            // 
            this.colUtilPrenom.Frozen = true;
            this.colUtilPrenom.HeaderText = "Prénom";
            this.colUtilPrenom.Name = "colUtilPrenom";
            this.colUtilPrenom.ReadOnly = true;
            // 
            // tabLivres
            // 
            this.tabLivres.Controls.Add(this.dgvLivres);
            this.tabLivres.Location = new System.Drawing.Point(4, 22);
            this.tabLivres.Name = "tabLivres";
            this.tabLivres.Padding = new System.Windows.Forms.Padding(3);
            this.tabLivres.Size = new System.Drawing.Size(514, 245);
            this.tabLivres.TabIndex = 1;
            this.tabLivres.Text = "Livres";
            this.tabLivres.UseVisualStyleBackColor = true;
            // 
            // dgvLivres
            // 
            this.dgvLivres.AllowUserToAddRows = false;
            this.dgvLivres.AllowUserToDeleteRows = false;
            this.dgvLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLivreIsbn,
            this.colLivreTitre,
            this.colLivreAuteur});
            this.dgvLivres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLivres.Location = new System.Drawing.Point(3, 3);
            this.dgvLivres.Name = "dgvLivres";
            this.dgvLivres.ReadOnly = true;
            this.dgvLivres.Size = new System.Drawing.Size(508, 239);
            this.dgvLivres.TabIndex = 0;
            // 
            // colLivreIsbn
            // 
            this.colLivreIsbn.Frozen = true;
            this.colLivreIsbn.HeaderText = "ISBN";
            this.colLivreIsbn.Name = "colLivreIsbn";
            this.colLivreIsbn.ReadOnly = true;
            // 
            // colLivreTitre
            // 
            this.colLivreTitre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLivreTitre.Frozen = true;
            this.colLivreTitre.HeaderText = "Titre";
            this.colLivreTitre.MinimumWidth = 100;
            this.colLivreTitre.Name = "colLivreTitre";
            this.colLivreTitre.ReadOnly = true;
            // 
            // colLivreAuteur
            // 
            this.colLivreAuteur.Frozen = true;
            this.colLivreAuteur.HeaderText = "Auteur";
            this.colLivreAuteur.Name = "colLivreAuteur";
            this.colLivreAuteur.ReadOnly = true;
            // 
            // tabEmprunts
            // 
            this.tabEmprunts.Controls.Add(this.dgvEmprunts);
            this.tabEmprunts.Location = new System.Drawing.Point(4, 22);
            this.tabEmprunts.Name = "tabEmprunts";
            this.tabEmprunts.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmprunts.Size = new System.Drawing.Size(514, 245);
            this.tabEmprunts.TabIndex = 2;
            this.tabEmprunts.Text = "Emprunts";
            this.tabEmprunts.UseVisualStyleBackColor = true;
            // 
            // dgvEmprunts
            // 
            this.dgvEmprunts.AllowUserToAddRows = false;
            this.dgvEmprunts.AllowUserToDeleteRows = false;
            this.dgvEmprunts.ColumnHeadersHeight = 21;
            this.dgvEmprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmprunts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpruntDate,
            this.colEmpruntUtil,
            this.colEmpruntLivre,
            this.colEmpruntRendu});
            this.dgvEmprunts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmprunts.Location = new System.Drawing.Point(3, 3);
            this.dgvEmprunts.Name = "dgvEmprunts";
            this.dgvEmprunts.ReadOnly = true;
            this.dgvEmprunts.Size = new System.Drawing.Size(508, 239);
            this.dgvEmprunts.TabIndex = 0;
            // 
            // colEmpruntDate
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.colEmpruntDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colEmpruntDate.Frozen = true;
            this.colEmpruntDate.HeaderText = "Date de l\'emprunt";
            this.colEmpruntDate.Name = "colEmpruntDate";
            this.colEmpruntDate.ReadOnly = true;
            this.colEmpruntDate.Width = 120;
            // 
            // colEmpruntUtil
            // 
            this.colEmpruntUtil.Frozen = true;
            this.colEmpruntUtil.HeaderText = "Emprunteur";
            this.colEmpruntUtil.Name = "colEmpruntUtil";
            this.colEmpruntUtil.ReadOnly = true;
            // 
            // colEmpruntLivre
            // 
            this.colEmpruntLivre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEmpruntLivre.Frozen = true;
            this.colEmpruntLivre.HeaderText = "Livre";
            this.colEmpruntLivre.MinimumWidth = 100;
            this.colEmpruntLivre.Name = "colEmpruntLivre";
            this.colEmpruntLivre.ReadOnly = true;
            // 
            // colEmpruntRendu
            // 
            this.colEmpruntRendu.Frozen = true;
            this.colEmpruntRendu.HeaderText = "Rendu ?";
            this.colEmpruntRendu.Name = "colEmpruntRendu";
            this.colEmpruntRendu.ReadOnly = true;
            this.colEmpruntRendu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEmpruntRendu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEmpruntRendu.Width = 60;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(305, 338);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(89, 33);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAjouterLivre
            // 
            this.btnAjouterLivre.Location = new System.Drawing.Point(562, 259);
            this.btnAjouterLivre.Name = "btnAjouterLivre";
            this.btnAjouterLivre.Size = new System.Drawing.Size(109, 47);
            this.btnAjouterLivre.TabIndex = 4;
            this.btnAjouterLivre.Text = "Ajouter un livre";
            this.btnAjouterLivre.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 384);
            this.Controls.Add(this.btnAjouterLivre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.gbContenu);
            this.Name = "MainForm";
            this.Text = "Bibliothèque";
            this.gbContenu.ResumeLayout(false);
            this.tabCtrlListes.ResumeLayout(false);
            this.tabUtils.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtils)).EndInit();
            this.tabLivres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).EndInit();
            this.tabEmprunts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprunts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContenu;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TabControl tabCtrlListes;
        private System.Windows.Forms.TabPage tabUtils;
        private System.Windows.Forms.DataGridView dgvUtils;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUtilId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUtilNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUtilPrenom;
        private System.Windows.Forms.TabPage tabLivres;
        private System.Windows.Forms.DataGridView dgvLivres;
        private System.Windows.Forms.TabPage tabEmprunts;
        private System.Windows.Forms.DataGridView dgvEmprunts;
        private System.Windows.Forms.Button btnNouvelEmprunt;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLivreIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLivreTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLivreAuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpruntDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpruntUtil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpruntLivre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEmpruntRendu;
        private System.Windows.Forms.Button btnAjouterUtil;
        private System.Windows.Forms.Button btnAjouterLivre;
    }
}