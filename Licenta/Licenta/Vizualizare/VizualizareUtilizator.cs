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
    public partial class VizualizareUtilizator : Form
    {
        public string queryConditions = "";
        public string select = "Select id_utilizator as 'ID', nume as 'Nume',prenume as 'Prenume' , varsta as 'Varsta' , email as 'Email' ,nume_utilizator as 'Username',rol as 'Rol' from utilizator where 1 ";
        public VizualizareUtilizator()
        {
            InitializeComponent();
        }

        private void VizualizareUtilizator_Load(object sender, EventArgs e)
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
                adapter.Fill(ds, "utilizator");
                dataGridView1.DataSource = ds.Tables["utilizator"];
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

            if (Email.Text != "")
            {
                queryConditions += "and email=\'" + Email.Text + "\' ";
            }
            if(Nume.Text=="" && Prenume.Text=="" && Email.Text == "")
            {
                MessageBox.Show("Introduceti date pentru cautare");
            }
            Populare(select, queryConditions);
        }

        private void ArataTot_Click(object sender, EventArgs e)
        {
            queryConditions = "";
            Populare(select, queryConditions);
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int id_utilizator = Int32.Parse(Convert.ToString(selectedRow.Cells[0].Value));
            try
            {
                string delete = "delete from utilizator where id_utilizator=@id_utilizator;";
                MySqlCommand mySqlCommand = new MySqlCommand(delete, Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@id_utilizator", id_utilizator);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                Constante.mySqlConnection.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            try
            {
                string resetAI = "ALTER TABLE utilizator AUTO_INCREMENT = 0";
                MySqlCommand mySqlCommand2 = new MySqlCommand(resetAI, Constante.mySqlConnection);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader2 = mySqlCommand2.ExecuteReader();
                Constante.mySqlConnection.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
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
    }
}
