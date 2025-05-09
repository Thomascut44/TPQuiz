namespace TPQuiz.Vue
{
    partial class affichageBDD
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
            this.btn_ferme = new System.Windows.Forms.Button();
            this.dgv_questions = new System.Windows.Forms.DataGridView();
            this.gb_recherche = new System.Windows.Forms.GroupBox();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.lbl_recherche = new System.Windows.Forms.Label();
            this.cbx_difficulte = new System.Windows.Forms.ComboBox();
            this.btn_ajouter_question = new System.Windows.Forms.Button();
            this.btn_modifier_question = new System.Windows.Forms.Button();
            this.btn_supprimer_question = new System.Windows.Forms.Button();
            this.pnl_modif = new System.Windows.Forms.Panel();
            this.cbx_rep5 = new System.Windows.Forms.CheckBox();
            this.cbx_rep4 = new System.Windows.Forms.CheckBox();
            this.cbx_rep3 = new System.Windows.Forms.CheckBox();
            this.cbx_rep2 = new System.Windows.Forms.CheckBox();
            this.cbx_rep1 = new System.Windows.Forms.CheckBox();
            this.lbl_bonneReponse = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.cbx_difficulte2 = new System.Windows.Forms.ComboBox();
            this.lbl_difficulte2 = new System.Windows.Forms.Label();
            this.tbx_rep5 = new System.Windows.Forms.TextBox();
            this.tbx_rep4 = new System.Windows.Forms.TextBox();
            this.tbx_rep3 = new System.Windows.Forms.TextBox();
            this.tbx_rep2 = new System.Windows.Forms.TextBox();
            this.tbx_rep1 = new System.Windows.Forms.TextBox();
            this.lbl_reponse = new System.Windows.Forms.Label();
            this.tbx_question = new System.Windows.Forms.TextBox();
            this.lbl_question_panel = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.idQuestion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).BeginInit();
            this.gb_recherche.SuspendLayout();
            this.pnl_modif.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ferme
            // 
            this.btn_ferme.Location = new System.Drawing.Point(747, 27);
            this.btn_ferme.Name = "btn_ferme";
            this.btn_ferme.Size = new System.Drawing.Size(25, 23);
            this.btn_ferme.TabIndex = 0;
            this.btn_ferme.Text = "X";
            this.btn_ferme.UseVisualStyleBackColor = true;
            this.btn_ferme.Click += new System.EventHandler(this.btn_ferme_Click);
            // 
            // dgv_questions
            // 
            this.dgv_questions.AllowUserToAddRows = false;
            this.dgv_questions.AllowUserToDeleteRows = false;
            this.dgv_questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_questions.Location = new System.Drawing.Point(12, 188);
            this.dgv_questions.Name = "dgv_questions";
            this.dgv_questions.ReadOnly = true;
            this.dgv_questions.Size = new System.Drawing.Size(760, 429);
            this.dgv_questions.TabIndex = 1;
            // 
            // gb_recherche
            // 
            this.gb_recherche.Controls.Add(this.txt_recherche);
            this.gb_recherche.Controls.Add(this.lbl_difficulte);
            this.gb_recherche.Controls.Add(this.lbl_recherche);
            this.gb_recherche.Controls.Add(this.cbx_difficulte);
            this.gb_recherche.Location = new System.Drawing.Point(319, 56);
            this.gb_recherche.Name = "gb_recherche";
            this.gb_recherche.Size = new System.Drawing.Size(453, 100);
            this.gb_recherche.TabIndex = 2;
            this.gb_recherche.TabStop = false;
            this.gb_recherche.Text = "Recherche";
            // 
            // txt_recherche
            // 
            this.txt_recherche.Location = new System.Drawing.Point(216, 20);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(181, 20);
            this.txt_recherche.TabIndex = 3;
            this.txt_recherche.TextChanged += new System.EventHandler(this.txt_recherche_TextChanged);
            // 
            // lbl_difficulte
            // 
            this.lbl_difficulte.AutoSize = true;
            this.lbl_difficulte.Location = new System.Drawing.Point(149, 52);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(48, 13);
            this.lbl_difficulte.TabIndex = 2;
            this.lbl_difficulte.Text = "Difficulté";
            // 
            // lbl_recherche
            // 
            this.lbl_recherche.AutoSize = true;
            this.lbl_recherche.Location = new System.Drawing.Point(97, 23);
            this.lbl_recherche.Name = "lbl_recherche";
            this.lbl_recherche.Size = new System.Drawing.Size(100, 13);
            this.lbl_recherche.TabIndex = 1;
            this.lbl_recherche.Text = "Recherche de mots";
            // 
            // cbx_difficulte
            // 
            this.cbx_difficulte.FormattingEnabled = true;
            this.cbx_difficulte.Location = new System.Drawing.Point(216, 52);
            this.cbx_difficulte.Name = "cbx_difficulte";
            this.cbx_difficulte.Size = new System.Drawing.Size(181, 21);
            this.cbx_difficulte.TabIndex = 0;
            this.cbx_difficulte.SelectionChangeCommitted += new System.EventHandler(this.cbx_difficulte_SelectionChangeCommitted);
            // 
            // btn_ajouter_question
            // 
            this.btn_ajouter_question.Location = new System.Drawing.Point(787, 197);
            this.btn_ajouter_question.Name = "btn_ajouter_question";
            this.btn_ajouter_question.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter_question.TabIndex = 3;
            this.btn_ajouter_question.Text = "Ajouter";
            this.btn_ajouter_question.UseVisualStyleBackColor = true;
            this.btn_ajouter_question.Click += new System.EventHandler(this.btn_ajouter_question_Click);
            // 
            // btn_modifier_question
            // 
            this.btn_modifier_question.Location = new System.Drawing.Point(787, 226);
            this.btn_modifier_question.Name = "btn_modifier_question";
            this.btn_modifier_question.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier_question.TabIndex = 4;
            this.btn_modifier_question.Text = "Modifier";
            this.btn_modifier_question.UseVisualStyleBackColor = true;
            this.btn_modifier_question.Click += new System.EventHandler(this.btn_modifier_question_Click);
            // 
            // btn_supprimer_question
            // 
            this.btn_supprimer_question.Location = new System.Drawing.Point(787, 255);
            this.btn_supprimer_question.Name = "btn_supprimer_question";
            this.btn_supprimer_question.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer_question.TabIndex = 5;
            this.btn_supprimer_question.Text = "Supprimer";
            this.btn_supprimer_question.UseVisualStyleBackColor = true;
            // 
            // pnl_modif
            // 
            this.pnl_modif.Controls.Add(this.cbx_rep5);
            this.pnl_modif.Controls.Add(this.cbx_rep4);
            this.pnl_modif.Controls.Add(this.cbx_rep3);
            this.pnl_modif.Controls.Add(this.cbx_rep2);
            this.pnl_modif.Controls.Add(this.cbx_rep1);
            this.pnl_modif.Controls.Add(this.lbl_bonneReponse);
            this.pnl_modif.Controls.Add(this.btn_annuler);
            this.pnl_modif.Controls.Add(this.btn_valider);
            this.pnl_modif.Controls.Add(this.cbx_difficulte2);
            this.pnl_modif.Controls.Add(this.lbl_difficulte2);
            this.pnl_modif.Controls.Add(this.tbx_rep5);
            this.pnl_modif.Controls.Add(this.tbx_rep4);
            this.pnl_modif.Controls.Add(this.tbx_rep3);
            this.pnl_modif.Controls.Add(this.tbx_rep2);
            this.pnl_modif.Controls.Add(this.tbx_rep1);
            this.pnl_modif.Controls.Add(this.lbl_reponse);
            this.pnl_modif.Controls.Add(this.tbx_question);
            this.pnl_modif.Controls.Add(this.lbl_question_panel);
            this.pnl_modif.Controls.Add(this.lbl_titre);
            this.pnl_modif.Controls.Add(this.idQuestion);
            this.pnl_modif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pnl_modif.Location = new System.Drawing.Point(877, 188);
            this.pnl_modif.Name = "pnl_modif";
            this.pnl_modif.Size = new System.Drawing.Size(370, 429);
            this.pnl_modif.TabIndex = 6;
            this.pnl_modif.Visible = false;
            // 
            // cbx_rep5
            // 
            this.cbx_rep5.AutoSize = true;
            this.cbx_rep5.Location = new System.Drawing.Point(314, 277);
            this.cbx_rep5.Name = "cbx_rep5";
            this.cbx_rep5.Size = new System.Drawing.Size(15, 14);
            this.cbx_rep5.TabIndex = 19;
            this.cbx_rep5.UseVisualStyleBackColor = true;
            // 
            // cbx_rep4
            // 
            this.cbx_rep4.AutoSize = true;
            this.cbx_rep4.Location = new System.Drawing.Point(314, 248);
            this.cbx_rep4.Name = "cbx_rep4";
            this.cbx_rep4.Size = new System.Drawing.Size(15, 14);
            this.cbx_rep4.TabIndex = 18;
            this.cbx_rep4.UseVisualStyleBackColor = true;
            // 
            // cbx_rep3
            // 
            this.cbx_rep3.AutoSize = true;
            this.cbx_rep3.Location = new System.Drawing.Point(314, 219);
            this.cbx_rep3.Name = "cbx_rep3";
            this.cbx_rep3.Size = new System.Drawing.Size(15, 14);
            this.cbx_rep3.TabIndex = 17;
            this.cbx_rep3.UseVisualStyleBackColor = true;
            // 
            // cbx_rep2
            // 
            this.cbx_rep2.AutoSize = true;
            this.cbx_rep2.Location = new System.Drawing.Point(314, 190);
            this.cbx_rep2.Name = "cbx_rep2";
            this.cbx_rep2.Size = new System.Drawing.Size(15, 14);
            this.cbx_rep2.TabIndex = 16;
            this.cbx_rep2.UseVisualStyleBackColor = true;
            // 
            // cbx_rep1
            // 
            this.cbx_rep1.AutoSize = true;
            this.cbx_rep1.Location = new System.Drawing.Point(314, 161);
            this.cbx_rep1.Name = "cbx_rep1";
            this.cbx_rep1.Size = new System.Drawing.Size(15, 14);
            this.cbx_rep1.TabIndex = 15;
            this.cbx_rep1.UseVisualStyleBackColor = true;
            // 
            // lbl_bonneReponse
            // 
            this.lbl_bonneReponse.AutoSize = true;
            this.lbl_bonneReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_bonneReponse.Location = new System.Drawing.Point(282, 140);
            this.lbl_bonneReponse.Name = "lbl_bonneReponse";
            this.lbl_bonneReponse.Size = new System.Drawing.Size(85, 13);
            this.lbl_bonneReponse.TabIndex = 14;
            this.lbl_bonneReponse.Text = "Bonne réponse :";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(276, 393);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 13;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(14, 391);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(70, 25);
            this.btn_valider.TabIndex = 12;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // cbx_difficulte2
            // 
            this.cbx_difficulte2.FormattingEnabled = true;
            this.cbx_difficulte2.Location = new System.Drawing.Point(20, 326);
            this.cbx_difficulte2.Name = "cbx_difficulte2";
            this.cbx_difficulte2.Size = new System.Drawing.Size(245, 25);
            this.cbx_difficulte2.TabIndex = 11;
            // 
            // lbl_difficulte2
            // 
            this.lbl_difficulte2.AutoSize = true;
            this.lbl_difficulte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_difficulte2.Location = new System.Drawing.Point(22, 310);
            this.lbl_difficulte2.Name = "lbl_difficulte2";
            this.lbl_difficulte2.Size = new System.Drawing.Size(54, 13);
            this.lbl_difficulte2.TabIndex = 10;
            this.lbl_difficulte2.Text = "Difficulté :";
            // 
            // tbx_rep5
            // 
            this.tbx_rep5.Location = new System.Drawing.Point(20, 272);
            this.tbx_rep5.Name = "tbx_rep5";
            this.tbx_rep5.Size = new System.Drawing.Size(245, 23);
            this.tbx_rep5.TabIndex = 9;
            // 
            // tbx_rep4
            // 
            this.tbx_rep4.Location = new System.Drawing.Point(20, 243);
            this.tbx_rep4.Name = "tbx_rep4";
            this.tbx_rep4.Size = new System.Drawing.Size(245, 23);
            this.tbx_rep4.TabIndex = 8;
            // 
            // tbx_rep3
            // 
            this.tbx_rep3.Location = new System.Drawing.Point(20, 214);
            this.tbx_rep3.Name = "tbx_rep3";
            this.tbx_rep3.Size = new System.Drawing.Size(245, 23);
            this.tbx_rep3.TabIndex = 7;
            // 
            // tbx_rep2
            // 
            this.tbx_rep2.Location = new System.Drawing.Point(20, 185);
            this.tbx_rep2.Name = "tbx_rep2";
            this.tbx_rep2.Size = new System.Drawing.Size(245, 23);
            this.tbx_rep2.TabIndex = 6;
            // 
            // tbx_rep1
            // 
            this.tbx_rep1.Location = new System.Drawing.Point(20, 156);
            this.tbx_rep1.Name = "tbx_rep1";
            this.tbx_rep1.Size = new System.Drawing.Size(245, 23);
            this.tbx_rep1.TabIndex = 5;
            // 
            // lbl_reponse
            // 
            this.lbl_reponse.AutoSize = true;
            this.lbl_reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reponse.Location = new System.Drawing.Point(22, 140);
            this.lbl_reponse.Name = "lbl_reponse";
            this.lbl_reponse.Size = new System.Drawing.Size(121, 13);
            this.lbl_reponse.TabIndex = 4;
            this.lbl_reponse.Text = "Proposition de réponse :";
            // 
            // tbx_question
            // 
            this.tbx_question.Location = new System.Drawing.Point(90, 56);
            this.tbx_question.Multiline = true;
            this.tbx_question.Name = "tbx_question";
            this.tbx_question.Size = new System.Drawing.Size(261, 67);
            this.tbx_question.TabIndex = 3;
            // 
            // lbl_question_panel
            // 
            this.lbl_question_panel.AutoSize = true;
            this.lbl_question_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question_panel.Location = new System.Drawing.Point(22, 56);
            this.lbl_question_panel.Name = "lbl_question_panel";
            this.lbl_question_panel.Size = new System.Drawing.Size(62, 15);
            this.lbl_question_panel.TabIndex = 2;
            this.lbl_question_panel.Text = "Question :";
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbl_titre.Location = new System.Drawing.Point(121, 15);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(133, 18);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Ajout / Modification";
            // 
            // idQuestion
            // 
            this.idQuestion.Enabled = false;
            this.idQuestion.Location = new System.Drawing.Point(20, 12);
            this.idQuestion.Name = "idQuestion";
            this.idQuestion.Size = new System.Drawing.Size(75, 23);
            this.idQuestion.TabIndex = 0;
            // 
            // affichageBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1376, 629);
            this.Controls.Add(this.pnl_modif);
            this.Controls.Add(this.btn_supprimer_question);
            this.Controls.Add(this.btn_modifier_question);
            this.Controls.Add(this.btn_ajouter_question);
            this.Controls.Add(this.gb_recherche);
            this.Controls.Add(this.dgv_questions);
            this.Controls.Add(this.btn_ferme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "affichageBDD";
            this.Text = "affichageBDD";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).EndInit();
            this.gb_recherche.ResumeLayout(false);
            this.gb_recherche.PerformLayout();
            this.pnl_modif.ResumeLayout(false);
            this.pnl_modif.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ferme;
        private System.Windows.Forms.DataGridView dgv_questions;
        private System.Windows.Forms.GroupBox gb_recherche;
        private System.Windows.Forms.TextBox txt_recherche;
        private System.Windows.Forms.Label lbl_difficulte;
        private System.Windows.Forms.Label lbl_recherche;
        private System.Windows.Forms.ComboBox cbx_difficulte;
        private System.Windows.Forms.Button btn_ajouter_question;
        private System.Windows.Forms.Button btn_modifier_question;
        private System.Windows.Forms.Button btn_supprimer_question;
        private System.Windows.Forms.Panel pnl_modif;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.TextBox idQuestion;
        private System.Windows.Forms.Label lbl_question_panel;
        private System.Windows.Forms.TextBox tbx_question;
        private System.Windows.Forms.TextBox tbx_rep5;
        private System.Windows.Forms.TextBox tbx_rep4;
        private System.Windows.Forms.TextBox tbx_rep3;
        private System.Windows.Forms.TextBox tbx_rep2;
        private System.Windows.Forms.TextBox tbx_rep1;
        private System.Windows.Forms.Label lbl_reponse;
        private System.Windows.Forms.Label lbl_difficulte2;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.ComboBox cbx_difficulte2;
        private System.Windows.Forms.CheckBox cbx_rep1;
        private System.Windows.Forms.Label lbl_bonneReponse;
        private System.Windows.Forms.CheckBox cbx_rep5;
        private System.Windows.Forms.CheckBox cbx_rep4;
        private System.Windows.Forms.CheckBox cbx_rep3;
        private System.Windows.Forms.CheckBox cbx_rep2;
    }
}