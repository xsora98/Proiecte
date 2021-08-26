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
    public partial class IntroducereFunctie : Form
    {
        public IntroducereFunctie()
        {
            InitializeComponent();
        }

        private void IntroducereFunctie_Load(object sender, EventArgs e)
        {
            PopulareDepartament();
        }

        private void PopulareDepartament()
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "Select Denumire from departament";
                mySqlCommand.Connection = Constante.mySqlConnection;
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    string departament = mySqlDataReader.GetString(0);
                    Departament.Items.Add(departament);
                }
            }catch(MySqlException E)
            {
                throw E;
            }
            Constante.mySqlConnection.Close();
        }

        private int IdDepartament(string departament)
        {
            try
            {
                MySqlCommand mySqlCommand= new MySqlCommand();
                mySqlCommand.CommandText = "Select Id_departament from departament where denumire=@denumire;";
                mySqlCommand.Parameters.AddWithValue("@denumire", departament);
                mySqlCommand.Connection = Constante.mySqlConnection;
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    int id = mySqlDataReader.GetInt32(0);
                    Constante.mySqlConnection.Close();
                    return id;
                }
                else
                {
                    Constante.mySqlConnection.Close();
                    return 0;
                }
            }catch(MySqlException E)
            {
                throw E;
            }

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string denumire = Denumire.Text;
            Object departament = Departament.SelectedItem;
            int salariu = Int32.Parse(Salariu.Text);
            int id=IdDepartament(departament.ToString());

            if (id != 0)
            {
                try
                {
                    string insert = "Insert into functie(denumire,salariu,id_departament) values(@denumire,@salariu,@id_departament);";
                    MySqlCommand mySqlCommand = new MySqlCommand(insert, Constante.mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@denumire", denumire);
                    mySqlCommand.Parameters.AddWithValue("@salariu", salariu);
                    mySqlCommand.Parameters.AddWithValue("@id_departament", id);
                    Constante.mySqlConnection.Open();
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    Constante.mySqlConnection.Close();
                }catch(MySqlException E)
                {
                    throw E;
                }
            }
            else
            {
                MessageBox.Show("Departamentul selectat nu exista");
            }
            Constante.Log("IntroducereFunctie", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
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

        private void Salariu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
