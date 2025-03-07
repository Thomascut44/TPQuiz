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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            InitializeComponent();
           // partie.gestionTimer(temps); //nom timer a mettre !!!!!!
            // TextBox affichage !!!!!

            pgb_tempscout.Maximum = 15;  // Maximum de 15 secondes
            pgb_tempscout.Value = 0;     // Initialisation à 0


            ListeQuestions = new List<Question>();
            ListeQuestions.Add(new Question("Quelle est la capitale de la France ?", 1, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Espagne ?", 4, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Allemagne ?", 3, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Italie ?", 5, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Angleterre ?", 2, 1, "Paris", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Belgique ?", 1, 1, "Bruxelles", "Londres", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de la Suisse ?", 2, 1, "Bruxelles", "Berne", "Berlin", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale du Luxembourg ?", 3, 1, "Bruxelles", "Berne", "Luxembourg", "Madrid", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale du Portugal ?", 4, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Rome"));
            ListeQuestions.Add(new Question("Quelle est la capitale de l'Autriche ?", 5, 1, "Bruxelles", "Berne", "Luxembourg", "Lisbonne", "Vienne"));

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