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

namespace Licenta.Introducere
{
    public partial class IntroducereMarimeCantitate : Form
    {
        public static int marime_redirect;
        public static int cantitate_redirect;
        public static bool start_stop;
        public static int stoc_redirect;
        public static int pret_redirect;
        public IntroducereMarimeCantitate()
        {
            InitializeComponent();
        }

        public void PopulateMarimi(int id_produs)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("Select nr_marime from marime where id_produs=@id_produs and stoc>0 order by nr_marime ASC", Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@id_produs", id_produs);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Marime.Items.Add(mySqlDataReader.GetString(0));
                }
                Constante.mySqlConnection.Close();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private int Stoc(int marime, int id_produs)
        {
            int x=0;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("Select stoc from marime where nr_marime=@nr_marime and id_produs=@id_produs",Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@nr_marime",marime);
                mySqlCommand.Parameters.AddWithValue("@id_produs", id_produs);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    x = mySqlDataReader.GetInt32(0);
                    Constante.mySqlConnection.Close();
                }  
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return x;
        }

        public int PretProdus(int id_produs)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("Select pret from produs where id_produs=@id_produs", Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@id_produs", id_produs);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    int x = mySqlDataReader.GetInt32(0);
                    Constante.mySqlConnection.Close();
                    return x;
                }
                else
                {
                    Constante.mySqlConnection.Close();
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            int stoc = Stoc(Int32.Parse(Marime.SelectedItem.ToString()), IntroducereVanzare.id_produs_redirect);
            if (stoc==0)
            {
                MessageBox.Show("Nu exista marimea");
            }else if(stoc < Cantitate.Value)
            {
                MessageBox.Show("Cantitatea dorita este mai mare decat stocul disponibil: "+stoc);
            }
            else
            {
                marime_redirect = Int32.Parse(Marime.SelectedItem.ToString());
                cantitate_redirect = Convert.ToInt32(Cantitate.Value);
                pret_redirect = PretProdus(IntroducereVanzare.id_produs_redirect);
                stoc_redirect = stoc;
                start_stop = true;
                this.Close();
            }
        }

        private void IntroducereMarimeCantitate_Load(object sender, EventArgs e)
        {
            marime_redirect = 0;
            cantitate_redirect = 0;
            stoc_redirect = 0;
            pret_redirect = 0;
            start_stop = false;          
            PopulateMarimi(IntroducereVanzare.id_produs_redirect);
        }

        private void IntroducereMarimeCantitate_FormClosed(object sender, FormClosedEventArgs e)
        {
            start_stop = true;
        }
    }
}
