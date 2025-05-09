using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPQuiz.Controllers;

namespace TPQuiz.Vue
{
    public partial class affichageBDD : Form
    {
        public affichageBDD()
        {
            InitializeComponent();
            DataView dv;
            
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestion());
            dgv_questions.DataSource = dv;
            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            dgv_questions.Columns["IDQUESTION"].Visible = false;
            dgv_questions.Columns["IDDIFFICULTE"].Visible = false;
            //Gérer la largeur des colonnes
            dgv_questions.Columns["Question"].Width = 400;
            dgv_questions.Columns["Difficulté"].Width = 300;
            //Attention il faut mettre le nom des alias à la place du nom des colonnes en cas d’utilisation d’alias dans la requête SQL.

            Difficulte dt_listedifficulte = new Difficulte();
            cbx_difficulte.DataSource = dt_listedifficulte.GetListeDifficulte();
            cbx_difficulte.DisplayMember = "DIFFICULTE"; //nom de l’alias SQL ou nom de la colonne
            cbx_difficulte.ValueMember = "IDDIFFICULTE";  //nom de l’alias SQL ou nom de la colonne

            cbx_difficulte2.DataSource = dt_listedifficulte.GetListeDifficulte();
            cbx_difficulte2.DisplayMember = "DIFFICULTE"; //nom de l’alias SQL ou nom de la colonne
            cbx_difficulte2.ValueMember = "IDDIFFICULTE";  //nom de l’alias SQL ou nom de la colonne

        }

        private void btn_ferme_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            DataView dv;
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestionRecherche(txt_recherche.Text, cbx_difficulte.SelectedIndex));
            dgv_questions.DataSource = dv;
        }

        public void cbx_difficulte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv;
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestionRecherche(txt_recherche.Text, cbx_difficulte.SelectedIndex));
            dgv_questions.DataSource = dv;
            
        }

        private void btn_ajouter_question_Click(object sender, EventArgs e)
        {
            pnl_modif.Visible = true;
            dgv_questions.Enabled = false;  
        }

        private void btn_modifier_question_Click(object sender, EventArgs e)
        {
            pnl_modif.Visible = true;
            dgv_questions.Enabled = false;
            idQuestion.Text = dgv_questions.CurrentRow.Cells["IDQUESTION"].Value.ToString();
            tbx_question.Text = dgv_questions.CurrentRow.Cells["Question"].Value.ToString();
            tbx_rep1.Text = dgv_questions.CurrentRow.Cells["REPONSE1QUESTION"].Value.ToString();
            tbx_rep2.Text = dgv_questions.CurrentRow.Cells["REPONSE2QUESTION"].Value.ToString();
            tbx_rep3.Text = dgv_questions.CurrentRow.Cells["REPONSE3QUESTION"].Value.ToString();
            tbx_rep4.Text = dgv_questions.CurrentRow.Cells["REPONSE4QUESTION"].Value.ToString();
            tbx_rep5.Text = dgv_questions.CurrentRow.Cells["REPONSE5QUESTION"].Value.ToString();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            pnl_modif.Visible = false;
            dgv_questions.Enabled = true;
        }
    }
}
