using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPQuiz.Model;
using MySqlConnector;

namespace TPQuiz.Controllers
{
    public class QuestionBDD
    {


        public DataTable GetListeQuestion()
        {
            DataTable dt = new DataTable();
            ConnectionBDD conn = new ConnectionBDD("192.168.10.16", "coutherut_thomas_BDD_QuizzAndTest", "coutherut_thomas", "vzb9UMK8");
            // Instancier un objet dt de type DataTable
            // Instancier un objet conn de type ConnectionBDD
            

            try
            {
                //ici
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDQUESTION,ENONCEQUESTION AS Question,REPONSE1QUESTION,REPONSE2QUESTION,REPONSE3QUESTION,REPONSE4QUESTION,REPONSE5QUESTION,DIFFICULTE.LABELDIFFICULTE AS Difficulté,DIFFICULTE.IDDIFFICULTE FROM QUESTION INNER JOIN DIFFICULTE on QUESTION.IDDIFFICULTE = DIFFICULTE.IDDIFFICULTE;", conn.MySqlCo))
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
            return dt;
        }

        public DataTable GetListeQuestionRecherche(string rechercheMot,int difficulte) 
        {
            //if(rqtSql == "") { return 'Erreur la requette est vide'; }
            //if()   ==0) { return 'Erreur bla bla est égale à 0'; }
            string rqtSql;
            if (difficulte == 0)
            {
                rqtSql = "SELECT IDQUESTION, ENONCEQUESTION AS Question, DIFFICULTE.LABELDIFFICULTE AS Difficulté, DIFFICULTE.IDDIFFICULTE " +
                            "FROM QUESTION INNER JOIN DIFFICULTE ON QUESTION.IDDIFFICULTE = DIFFICULTE.IDDIFFICULTE " +
                            "WHERE ENONCEQUESTION LIKE '%" + rechercheMot + "%';";
            }
            else
            {
                rqtSql = "SELECT IDQUESTION, ENONCEQUESTION AS Question, DIFFICULTE.LABELDIFFICULTE AS Difficulté, DIFFICULTE.IDDIFFICULTE "+ 
                            "FROM QUESTION INNER JOIN DIFFICULTE ON QUESTION.IDDIFFICULTE = DIFFICULTE.IDDIFFICULTE "+
                            "WHERE ENONCEQUESTION LIKE '%" + rechercheMot + "%' AND DIFFICULTE.IDDIFFICULTE = " + difficulte + ";";
            }
            

            DataTable dt = new DataTable();
            try
            {


                ConnectionBDD conn = new ConnectionBDD("192.168.10.16", "coutherut_thomas_BDD_QuizzAndTest", "coutherut_thomas", "vzb9UMK8");
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    cmd.Parameters.AddWithValue("@rechercheMot", rechercheMot);
                    cmd.Parameters.AddWithValue("@difficulte", difficulte);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dt;

        }

    }
}
