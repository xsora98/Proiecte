using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licenta
{
    public partial class SchimbareParolaCod : Form
    {
        public string cod = "";
        public SchimbareParolaCod()
        {
            InitializeComponent();
        }
        private void SchimbareParolaCod_Load(object sender, EventArgs e)
        {
            cod += CodParola.cod_redirect;
        }

        private void Modifică_Click(object sender, EventArgs e)
        {
            string parolaNoua = ParolaNoua.Text;
            string confirmareParolaNoua = ConfirmareParolaNoua.Text;
            LoginPanel criptare = new LoginPanel();
            if (parolaNoua == "")
            {
                MessageBox.Show("Introduceti o parola noua");
                return;
            }
            if (parolaNoua == confirmareParolaNoua)
            {
                try
                {
                    string insert = "Update utilizator set parola=@parolaNoua where cod_parola=@cod;";
                    MySqlCommand command = new MySqlCommand(insert, Constante.mySqlConnection);
                    command.Parameters.AddWithValue("@parolaNoua", criptare.CriptareParola(parolaNoua));
                    command.Parameters.AddWithValue("@cod", cod);
                    Constante.mySqlConnection.Open();
                    MySqlDataReader execute = command.ExecuteReader();
                    Constante.mySqlConnection.Close();

                    string delete = "Update utilizator set cod_parola=NULL;";
                    MySqlCommand command1 = new MySqlCommand(delete, Constante.mySqlConnection);
                    Constante.mySqlConnection.Open();
                    MySqlDataReader execute1 = command1.ExecuteReader();
                    Constante.mySqlConnection.Close();
                    MessageBox.Show("Parola schimbata cu succes! Va trebui sa va re-autentificati!");
                    this.Visible = false;
                }
                catch (MySqlException E)
                {
                    throw E;
                }
            }
            else
            {
                MessageBox.Show("Parolele nu corespund");
                return;
            }
        }

        private void SchimbareParolaCod_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }
    }
}
