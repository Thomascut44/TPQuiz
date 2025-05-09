using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPQuiz.Controllers;
using TPQuiz.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySqlConnector;
using MySqlX.XDevAPI.Relational;

namespace TPQuiz
{
    public partial class jeu : Form
    {
        int reponseQuestion = 0;
        List<Question> ListeQuestions;
        Partie partie;
        string nomJoueur;
        string prenomJoueur;
        int difficultePartie;


        private void init() 
        {
            // fin de partie ne reset pas les questions 

            InitializeComponent();
            // partie.gestionTimer(temps); //nom timer a mettre !!!!!!
            txt_prenom.Text = nomJoueur +" "+ prenomJoueur;
            Difficulte df = new Difficulte();
            txt_difficulte.Text = df.GetDifficultyNameById(difficultePartie);

            pgb_tempscout.Maximum = 15;  // Maximum de 15 secondes
            pgb_tempscout.Value = 0;     // Initialisation à 0


            //Déclaration d'une nouvelle liste !! A METTRE DANS QUESTIONBDD
            List<Question> ListeQuestions = new List<Question>();
            DataTable dt = new DataTable();
            ConnectionBDD conn = new ConnectionBDD("192.168.10.16", "coutherut_thomas_BDD_QuizzAndTest", "coutherut_thomas", "vzb9UMK8");
            // Instancier un objet dt de type DataTable
            // Instancier un objet conn de type ConnectionBDD


            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDQUESTION,ENONCEQUESTION, REPONSE1QUESTION, REPONSE2QUESTION, REPONSE3QUESTION, REPONSE4QUESTION, REPONSE5QUESTION, BONREPQUESTION, QUESTION.IDDIFFICULTE FROM QUESTION INNER JOIN DIFFICULTE on QUESTION.IDDIFFICULTE = DIFFICULTE.IDDIFFICULTE WHERE QUESTION.IDDIFFICULTE = " + difficultePartie + ";", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }



            conn.MySqlCo.Close();
            conn.MySqlCo = null;


            //Remplir une liste avec une datatable
            foreach (DataRow row in dt.Rows)
            {
                ListeQuestions.Add(new Question(row["ENONCEQUESTION"].ToString(), Convert.ToInt32(row["BONREPQUESTION"]), Convert.ToInt32(row["IDDIFFICULTE"]), row["REPONSE1QUESTION"].ToString(), row["REPONSE2QUESTION"].ToString(), row["REPONSE3QUESTION"].ToString(), row["REPONSE4QUESTION"].ToString(), row["REPONSE5QUESTION"].ToString()));
            }

            partie = new Partie(nomJoueur, prenomJoueur, difficultePartie, ListeQuestions);
            partie.changerQuestion(txt_affichage,cbx_reponse1, cbx_reponse2, cbx_reponse3, cbx_reponse4, cbx_reponse5, this, gbx_reponse, pbx_image);
        }

        public jeu(string nomJ, string prenomJ, int difficultePartie)
        {
            this.nomJoueur = nomJ;
            this.prenomJoueur = prenomJ;
            this.difficultePartie = difficultePartie;
            //this.difficultePartie = Convert.ToInt32(difficultePartie); // Conversion en int 

            init();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            partie.validerReponse(reponseQuestion, pbx_image);
            partie.numQuestion++;
            partie.changerQuestion(txt_affichage, cbx_reponse1, cbx_reponse2, cbx_reponse3, cbx_reponse4, cbx_reponse5, this, gbx_reponse, pbx_image);
            lbl_question.Text = (partie.numQuestion + 1).ToString();
            reponseQuestion = 0;

        }

        private void cbx_reponse1Clic(object sender, EventArgs e)
        {
            //Boucle permettant de décocher toutes les cases à cocher du formulaire
            foreach (var box in gbx_reponse.Controls.OfType<CheckBox>())
            {
                box.Checked = false;
            }

            ((CheckBox)sender).Checked = true;
            //Mettre dans une variable la réponse choisis par l’utilisateur
            reponseQuestion = Convert.ToInt32(((CheckBox)sender).Name.Substring(11,1));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ferme_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}