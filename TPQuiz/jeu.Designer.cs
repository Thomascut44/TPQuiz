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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbx_image = new System.Windows.Forms.PictureBox();
            this.txt_titre = new System.Windows.Forms.Label();
            this.lbl_tpsTotal = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(85, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 45);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(601, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 8;
            // 
            // pbx_image
            // 
            this.pbx_image.Location = new System.Drawing.Point(601, 92);
            this.pbx_image.Name = "pbx_image";
            this.pbx_image.Size = new System.Drawing.Size(156, 138);
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
            // jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_tpsTotal);
            this.Controls.Add(this.txt_titre);
            this.Controls.Add(this.pbx_image);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbx_reponse);
            this.Controls.Add(this.lbl_question);
            this.Name = "jeu";
            this.Text = "jeu";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pbx_image;
        private System.Windows.Forms.Label txt_titre;
        private System.Windows.Forms.Label lbl_tpsTotal;
        private System.Windows.Forms.Button btn_valider;
    }
}