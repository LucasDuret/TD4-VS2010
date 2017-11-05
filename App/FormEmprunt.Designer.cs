namespace App
{
    partial class FormEmprunt
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
            this.btnEmprunter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gbUtil = new System.Windows.Forms.GroupBox();
            this.cbUtil = new System.Windows.Forms.ComboBox();
            this.gbLivre = new System.Windows.Forms.GroupBox();
            this.cbLivre = new System.Windows.Forms.ComboBox();
            this.gbUtil.SuspendLayout();
            this.gbLivre.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmprunter
            // 
            this.btnEmprunter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEmprunter.Location = new System.Drawing.Point(189, 194);
            this.btnEmprunter.Name = "btnEmprunter";
            this.btnEmprunter.Size = new System.Drawing.Size(84, 30);
            this.btnEmprunter.TabIndex = 4;
            this.btnEmprunter.Text = "Emprunter";
            this.btnEmprunter.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(72, 194);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(84, 30);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // gbUtil
            // 
            this.gbUtil.Controls.Add(this.cbUtil);
            this.gbUtil.Location = new System.Drawing.Point(12, 12);
            this.gbUtil.Name = "gbUtil";
            this.gbUtil.Size = new System.Drawing.Size(319, 73);
            this.gbUtil.TabIndex = 5;
            this.gbUtil.TabStop = false;
            this.gbUtil.Text = "Choisir l\'utilisateur emprunteur";
            // 
            // cbUtil
            // 
            this.cbUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUtil.FormattingEnabled = true;
            this.cbUtil.Location = new System.Drawing.Point(25, 33);
            this.cbUtil.Name = "cbUtil";
            this.cbUtil.Size = new System.Drawing.Size(272, 21);
            this.cbUtil.TabIndex = 0;
            // 
            // gbLivre
            // 
            this.gbLivre.Controls.Add(this.cbLivre);
            this.gbLivre.Location = new System.Drawing.Point(12, 103);
            this.gbLivre.Name = "gbLivre";
            this.gbLivre.Size = new System.Drawing.Size(319, 73);
            this.gbLivre.TabIndex = 6;
            this.gbLivre.TabStop = false;
            this.gbLivre.Text = "Choisir le livre emprunté";
            // 
            // cbLivre
            // 
            this.cbLivre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLivre.FormattingEnabled = true;
            this.cbLivre.Location = new System.Drawing.Point(25, 33);
            this.cbLivre.Name = "cbLivre";
            this.cbLivre.Size = new System.Drawing.Size(272, 21);
            this.cbLivre.TabIndex = 0;
            // 
            // DlgEmprunt
            // 
            this.AcceptButton = this.btnEmprunter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(345, 237);
            this.Controls.Add(this.gbLivre);
            this.Controls.Add(this.gbUtil);
            this.Controls.Add(this.btnEmprunter);
            this.Controls.Add(this.btnAnnuler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgEmprunt";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajout d\'un nouvel emprunt";
            this.gbUtil.ResumeLayout(false);
            this.gbLivre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmprunter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox gbUtil;
        private System.Windows.Forms.ComboBox cbUtil;
        private System.Windows.Forms.GroupBox gbLivre;
        private System.Windows.Forms.ComboBox cbLivre;
    }
}