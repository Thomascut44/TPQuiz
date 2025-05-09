using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TPQuiz.Model;


namespace TPQuiz
{
    public class Partie
    {

        public int score;                   // Score du joueur 
        public int difficulte;              // Difficulté choisie 
        public int nbQuestionPartie;
        public List<Question> questionList;
        public int bonneReponse;
        public int numQuestion;
        public string nom;                  // Nom du joueur
        public string prenom;               // Prénom du joueur
        private int timerPartie;            // Stocke la durée totale de la partie
        private Timer timer;                // Gère le timer
        private int dureeTQuestion;         // Temps restant pour répondre à la question
        private SousFormulaire SF;
        private List<Question> listeAleatoire;


        public Partie(string nom, string prenom, int difficulte,List<Question> questionL) 
        {
            this.score = 0;
            //this.difficulte = 0;
            questionList = questionL;
            this.nbQuestionPartie = 10; //listeAleatoire.Count;            
            this.numQuestion = 0;
            this.nom = nom;
            this.prenom = prenom;
            this.difficulte = difficulte;
            this.timerPartie = 0; // Initialisation du compteur de temps
            listeAleatoireQuestion();


        }

        public void Timer_Tick(object sender, EventArgs e, TextBox temps, ProgressBar progressbar1, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Label numeroQuestion)
        {
            timerPartie++;
            dureeTQuestion++;
            progressbar1.Increment(1);
            temps.Text = timerPartie.ToString() + " sec";
            if (dureeTQuestion > 15)
            {
                validerReponse(0, PbImage);
                numQuestion++;
                numeroQuestion.Text = (numQuestion + 1).ToString();
                changerQuestion(txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage);
                progressbar1.Value = 0;
                dureeTQuestion = 0;
            }
        }

        public void gestionTimer(TextBox txt_timer, ProgressBar progressbar1, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Label numQuestion)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => Timer_Tick(sender, e, txt_timer, progressbar1, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, numQuestion);

            timer.Start();
        }


        private void changerImg(PictureBox pbx_image, bool bonneReponse, bool raz) //private normalement
        {
            if (!raz)
            {
                if (bonneReponse)
                {
                    pbx_image.Image = Properties.Resources.vrai;
                }
                else
                {
                    pbx_image.Image = Properties.Resources.faux;
                }
            }
        }

        private void calculerScore(bool df) 
        {
            score++;   
        }
        
        public void validerReponse(int reponse, PictureBox pbx_image)
        {
            if (reponse == bonneReponse)
            {
                
                calculerScore(true); 
                changerImg(pbx_image, true, false);
            }
            else
            {
                changerImg(pbx_image, false, false);
            }



        }

        public void changerQuestion(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage)
        {
            if (numQuestion<nbQuestionPartie)
            {
                aleatoireReponse(txt_affichage, gd_reponse);
                ckb_reponse1.Checked = false;
                ckb_reponse2.Checked = false;
                ckb_reponse3.Checked = false;
                ckb_reponse4.Checked = false;
                ckb_reponse5.Checked = false;


            }
            else
            {
                //appel de la méthode de fin de partie qui sera réalisé plus tard
                finDePartie(formulaire, PbImage, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, gd_reponse);


            }
        }

        private void aleatoireReponse(TextBox txt_affichage, GroupBox gd_reponse)
        {
            // questionList remplacer par listeAleatoire
            int bonneRep = listeAleatoire[numQuestion].reponse;
            txt_affichage.Text = listeAleatoire[numQuestion].enonce;
            List<int> reponseAleatoire = new List<int>() { 1, 2, 3, 4, 5 };
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int randIndex = rnd.Next(reponseAleatoire.Count);
                int random = reponseAleatoire[randIndex];
                reponseAleatoire.Remove(random);
                string reponse = "";

                //Réaliser un switch permettant d’affecter à reponse la proposition sélectionnée de manière aléatoire
                switch(random)
                {
                    case 1:
                        reponse = listeAleatoire[numQuestion].proposition1;
                        break;
                    case 2:
                        reponse = listeAleatoire[numQuestion].proposition2;
                        break;
                    case 3:
                        reponse = listeAleatoire[numQuestion].proposition3;
                        break;
                    case 4:
                        reponse = listeAleatoire[numQuestion].proposition4;
                        break;
                    case 5:
                        reponse = listeAleatoire[numQuestion].proposition5;
                        break;


                }

                getCheckBox(i, gd_reponse).Text = reponse;
                if (bonneRep == random)
                {
                    bonneReponse = i;
                }
            }
        }

        private CheckBox getCheckBox(int indice, GroupBox gd_reponse)
        {
            foreach (Control c in gd_reponse.Controls)
            {
                if (c.GetType() == typeof(CheckBox) && c.Name == "cbx_reponse" + indice.ToString())
                {
                    return ((CheckBox)c);
                }
            }
            return null;
        }

        public void finDePartie(Form formulaireJeuActif, PictureBox pbx_image, TextBox txt_affichage, CheckBox cbx_reponse1, CheckBox cbx_reponse2, CheckBox cbx_reponse3, CheckBox cbx_reponse4, CheckBox cbx_reponse5, GroupBox gbx_reponsen)
        {
            DialogResult msg;
            msg = MessageBox.Show("Votre score est de " + score + ".\r\n Voulez vous rejouer", "Fin de la partie"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.Yes) 
            {
                listeAleatoire = listeAleatoireQuestion(); // On reset la liste de question aléatoire
                listeAleatoire.Clear();
                // Remettre le score à zéro
                score = 0;
                numQuestion = 0;

                // Réinitialiser le temps
                timerPartie = 0; 

                // Remettre l’image par défaut
                pbx_image.Image = Properties.Resources.Interrogation;

                // Redémarrer le timer
                

                // Afficher la première question
                changerQuestion(txt_affichage, cbx_reponse1, cbx_reponse2, cbx_reponse3, cbx_reponse4, cbx_reponse5, formulaireJeuActif, gbx_reponsen, pbx_image);

                timer.Start();
            }
            else
            {
                formulaireJeuActif.Hide();

            }



        }
        public List<Question> listeAleatoireQuestion()
        {
            listeAleatoire = new List<Question>();
            //List<int> reponseAleatoire = new List<int>();
            //Création d’un tableau contenant les valeurs représentant l’ensemble des questions

            Random rnd = new Random();
            //Ajout des questions dans la liste aléatoire des questions
            for (int i = 1; i <= 10; i++)
            {
                int randIndex = rnd.Next(questionList.Count);
                if (listeAleatoire.Contains(questionList[randIndex]))
                {
                    i--;
                }
                else {
                    listeAleatoire.Add(questionList[randIndex]);
                }
            }
            return listeAleatoire;
        }
    }
}
