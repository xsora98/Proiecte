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
    public partial class IntroducereAngajat : Form
    {
        public IntroducereAngajat()
        {
            InitializeComponent();
        }

        private void IntroducereAngajat_Load(object sender, EventArgs e)
        {
            PopulareFunctie();
            Data.CustomFormat = "dd-MMM-yyyy";
            Data.Format = DateTimePickerFormat.Custom;
            Data.Value = DateTime.Today;
        }

        private void PopulareFunctie()
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "Select denumire from functie";
                mySqlCommand.Connection = Constante.mySqlConnection;
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    string functie = mySqlDataReader.GetString(0);
                    Functie.Items.Add(functie);
                }
                Constante.mySqlConnection.Close();
            }
            catch (MySqlException E)
            {
                throw E;
            }
        }

        private int IdFunctie(string denumire)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "select id_functie from functie where denumire=@denumire";
                mySqlCommand.Parameters.AddWithValue("@denumire", denumire);
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
            }
            catch(MySqlException E)
            {
                throw E;
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string nume = Nume.Text;
            string prenume = Prenume.Text;
            string adresa = Adresa.Text;
            int varsta = Int32.Parse(Varsta.Text);
            string telefon = Telefon.Text;
            string cnp = CNP.Text;
            if (!Constante.EmailValidate(Email.Text))
            {
                MessageBox.Show("Introduceti un email valid");
                Email.Focus();
                return;
            }
            if (varsta < 18 || varsta > 80)
            {
                MessageBox.Show("Varsta trebuie sa fie cuprinsa intre 18-80 de ani");
                Varsta.Focus();
                return;
            }
            if (CNP.Text.Length != 13)
            {
                MessageBox.Show("CNP invalid. CNP-ul trebuie sa contina 13 cifre");
                CNP.Focus();
                return;
            }
            string email = Email.Text;
            string data = Data.Value.ToString("dd-MMM-yyyy");
            int durata = Int32.Parse(Durata.Text);
            if (durata > 5)
            {
                MessageBox.Show("Durata contractului nu poate depasii 5 ani");
                Durata.Focus();
                return;
            }
            Object functie = Functie.SelectedItem;
            try
            {
                string insert = "Insert into angajat(nume,prenume,adresa,varsta,telefon,cnp,email,data_angajarii,durata_contract,id_functie) " +
                    "values(@nume,@prenume,@adresa,@varsta,@telefon,@cnp,@email,@data,@durata,@id_functie);";
                MySqlCommand mySqlCommand = new MySqlCommand(insert, Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@nume", nume);
                mySqlCommand.Parameters.AddWithValue("@prenume", prenume);
                mySqlCommand.Parameters.AddWithValue("@adresa", adresa);
                mySqlCommand.Parameters.AddWithValue("@varsta", varsta);
                mySqlCommand.Parameters.AddWithValue("@telefon", telefon);
                mySqlCommand.Parameters.AddWithValue("@cnp", cnp);
                mySqlCommand.Parameters.AddWithValue("@email", email);
                mySqlCommand.Parameters.AddWithValue("@data", data);
                mySqlCommand.Parameters.AddWithValue("@durata", durata);
                mySqlCommand.Parameters.AddWithValue("@id_functie", IdFunctie(functie.ToString()));
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                Constante.mySqlConnection.Close();
            }
            catch(MySqlException E)
            {
                throw E;
            }

            try
            {
                string update = "Update departament set numar_angajati=numar_angajati+1 where Id_departament=(select Id_departament from functie where Id_functie=@id_functie)";
                MySqlCommand mySqlCommand2 = new MySqlCommand(update, Constante.mySqlConnection);
                mySqlCommand2.Parameters.AddWithValue("@id_functie", IdFunctie(functie.ToString()));
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader2 = mySqlCommand2.ExecuteReader();
                Constante.mySqlConnection.Close();
            }catch(MySqlException Ex)
            {
                throw Ex;
            }
            Constante.Log("IntroducereAngajat", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);

            MessageBox.Show("Inserare realizată cu succes");
            Close();
        }

        private void Nume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

        private void Prenume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Varsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Durata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
