namespace TPQuiz
{
    partial class jeu
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
            this.lbl_question = new System.Windows.Forms.Label();
            this.cbx_reponse1 = new System.Windows.Forms.CheckBox();
            this.cbx_reponse2 = new System.Windows.Forms.CheckBox();
            this.cbx_reponse3 = new System.Windows.Forms.CheckBox();
            this.cbx_reponse5 = new System.Windows.Forms.CheckBox();
            this.cbx_reponse4 = new System.Windows.Forms.CheckBox();
            this.gbx_reponse = new System.Windows.Forms.GroupBox();
            this.txt_affichage = new System.Windows.Forms.TextBox();
            this.txt_temps = new System.Windows.Forms.TextBox();
            this.pbx_image = new System.Windows.Forms.PictureBox();
            this.txt_titre = new System.Windows.Forms.Label();
            this.lbl_tpsTotal = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.pgb_tempscout = new System.Windows.Forms.ProgressBar();
            this.lbl_progressbar1 = new System.Windows.Forms.Label();
            this.lbl_joueur = new System.Windows.Forms.Label();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.txt_difficulte = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.btn_ferme = new System.Windows.Forms.Button();
            this.gbx_reponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(98, 68);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(55, 13);
            this.lbl_question.TabIndex = 0;
            this.lbl_question.Text = "Question1";
            // 
            // cbx_reponse1
            // 
            this.cbx_reponse1.AutoSize = true;
            this.cbx_reponse1.Location = new System.Drawing.Point(16, 19);
            this.cbx_reponse1.Name = "cbx_reponse1";
            this.cbx_reponse1.Size = new System.Drawing.Size(78, 17);
            this.cbx_reponse1.TabIndex = 1;
            this.cbx_reponse1.Text = "Réponse 1";
            this.cbx_reponse1.UseVisualStyleBackColor = true;
            this.cbx_reponse1.Click += new System.EventHandler(this.cbx_reponse1Clic);
            // 
            // cbx_reponse2
            // 
            this.cbx_reponse2.AutoSize = true;
            this.cbx_reponse2.Location = new System.Drawing.Point(16, 42);
            this.cbx_reponse2.Name = "cbx_reponse2";
            this.cbx_reponse2.Size = new System.Drawing.Size(78, 17);
            this.cbx_reponse2.TabIndex = 2;
            this.cbx_reponse2.Text = "Réponse 2";
            this.cbx_reponse2.UseVisualStyleBackColor = true;
            this.cbx_reponse2.Click += new System.EventHandler(this.cbx_reponse1Clic);
            // 
            // cbx_reponse3
            // 
            this.cbx_reponse3.AutoSize = true;
            this.cbx_reponse3.Location = new System.Drawing.Point(16, 65);
            this.cbx_reponse3.Name = "cbx_reponse3";
            this.cbx_reponse3.Size = new System.Drawing.Size(78, 17);
            this.cbx_reponse3.TabIndex = 3;
            this.cbx_reponse3.Text = "Réponse 3";
            this.cbx_reponse3.UseVisualStyleBackColor = true;
            this.cbx_reponse3.Click += new System.EventHandler(this.cbx_reponse1Clic);
            // 
            // cbx_reponse5
            // 
            this.cbx_reponse5.AutoSize = true;
            this.cbx_reponse5.Location = new System.Drawing.Point(16, 111);
            this.cbx_reponse5.Name = "cbx_reponse5";
            this.cbx_reponse5.Size = new System.Drawing.Size(78, 17);
            this.cbx_reponse5.TabIndex = 4;
            this.cbx_reponse5.Text = "Réponse 5";
            this.cbx_reponse5.UseVisualStyleBackColor = true;
            this.cbx_reponse5.Click += new System.EventHandler(this.cbx_reponse1Clic);
            // 
            // cbx_reponse4
            // 
            this.cbx_reponse4.AutoSize = true;
            this.cbx_reponse4.Location = new System.Drawing.Point(16, 88);
            this.cbx_reponse4.Name = "cbx_reponse4";
            this.cbx_reponse4.Size = new System.Drawing.Size(78, 17);
            this.cbx_reponse4.TabIndex = 5;
            this.cbx_reponse4.Text = "Réponse 4";
            this.cbx_reponse4.UseVisualStyleBackColor = true;
            this.cbx_reponse4.Click += new System.EventHandler(this.cbx_reponse1Clic);
            // 
            // gbx_reponse
            // 
            this.gbx_reponse.Controls.Add(this.cbx_reponse1);
            this.gbx_reponse.Controls.Add(this.cbx_reponse5);
            this.gbx_reponse.Controls.Add(this.cbx_reponse4);
            this.gbx_reponse.Controls.Add(this.cbx_reponse2);
            this.gbx_reponse.Controls.Add(this.cbx_reponse3);
            this.gbx_reponse.Location = new System.Drawing.Point(85, 148);
            this.gbx_reponse.Name = "gbx_reponse";
            this.gbx_reponse.Size = new System.Drawing.Size(479, 153);
            this.gbx_reponse.TabIndex = 6;
            this.gbx_reponse.TabStop = false;
            this.gbx_reponse.Text = "Réponses possibles";
            // 
            // txt_affichage
            // 
            this.txt_affichage.Enabled = false;
            this.txt_affichage.Location = new System.Drawing.Point(85, 84);
            this.txt_affichage.Multiline = true;
            this.txt_affichage.Name = "txt_affichage";
            this.txt_affichage.Size = new System.Drawing.Size(479, 45);
            this.txt_affichage.TabIndex = 7;
            // 
            // txt_temps
            // 
            this.txt_temps.Enabled = false;
            this.txt_temps.Location = new System.Drawing.Point(601, 51);
            this.txt_temps.Name = "txt_temps";
            this.txt_temps.Size = new System.Drawing.Size(145, 20);
            this.txt_temps.TabIndex = 8;
            // 
            // pbx_image
            // 
            this.pbx_image.Image = global::TPQuiz.Properties.Resources.Interrogation;
            this.pbx_image.Location = new System.Drawing.Point(601, 84);
            this.pbx_image.Name = "pbx_image";
            this.pbx_image.Size = new System.Drawing.Size(145, 138);
            this.pbx_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_image.TabIndex = 9;
            this.pbx_image.TabStop = false;
            // 
            // txt_titre
            // 
            this.txt_titre.AutoSize = true;
            this.txt_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titre.Location = new System.Drawing.Point(238, 9);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(254, 39);
            this.txt_titre.TabIndex = 10;
            this.txt_titre.Text = "Quizz And Test";
            // 
            // lbl_tpsTotal
            // 
            this.lbl_tpsTotal.AutoSize = true;
            this.lbl_tpsTotal.Location = new System.Drawing.Point(598, 35);
            this.lbl_tpsTotal.Name = "lbl_tpsTotal";
            this.lbl_tpsTotal.Size = new System.Drawing.Size(62, 13);
            this.lbl_tpsTotal.TabIndex = 11;
            this.lbl_tpsTotal.Text = "Temps total";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(327, 361);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 12;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // pgb_tempscout
            // 
            this.pgb_tempscout.Location = new System.Drawing.Point(601, 278);
            this.pgb_tempscout.Name = "pgb_tempscout";
            this.pgb_tempscout.Size = new System.Drawing.Size(145, 23);
            this.pgb_tempscout.TabIndex = 13;
            // 
            // lbl_progressbar1
            // 
            this.lbl_progressbar1.AutoSize = true;
            this.lbl_progressbar1.Location = new System.Drawing.Point(598, 259);
            this.lbl_progressbar1.Name = "lbl_progressbar1";
            this.lbl_progressbar1.Size = new System.Drawing.Size(158, 13);
            this.lbl_progressbar1.TabIndex = 14;
            this.lbl_progressbar1.Text = "Temps de réponse à la question";
            this.lbl_progressbar1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_joueur
            // 
            this.lbl_joueur.AutoSize = true;
            this.lbl_joueur.Location = new System.Drawing.Point(598, 311);
            this.lbl_joueur.Name = "lbl_joueur";
            this.lbl_joueur.Size = new System.Drawing.Size(39, 13);
            this.lbl_joueur.TabIndex = 15;
            this.lbl_joueur.Text = "Joueur";
            // 
            // lbl_difficulte
            // 
            this.lbl_difficulte.AutoSize = true;
            this.lbl_difficulte.Location = new System.Drawing.Point(598, 365);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(48, 13);
            this.lbl_difficulte.TabIndex = 16;
            this.lbl_difficulte.Text = "Difficulté";
            // 
            // txt_difficulte
            // 
            this.txt_difficulte.Enabled = false;
            this.txt_difficulte.Location = new System.Drawing.Point(601, 391);
            this.txt_difficulte.Name = "txt_difficulte";
            this.txt_difficulte.Size = new System.Drawing.Size(145, 20);
            this.txt_difficulte.TabIndex = 17;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Enabled = false;
            this.txt_prenom.Location = new System.Drawing.Point(601, 334);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(145, 20);
            this.txt_prenom.TabIndex = 18;
            // 
            // btn_ferme
            // 
            this.btn_ferme.Location = new System.Drawing.Point(713, 12);
            this.btn_ferme.Name = "btn_ferme";
            this.btn_ferme.Size = new System.Drawing.Size(75, 23);
            this.btn_ferme.TabIndex = 19;
            this.btn_ferme.Text = "X";
            this.btn_ferme.UseVisualStyleBackColor = true;
            this.btn_ferme.Click += new System.EventHandler(this.btn_ferme_Click);
            // 
            // jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.btn_ferme);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_difficulte);
            this.Controls.Add(this.lbl_difficulte);
            this.Controls.Add(this.lbl_joueur);
            this.Controls.Add(this.lbl_progressbar1);
            this.Controls.Add(this.pbx_image);
            this.Controls.Add(this.pgb_tempscout);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_tpsTotal);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.txt_temps);
            this.Controls.Add(this.txt_affichage);
            this.Controls.Add(this.gbx_reponse);
            this.Controls.Add(this.lbl_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "jeu";
            this.Text = "jeu";
            this.Load += new System.EventHandler(this.jeu_Load);
            this.gbx_reponse.ResumeLayout(false);
            this.gbx_reponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.CheckBox cbx_reponse1;
        private System.Windows.Forms.CheckBox cbx_reponse2;
        private System.Windows.Forms.CheckBox cbx_reponse3;
        private System.Windows.Forms.CheckBox cbx_reponse5;
        private System.Windows.Forms.CheckBox cbx_reponse4;
        private System.Windows.Forms.GroupBox gbx_reponse;
        private System.Windows.Forms.TextBox txt_affichage;
        private System.Windows.Forms.TextBox txt_temps;
        private System.Windows.Forms.PictureBox pbx_image;
        private System.Windows.Forms.Label txt_titre;
        private System.Windows.Forms.Label lbl_tpsTotal;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.ProgressBar pgb_tempscout;
        private System.Windows.Forms.Label lbl_progressbar1;
        private System.Windows.Forms.Label lbl_joueur;
        private System.Windows.Forms.Label lbl_difficulte;
        private System.Windows.Forms.TextBox txt_difficulte;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Button btn_ferme;
    }
}