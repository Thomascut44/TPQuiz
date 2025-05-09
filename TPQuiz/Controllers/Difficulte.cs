using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using TPQuiz.Model;

namespace TPQuiz.Controllers
{
    public class Difficulte
    {
        public DataTable GetListeDifficulte()
        {
            DataTable dt_ListeDifficulte = new DataTable();
            ConnectionBDD conn = new ConnectionBDD("192.168.10.16", "coutherut_thomas_BDD_QuizzAndTest", "coutherut_thomas", "vzb9UMK8");
            // Instancier un objet dt de type DataTable
            // Instancier un objet conn de type ConnectionBDD


            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDDIFFICULTE,LABELDIFFICULTE AS Difficulte FROM DIFFICULTE;", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt_ListeDifficulte.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }



            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            DataRow workRow = dt_ListeDifficulte.NewRow();
            workRow[0] = -1;
            workRow[1] = "";
            dt_ListeDifficulte.Rows.InsertAt(workRow, 0);
            return dt_ListeDifficulte;

        }
        public string GetDifficultyNameById(int id)
        {
            // Utilisation de Select pour rechercher une ligne avec l'ID spécifié
            DataRow[] rows = GetListeDifficulte().Select("IDDIFFICULTE = " + id);

            if (rows.Length > 0)
            {
                // Retourne le nom de la difficulté (colonne "Difficulte")
                return rows[0]["Difficulte"].ToString();
            }

            return null; // Si aucune ligne n'est trouvée
        }
    }
}
