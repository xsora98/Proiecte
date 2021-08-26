using Licenta.Modificare;
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
    public partial class VizualizareAngajat : Form
    {
        public static int id_angajat_redirect;
        public string queryConditions = "";
        public string select = "Select id_angajat as 'ID',nume as 'Nume',prenume as 'Prenume',adresa as 'Adresa',varsta as 'Varsta',telefon as 'Telefon',cnp as 'CNP',email as 'Email' ,data_angajarii as 'Data angajarii' , durata_contract as 'Durata contract', f.denumire as 'Functie' from angajat a,functie f where f.Id_functie=a.Id_functie ";
        public VizualizareAngajat()
        {
            InitializeComponent();
        }

        private void VizualizareAngajat_Load(object sender, EventArgs e)
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
                adapter.Fill(ds, "angajat");
                dataGridView1.DataSource = ds.Tables["angajat"];
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

            if (Cnp.Text != "")
            {
                queryConditions += "and cnp=" + Cnp.Text + " ";
            }

            Populare(select, queryConditions);
        }

        private void ArataTot_Click(object sender, EventArgs e)
        {
            queryConditions = "";
            Populare(select, queryConditions);
        }

        private void Modifica_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            id_angajat_redirect = Int32.Parse(Convert.ToString(selectedRow.Cells[0].Value));
            ModificareAngajat modificareAngajat = new ModificareAngajat();
            modificareAngajat.ShowDialog();
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int id_angajat = Int32.Parse(Convert.ToString(selectedRow.Cells[0].Value));
            try
            {
                string delete = "delete from angajat where id_angajat=@id_angajat;";
                MySqlCommand mySqlCommand = new MySqlCommand(delete, Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@id_angajat", id_angajat);
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
                string resetAI = "ALTER TABLE angajat AUTO_INCREMENT = 0";
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
            if (char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cnp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
