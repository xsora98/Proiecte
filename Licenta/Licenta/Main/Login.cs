using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Licenta
{
    public partial class LoginPanel : Form
    {
        public static string rol = "";
        public int id_utilizator=0;
        public bool bd_con;

        public LoginPanel()
        {
            InitializeComponent();
        }


        public string CriptareParola(string parola)
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] parolaCriptata = md5.ComputeHash(utf8.GetBytes(parola));
            return Convert.ToBase64String(parolaCriptata);
        }


        private bool Validation(string username,string password)
        {
            bd_con = true;
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "Select id_utilizator,rol from utilizator where nume_utilizator=@username and parola=@password";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", CriptareParola(password));
                command.Connection = Constante.mySqlConnection;
                Constante.mySqlConnection.Open();
                MySqlDataReader login = command.ExecuteReader();
                if (login.Read())
                {
                    id_utilizator = login.GetInt32(0);
                    rol = login.GetString(1);
                    Constante.mySqlConnection.Close();
                    return true;
                }
                else
                {
                    Constante.mySqlConnection.Close();
                    return false;
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Verificati conexiunea cu baza de date");
                bd_con = false;
                return false;
            }
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = Utilizator.Text;
            string password = Parola.Text;
            
            if(username == "" || password == "")
            {
                MessageBox.Show("Va rugam să introduceți datele pentru autentificare!");
                return;
            }

            if (Validation(username, password))
            {
                this.Visible = false;
                Constante.Log("Login", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), id_utilizator);
                Meniu meniu = new Meniu();
                Meniu.id_utilizator = id_utilizator;
                meniu.ShowDialog();

            }
            else
            {
                if (bd_con == true)
                {
                    MessageBox.Show("Datele pentru autentificare nu sunt corecte");
                }
                
            }
        }

        private void Forgot_Click(object sender, EventArgs e)
        {
            ParolaUitata parolaUitata = new ParolaUitata();
            parolaUitata.ShowDialog();
        }

        private void LoginPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
