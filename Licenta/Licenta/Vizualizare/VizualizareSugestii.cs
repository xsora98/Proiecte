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

namespace Licenta.Vizualizare
{
    public partial class VizualizareSugestii : Form
    {
        public VizualizareSugestii()
        {
            InitializeComponent();
        }

        private void VizualizareSugestii_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select sugestie as 'Sugestie' from chestionar where sugestie<>''", Constante.mySqlConnection);
                Constante.mySqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "departament");
                dataGridView1.DataSource = ds.Tables["departament"];
                Constante.mySqlConnection.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
