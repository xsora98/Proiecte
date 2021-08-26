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
    public partial class SchimbareParola : Form 
    {
        public SchimbareParola()
        {
            InitializeComponent();

        }

        private bool VerificareParola(string parola)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "Select parola from utilizator where parola=@parola and id_utilizator=@id_utilizator";
            command.Parameters.AddWithValue("@parola", parola);
            command.Parameters.AddWithValue("@id_utilizator", Meniu.id_utilizator);
            command.Connection = Constante.mySqlConnection;
            Constante.mySqlConnection.Open();
            MySqlDataReader verificare = command.ExecuteReader();
            if (verificare.Read())
            {
                Constante.mySqlConnection.Close();
                return true;
            }
            else
            {
                Constante.mySqlConnection.Close();
                return false;
            }
        }

        private void Modifica_Click(object sender, EventArgs e)
        {
            string parolaCurenta = ParolaCurenta.Text;
            string parolaNoua = ParolaNoua.Text;
            string confirmaParolaNoua = ConfirmaParolaNoua.Text;
            LoginPanel criptare = new LoginPanel();

            if (VerificareParola(criptare.CriptareParola(parolaCurenta)))
            {
                if (parolaNoua != confirmaParolaNoua)
                {
                    MessageBox.Show("Parola noua nu poate fi confirmata deoarece acestea sunt diferite");
                    return;
                }

                if (parolaCurenta==parolaNoua)
                {
                    MessageBox.Show("Parola nu poate fi la fel cu cea curenta");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Parola curenta nu se regaseste in baza de date. Va rugam introduceti parola curenta");
                return;
            }

            try
            {

                string insert = "Update utilizator set parola=@parolaNoua where parola=@parolaCurenta and id_utilizator=@id_utilizator";
                MySqlCommand command = new MySqlCommand(insert, Constante.mySqlConnection);
                command.Parameters.AddWithValue("@parolaNoua",criptare.CriptareParola(parolaNoua));
                command.Parameters.AddWithValue("@parolaCurenta", criptare.CriptareParola(parolaCurenta));
                command.Parameters.AddWithValue("@id_utilizator", Meniu.id_utilizator);
                Constante.mySqlConnection.Open();
                MySqlDataReader execute = command.ExecuteReader();
                Constante.mySqlConnection.Close();
                Constante.Log("SchimbareParola", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
                MessageBox.Show("Parola schimbata cu succes. Va trebui sa va autentificati");
                Meniu meniu = new Meniu();
                meniu.Close();
                this.Visible = false;
                this.Close();
                LoginPanel login = new LoginPanel();
                login.ShowDialog();
            }
            catch(MySqlException E)
            {
                throw E;
            }
            
        }
    }
}
