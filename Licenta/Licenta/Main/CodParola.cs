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
    public partial class CodParola : Form
    {
        public static string cod_redirect = "";
        public CodParola()
        {
            InitializeComponent();
        }

        
        private bool VerificareCod(string cod)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "Select id_utilizator from utilizator where cod_parola=@cod";
            command.Parameters.AddWithValue("@cod", cod);
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

        private void Trimite_Click(object sender, EventArgs e)
        {
            string cod = Cod.Text;
            if (VerificareCod(cod))
            {
                cod_redirect += cod;
                this.Visible = false;
                SchimbareParolaCod schimbareParolaCod = new SchimbareParolaCod();
                schimbareParolaCod.ShowDialog();
            }
            else
            {
                MessageBox.Show("Codul introdus este gresit!");
                return;
            }
        }

        private void CodParola_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            ParolaUitata parolaUitata = new ParolaUitata();
            parolaUitata.ShowDialog();
        }

        private void Cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
