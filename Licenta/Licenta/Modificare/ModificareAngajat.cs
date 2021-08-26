using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Licenta.Vizualizare;
using MySql.Data.MySqlClient;

namespace Licenta.Modificare
{
    public partial class ModificareAngajat : Form
    {
        public ModificareAngajat()
        {
            InitializeComponent();
        }


        private void ModificareAngajat_Load(object sender, EventArgs e)
        {
            PopulateFunctie();
        }

        public void PopulateFunctie()
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
                    Functie.Items.Add(mySqlDataReader.GetString(0));
                }
                Constante.mySqlConnection.Close();
            }catch(Exception ex)
            {
                throw ex;
            }
            
        }
        private void Modifica_Click(object sender, EventArgs e)
        {
            string update = "update angajat set";
            int modificariFacute = 0;
            if (NumeCheck.Checked.Equals(true))
            {
                if (Nume.Text != "")
                {
                    modificariFacute++;
                    update += " nume=\'" + Nume.Text + "\' ,";
                }
                else
                {
                    MessageBox.Show("Introduceti un nume!");
                    return;
                }
            }
            if (PrenumeCheck.Checked.Equals(true))
            {
                if (Prenume.Text != "")
                {
                    modificariFacute++;
                    update += " prenume=\'" + Prenume.Text + "\' ,";
                }
                else
                {
                    MessageBox.Show("Introduceti un prenume!");
                    return;
                }
            }
            if (AdresaCheck.Checked.Equals(true))
            {
                if (Adresa.Text != "")
                {
                    modificariFacute++;
                    update += " adresa=\'" + Adresa.Text + "\' ,";
                }
                else
                {
                    MessageBox.Show("Introduceti o adresa!");
                    return;
                }
            }
            if (TelefonCheck.Checked.Equals(true))
            {
                if (Telefon.Text != "")
                {
                    modificariFacute++;
                    update += " telefon=" + Telefon.Text + " ,";
                }
                else
                {
                    MessageBox.Show("Introduceti un numar de telefon!");
                    return;
                }
            }
            if (CnpCheck.Checked.Equals(true))
            {
                if (CNP.Text != "" && CNP.Text.Length==13)
                {
                    modificariFacute++;
                    update += " cnp=" + CNP.Text + " ,";
                }
                else
                {
                    MessageBox.Show("Introduceti un CNP valid!");
                    return;
                }
            }
            if (EmailCheck.Checked.Equals(true))
            {

                if (Email.Text != "")
                {
                    if (!Constante.EmailValidate(Email.Text))
                    {
                        MessageBox.Show("Introduceti un email valid");
                        Email.Focus();
                        return;
                    }
                    modificariFacute++;
                    update += " email=\'" + Email.Text + "\' ,";
                }
                else
                {
                    MessageBox.Show("Introduceti un email");
                    return;
                }
            }
            if (FunctieCheck.Checked.Equals(true))
            {
                if (Functie.SelectedItem != null)
                {
                    modificariFacute++;
                    update += " id_functie=(SELECT Id_functie from functie where denumire=\'" + Functie.Text + "\') ,";
                }
                else
                {
                    MessageBox.Show("Selectati o functie!");
                    return;
                }
            }
            if (modificariFacute == 0)
            {
                MessageBox.Show("Selecteaza cel putin o modificare!");
                return;
            }

            update = update.Remove(update.Length - 1);
            update += "where id_angajat=@id_angajat";
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(update,Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@id_angajat", VizualizareAngajat.id_angajat_redirect);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                Constante.mySqlConnection.Close();
                Constante.Log("ModificareAngajat", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void NumeCheck_CheckedChanged(object sender, EventArgs e)
        {
            Nume.Enabled = !Nume.Enabled;
        }

        private void PrenumeCheck_CheckedChanged(object sender, EventArgs e)
        {
            Prenume.Enabled = !Prenume.Enabled;
        }

        private void AdresaCheck_CheckedChanged(object sender, EventArgs e)
        {
            Adresa.Enabled = !Adresa.Enabled;
        }

        private void TelefonCheck_CheckedChanged(object sender, EventArgs e)
        {
            Telefon.Enabled = !Telefon.Enabled;
        }

        private void CnpCheck_CheckedChanged(object sender, EventArgs e)
        {
            CNP.Enabled = !CNP.Enabled;
        }

        private void EmailCheck_CheckedChanged(object sender, EventArgs e)
        {
            Email.Enabled = !Email.Enabled;
        }

        private void FunctieCheck_CheckedChanged(object sender, EventArgs e)
        {
            Functie.Enabled = !Functie.Enabled;
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

        private void Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
