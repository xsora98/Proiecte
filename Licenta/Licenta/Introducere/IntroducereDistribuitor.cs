using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Licenta
{
    public partial class IntroducereDistribuitor : Form
    {
        public IntroducereDistribuitor()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string denumire = Denumire.Text;
            string adresa = Adresa.Text;
            try
            {
                string insert = "insert into distribuitor(denumire,adresa) values(@denumire,@adresa)";
                MySqlCommand mySqlCommand = new MySqlCommand(insert, Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@denumire", denumire);
                mySqlCommand.Parameters.AddWithValue("@adresa", adresa);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                Constante.mySqlConnection.Close();
            }
            catch(MySqlException E)
            {
                throw E;
            }
            Constante.Log("IntroducereDistribuitor", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
            MessageBox.Show("Inserare realizată cu succes");
            Close();
        }

        private void Denumire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
