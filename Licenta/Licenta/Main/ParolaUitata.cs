using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licenta
{
    public partial class ParolaUitata : Form
    {
        public ParolaUitata()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string email = Email.Text;
            if (!Constante.EmailValidate(email))
            {
                MessageBox.Show("Introduceti un email valid");
                Email.Focus();
                return;
            }
            Random random = new Random();
            string cod = "";
            for(int i = 0; i < 10; i++)
            {
                cod += random.Next(0, 9).ToString();
            }
            IntroducereUtilizator verificare = new IntroducereUtilizator();
            if (verificare.VerificareEmail(email))
            {
                string insert = "Update utilizator set cod_parola=@cod_parola where email=@email";
                MySqlCommand command = new MySqlCommand(insert, Constante.mySqlConnection);
                command.Parameters.AddWithValue("@cod_parola", cod);
                command.Parameters.AddWithValue("@email", email);
                Constante.mySqlConnection.Open();
                MySqlDataReader execute = command.ExecuteReader();
                Constante.mySqlConnection.Close();

                MailMessage mesaj = new MailMessage();
                mesaj.From = new MailAddress("licenta98@gmail.com");
                mesaj.To.Add(email);
                mesaj.Subject = "Detalii Cont";
                mesaj.Body = "Codul dumneavoastra pentru schimbarea parolei este:  " + cod ;
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("licenta98@gmail.com", "Sora1998!");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(mesaj);

                MessageBox.Show("Veti primi la scurt timp un mesaj pe email cu codul necesar pentru schimbarea parolei! Va rugam sa introduceti acest cod in fereastra urmatoare! Acest cod este valabil o singura data!");
                CodParola codParola = new CodParola();
                this.Visible = false;
                codParola.ShowDialog();
            }
        }

        private void CodExistent_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CodParola codParola = new CodParola();
            codParola.ShowDialog();
        }
    }
}
