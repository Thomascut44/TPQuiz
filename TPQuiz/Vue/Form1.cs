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

namespace TPQuiz
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Difficulte dt_listedifficulte = new Difficulte();
            cbb_difficulte.DataSource = dt_listedifficulte.GetListeDifficulte();
            cbb_difficulte.DisplayMember = "DIFFICULTE"; //nom de l’alias SQL ou nom de la colonne
            cbb_difficulte.ValueMember = "IDDIFFICULTE";  //nom de l’alias SQL ou nom de la colonne
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string nomJ = txt_nom.Text;
            string prenomJ = txt_prenom.Text;
            int difficultePartie = Convert.ToInt32(cbb_difficulte.SelectedIndex.ToString());

            if (txt_nom.Text != "" && txt_prenom.Text != "")
            {
                if (cbb_difficulte.SelectedIndex == -1 || cbb_difficulte.SelectedIndex == 0)
                {
                    MessageBox.Show("Aucune difficulté n'est selectionner", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    jeu J = new jeu(nomJ, prenomJ, difficultePartie);
                    (System.Windows.Forms.Application.OpenForms["Menu"] as Menu).openChildForm(J);
                    this.Hide();

                }
            }
            else if (txt_prenom.Text == "" && txt_nom.Text != "")
            {
                MessageBox.Show("Aucun prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_nom.Text == "" && txt_prenom.Text != "")
            {
                MessageBox.Show("Aucun nom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                MessageBox.Show("Aucun nom et prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbb_difficulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_difficulte.SelectedIndex == 4) // Index "Enfer"
            {
                this.BackColor = Color.DarkRed;
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Bold);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_difficulte.Font = new Font(lbl_difficulte.Font, FontStyle.Regular);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
