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
    public partial class VizualizareDistribuitor : Form
    {
        public string queryConditions = "";
        public string select = "Select id_distribuitor as 'ID',denumire as 'Denumire',adresa as 'Adresa distribuitor' from distribuitor where 1 ";
        public VizualizareDistribuitor()
        {
            InitializeComponent();
        }

        private void VizualizareDistribuitor_Load(object sender, EventArgs e)
        {
            Populare(select, queryConditions);
        }

        private void Populare(string query, string queryCond)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query + queryCond, Constante.mySqlConnection);
                Constante.mySqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "distribuitor");
                dataGridView1.DataSource = ds.Tables["distribuitor"];
                Constante.mySqlConnection.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Cauta_Click(object sender, EventArgs e)
        {
            queryConditions = "";
            if (Denumire.Text != "")
            {
                queryConditions+="and denumire=\'"+Denumire.Text+"\' ";
            }
            else
            {
                MessageBox.Show("Introduceti o denumire");
                return;
            }
            Populare(select, queryConditions);
        }

        private void ArataTot_Click(object sender, EventArgs e)
        {
            queryConditions = "";
            Populare(select, queryConditions);
        }

        private void Denumire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
