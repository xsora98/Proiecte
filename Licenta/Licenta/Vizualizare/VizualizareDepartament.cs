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
    public partial class VizualizareDepartament : Form
    {
        public string queryConditions = "";
        public string select = "Select id_departament as 'ID',denumire as 'Denumire',numar_angajati as 'Numar de angajati' from departament where 1 ";
        public VizualizareDepartament()
        {
            InitializeComponent();
        }

        private void VizualizareDepartament_Load(object sender, EventArgs e)
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
                adapter.Fill(ds, "departament");
                dataGridView1.DataSource = ds.Tables["departament"];
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
                queryConditions += "and denumire=\'" + Denumire.Text + "\' ";
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
