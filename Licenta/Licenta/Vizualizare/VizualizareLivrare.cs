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
    public partial class VizualizareLivrare : Form
    {
        public string queryConditions = "";
        public string select = "Select id_livrare as 'ID',nume as 'Nume',Prenume as 'Prenume',email as 'Email',adresa as 'Adresa',id_bon as 'ID comanda' from livrare where 1 ";
        public VizualizareLivrare()
        {
            InitializeComponent();
        }

        private void VizualizareLivrare_Load(object sender, EventArgs e)
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
                adapter.Fill(ds, "livrare");
                dataGridView1.DataSource = ds.Tables["livrare"];
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
            if (Nume.Text != "")
            {
                queryConditions += "and nume=\'" + Nume.Text + "\' ";
            }
            if (Prenume.Text != "")
            {
                queryConditions += "and prenume=\'" + Prenume.Text + "\' ";
            }
            if (IdComanda.Text != "")
            {
                queryConditions += "and id_bon=" + IdComanda.Text;
            }
            Populare(select, queryConditions);
        }

        private void ArataTot_Click(object sender, EventArgs e)
        {
            queryConditions = "";
            Populare(select, queryConditions);
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
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void IdComanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
