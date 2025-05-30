﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace TPQuiz.Model
{
    public class ConnectionBDD
    {
        #region attributs de classe
        private MySqlConnection mySqlCo;
        private string serveurBDD;
        private string nomBDD;
        private string loginBDD;
        private string mdpBDD;
        #endregion

        private void initConnexion()
        {
            mySqlCo = new MySqlConnection("Server=" + serveurBDD + ";Database=" + nomBDD + ";User ID=" + loginBDD + ";Password=" + mdpBDD);
        }

        #region Constructeurs
        public ConnectionBDD(string serveurBDD, string nomBDD, string loginBDD, string mdpBDD)
        {
            this.serveurBDD = serveurBDD;
            this.nomBDD = nomBDD;
            this.loginBDD = loginBDD;
            this.mdpBDD = mdpBDD;
            initConnexion();
        }
        #endregion

        public MySqlConnection MySqlCo
      { 
          get { return mySqlCo; } 
          set { mySqlCo = value; }
      }
    }
}
