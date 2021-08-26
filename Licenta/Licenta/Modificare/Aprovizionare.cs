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

namespace Licenta.Modificare
{
    public partial class Aprovizionare : Form
    {
        public Aprovizionare()
        {
            InitializeComponent();
        }

        private void ActualizareStoc_Click(object sender, EventArgs e)
        {
            ActualizarePanel.Visible = true;
            AdaugaPanel.Visible = false;
            Marime.Items.Clear();
            PopulareMarimi(VizualizareProduse.id_produs_redirect);
        }

        private void MarimiNoi_Click(object sender, EventArgs e)
        {
            AdaugaPanel.Visible = true;
            ActualizarePanel.Visible = false;
            MarimeExistenta.Text = "";
            MarimiExistente(VizualizareProduse.id_produs_redirect);
        }

        private void PopulareMarimi(int id_produs)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "Select nr_marime from marime where id_produs=@id_produs";
                mySqlCommand.Parameters.AddWithValue("@id_produs", id_produs);
                mySqlCommand.Connection = Constante.mySqlConnection;
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    int marime = mySqlDataReader.GetInt32(0);
                    Marime.Items.Add(marime);
                }
                Constante.mySqlConnection.Close();
            }
            catch (MySqlException E)
            {
                throw E;
            }
        }

        private void MarimiExistente(int id_produs)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "Select nr_marime from marime where id_produs=@id_produs";
                mySqlCommand.Parameters.AddWithValue("@id_produs", id_produs);
                mySqlCommand.Connection = Constante.mySqlConnection;
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    MarimeExistenta.Text += mySqlDataReader.GetInt32(0) + " ";
                }
                Constante.mySqlConnection.Close();
            }
            catch (MySqlException E)
            {
                throw E;
            }
        }

        private bool ValitateMarime(int marime,int id_produs)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "Select nr_marime from marime where nr_marime=@nr_marime and id_produs=@id_produs";
                mySqlCommand.Parameters.AddWithValue("@nr_marime", marime);
                mySqlCommand.Parameters.AddWithValue("@id_produs", id_produs);
                mySqlCommand.Connection = Constante.mySqlConnection;
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();             
                if (mySqlDataReader.Read())
                {
                    Constante.mySqlConnection.Close();
                    return true ;
                }
                else
                {
                    Constante.mySqlConnection.Close();
                    return false;
                }
                
            }
            catch (MySqlException E)
            {
                throw E;
            }
        }

        private void Actualizeaza_Click(object sender, EventArgs e)
        {
            if (Marime.SelectedItem != null && Stoc.Value!=0)
            {
                try
                {
                    MySqlCommand mySqlCommand = new MySqlCommand();
                    mySqlCommand.CommandText = "update marime set stoc=stoc+@stoc where nr_marime=@nr_marime and id_produs=@id_produs";
                    mySqlCommand.Parameters.AddWithValue("@stoc",Stoc.Value);
                    mySqlCommand.Parameters.AddWithValue("@nr_marime", Int32.Parse(Marime.SelectedItem.ToString()));
                    mySqlCommand.Parameters.AddWithValue("@id_produs", VizualizareProduse.id_produs_redirect);
                    mySqlCommand.Connection = Constante.mySqlConnection;
                    Constante.mySqlConnection.Open();
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    Constante.mySqlConnection.Close();
                    Constante.Log("AprovizionareStoc", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
                    MessageBox.Show("Actualizare realizată cu succes");
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Selectati o valoare");
            }
        }

        private void Adauga_Click(object sender, EventArgs e)
        {
            if (ValitateMarime(Convert.ToInt32(MarimeNoua.Value), VizualizareProduse.id_produs_redirect))
            {
                MessageBox.Show("Marimea exista deja");
            }
            else if(!ValitateMarime(Convert.ToInt32(MarimeNoua.Value), VizualizareProduse.id_produs_redirect) && StocNou.Value==0)
            {
                MessageBox.Show("Stocul nu poate fi 0");
            }
            else
            {
                try
                {
                    MySqlCommand mySqlCommand = new MySqlCommand();
                    mySqlCommand.CommandText = "insert into marime(nr_marime,stoc,id_produs) values(@nr_marime,@stoc,@id_produs);";
                    mySqlCommand.Parameters.AddWithValue("@nr_marime", MarimeNoua.Value);
                    mySqlCommand.Parameters.AddWithValue("@stoc", StocNou.Value);
                    mySqlCommand.Parameters.AddWithValue("@id_produs", VizualizareProduse.id_produs_redirect);
                    mySqlCommand.Connection = Constante.mySqlConnection;
                    Constante.mySqlConnection.Open();
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    Constante.mySqlConnection.Close();
                    Constante.Log("AprovizionareMarimi", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
                    MessageBox.Show("Adaugare realizată cu succes");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
