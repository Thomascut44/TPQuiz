namespace TPQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.cbb_difficulte = new System.Windows.Forms.ComboBox();
            this.btn_ferme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(385, 343);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(241, 70);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 3;
            this.lbl_nom.Text = "Nom :";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(227, 102);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenom.TabIndex = 4;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(305, 67);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(195, 20);
            this.txt_nom.TabIndex = 5;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(305, 102);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(195, 20);
            this.txt_prenom.TabIndex = 6;
            // 
            // lbl_difficulte
            // 
            this.lbl_difficulte.AutoSize = true;
            this.lbl_difficulte.Location = new System.Drawing.Point(222, 224);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(54, 13);
            this.lbl_difficulte.TabIndex = 7;
            this.lbl_difficulte.Text = "Difficulté :";
            // 
            // cbb_difficulte
            // 
            this.cbb_difficulte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_difficulte.FormattingEnabled = true;
            this.cbb_difficulte.Location = new System.Drawing.Point(305, 221);
            this.cbb_difficulte.Name = "cbb_difficulte";
            this.cbb_difficulte.Size = new System.Drawing.Size(195, 21);
            this.cbb_difficulte.TabIndex = 8;
            this.cbb_difficulte.SelectedIndexChanged += new System.EventHandler(this.cbb_difficulte_SelectedIndexChanged);
            // 
            // btn_ferme
            // 
            this.btn_ferme.Location = new System.Drawing.Point(743, 12);
            this.btn_ferme.Name = "btn_ferme";
            this.btn_ferme.Size = new System.Drawing.Size(29, 23);
            this.btn_ferme.TabIndex = 9;
            this.btn_ferme.Text = "X";
            this.btn_ferme.UseVisualStyleBackColor = true;
            this.btn_ferme.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 387);
            this.Controls.Add(this.btn_ferme);
            this.Controls.Add(this.cbb_difficulte);
            this.Controls.Add(this.lbl_difficulte);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.btn_valider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label lbl_difficulte;
        private System.Windows.Forms.ComboBox cbb_difficulte;
        private System.Windows.Forms.Button btn_ferme;
    }
}

