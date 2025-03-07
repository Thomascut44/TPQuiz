using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace TPQuiz.Model
{
    public class ConnectionBDD
    {
        private MySqlConnection MySqlCo;
        private string serveurBDD;
        private string nomBDD;
        private string loginBDD;
        private string mdpBDD;   
        
        private void initConnexion()
        {
            MySqlCo = new MySqlConnection("Server=" + serveurBDD + ";Database=" + nomBDD + ";User ID=" + loginBDD + ";Password=" + mdpBDD);
        }

        public ConnectionBDD(string serveurBDD, string nomBDD, string loginBDD, string mdpBDD) 
        {
            this.serveurBDD = serveurBDD;
            this.nomBDD = nomBDD;
            this.loginBDD = loginBDD;
            this.mdpBDD = mdpBDD;
            initConnexion();
        }
    }
}
