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
using System.Net;
using System.Net.Mail;

namespace Licenta
{
    public partial class IntroducereUtilizator : Form
    {

        public IntroducereUtilizator()
        {
            InitializeComponent();
        }


        public bool VerificareEmail(string email)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "Select id_utilizator from utilizator where email=@email";
            command.Parameters.AddWithValue("@email", email);
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

        private string GenerareUtilizator(string nume, string prenume)
        {
            string username = "";
            Random random = new Random();
            int nr = random.Next(1, 500);
            username += prenume[0].ToString().ToLower();
            username += nume;
            username += nr;

            return username;
        }

        private string GenerareParola()
        {
            string parola = "";
            string sir = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            Random random = new Random();
            int nr = random.Next(0, sir.Length);
            for(int i=0; i < 10; i++)
            {
                parola += sir[nr];
                nr = random.Next(0, sir.Length);
            }

            return parola;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string nume = Nume.Text;
            string prenume = Prenume.Text;
            string adresa = Adresa.Text;
            int varsta = Int32.Parse(Varsta.Text);
            if (varsta < 18 || varsta > 80)
            {
                MessageBox.Show("Varsta trebuie sa fie cuprinsa intre 18-80 de ani");
                Varsta.Focus();
                return;
            }
            if (!Constante.EmailValidate(Email.Text))
            {
                MessageBox.Show("Introduceti un email valid");
                Email.Focus();
                return;
            }
            string email = Email.Text;
            Object rol = Rol.SelectedItem;

            if (VerificareEmail(email))
            {
                MessageBox.Show("Email-ul introdus este utilizat!");
                return ;
            }

            string username = GenerareUtilizator(nume, prenume);
            string parola = GenerareParola();
            LoginPanel criptare = new LoginPanel();


            try
            {
                string insert = "Insert into utilizator(nume,prenume,adresa,varsta,email,nume_utilizator,parola,rol) values(@nume,@prenume,@adresa,@varsta,@email,@nume_utilizator,@parola,@rol);";
                MySqlCommand command = new MySqlCommand(insert, Constante.mySqlConnection);
                command.Parameters.AddWithValue("@nume", nume);
                command.Parameters.AddWithValue("@prenume", prenume);
                command.Parameters.AddWithValue("@adresa", adresa);
                command.Parameters.AddWithValue("@varsta", varsta);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@nume_utilizator", username);
                command.Parameters.AddWithValue("@parola", criptare.CriptareParola(parola));
                command.Parameters.AddWithValue("@rol", rol);
                Constante.mySqlConnection.Open();
                MySqlDataReader execute = command.ExecuteReader();
                Constante.mySqlConnection.Close();

                MailMessage mesaj = new MailMessage();
                mesaj.From = new MailAddress("licenta98@gmail.com");
                mesaj.To.Add(email);
                mesaj.Subject = "Detalii Cont";
                mesaj.Body = "Detaliile contului dumneavoastră sunt: \nUsername: "+username+"\nPassword: "+parola;
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587; 
                smtp.Host = "smtp.gmail.com";
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("licenta98@gmail.com","Sora1998!");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(mesaj);

                Constante.Log("IntroducereUtilizator", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
                MessageBox.Show("Inserare realizată cu succes!");
                Close();
            }catch(MySqlException E)
            {
                throw E;
            }
        }

        private void Nume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
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
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
