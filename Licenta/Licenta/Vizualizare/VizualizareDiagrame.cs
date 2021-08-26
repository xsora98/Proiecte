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

namespace Licenta.Vizualizare
{
    public partial class VizualizareDiagrame : Form
    {
        public VizualizareDiagrame()
        {
            InitializeComponent();
        }

        private void VizualizareDiagrame_Load(object sender, EventArgs e)
        {
            PopulateDiagProduse();
        }

        private void PopulateDiagProduse()
        {
            Diagrama.Titles.Clear();
            Diagrama.Titles.Add("Diagrama produse");
            foreach (var series in Diagrama.Series)
            {
                series.Points.Clear();
            }
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT DISTINCT p.Producator ,p.Denumire ,sum(v.Cantitate) from vanzare v, produs p where v.Id_produs=p.Id_produs group by p.denumire", Constante.mySqlConnection);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Diagrama.Series["Produs"].Points.AddXY(mySqlDataReader.GetString(0) + " " + mySqlDataReader.GetString(1)+":"+mySqlDataReader.GetInt32(2), mySqlDataReader.GetInt32(2));
                }
                Constante.mySqlConnection.Close();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void PopulateDiagMarimi()
        {
            Diagrama.Titles.Clear();
            Diagrama.Titles.Add("Diagrama marimi");
            foreach (var series in Diagrama.Series)
            {
                series.Points.Clear();
            }
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT v.marime,sum(v.Cantitate) from vanzare v, produs p where v.Id_produs=p.Id_produs group by v.marime", Constante.mySqlConnection);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Diagrama.Series["Marimi"].Points.AddXY("M: " + mySqlDataReader.GetInt32(0) + " : " + mySqlDataReader.GetInt32(1), mySqlDataReader.GetInt32(1));
                }
                Constante.mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void PopulateDiagChestionar()
        {
            Diagrama.Titles.Clear();
            Diagrama.Titles.Add("Diagrama chestionar - media raspunsurilor");
            foreach (var series in Diagrama.Series)
            {
                series.Points.Clear();
            }
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT AVG(Intrebarea1), AVG(Intrebarea2), AVG(Intrebarea3) from chestionar", Constante.mySqlConnection);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    Diagrama.Series["Chestionar"].Points.AddXY("Calitatea serviciilor: " + mySqlDataReader.GetInt32(0), mySqlDataReader.GetInt32(0));
                    Diagrama.Series["Chestionar"].Points.AddXY("Rapiditate: " + mySqlDataReader.GetInt32(1), mySqlDataReader.GetInt32(1));
                    Diagrama.Series["Chestionar"].Points.AddXY("Comportamentul angajatilor: " + mySqlDataReader.GetInt32(2), mySqlDataReader.GetInt32(2));
                }
                Constante.mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateDiagProduse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopulateDiagMarimi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopulateDiagChestionar();
        }
    }
}
