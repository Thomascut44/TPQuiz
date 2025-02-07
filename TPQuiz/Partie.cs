using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace TPQuiz
{
    internal class Partie
    {
        public int score;
        public int difficulte;
        public int nbQuestionPartie;
        public List<Question> questionList;
        public int bonneReponse;
        public int numQuestion;


        public Partie(List<Question> questionList) 
        {
            this.score = 0;
            this.difficulte = 0;
            this.nbQuestionPartie = questionList.Count();
            this.questionList = questionList;
            this.numQuestion = 0;

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
            }
        }

        private void aleatoireReponse(TextBox txt_affichage, GroupBox gd_reponse)
        {
            int bonneRep = questionList[numQuestion].reponse;
            txt_affichage.Text = questionList[numQuestion].enonce;
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
                        reponse = questionList[numQuestion].proposition1;
                        break;
                    case 2:
                        reponse = questionList[numQuestion].proposition2;
                        break;
                    case 3:
                        reponse = questionList[numQuestion].proposition3;
                        break;
                    case 4:
                        reponse = questionList[numQuestion].proposition4;
                        break;
                    case 5:
                        reponse = questionList[numQuestion].proposition5;
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

        public void finDePartie()
        {
            DialogResult msg;
            msg = MessageBox.Show("Votre score est de " + score + ".\r\n Voulez vous rejouer", "Fin de la partie"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            


        }

    }
}
