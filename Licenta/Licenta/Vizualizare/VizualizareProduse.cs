using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Licenta.Modificare;
using MySql.Data.MySqlClient;

namespace Licenta
{
    public partial class VizualizareProduse : Form
    {
        public VizualizareProduse()
        {
            InitializeComponent();
        }

        public static int id_produs_redirect,pret_redirect;
        public static string denumire_redirect,producator_redirect,tip_redirect,sex_redirect,distribuitor_redirect; 
        public string queryConditions = "";
        public string select= "Select id_produs as 'ID',imagine as 'Imagine',p.denumire as 'Denumire',producator as 'Producator',tip as 'Tip',sex as 'Sex',pret as 'Pret',d.denumire as 'Distribuitor',qrcode as 'QR' from produs p,distribuitor d where d.Id_distribuitor=p.Id_distribuitor ";
        private void VizualizareProduse_Load(object sender, EventArgs e)
        {
            Populare(select,queryConditions);
        }


        private void Populare(string query,string queryCond)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query+queryCond, Constante.mySqlConnection);
                Constante.mySqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "produs");
                dataGridView1.DataSource = ds.Tables["produs"];
                DataGridViewImageColumn imagine = new DataGridViewImageColumn();
                imagine = (DataGridViewImageColumn)dataGridView1.Columns[1];
                imagine.ImageLayout = DataGridViewImageCellLayout.Stretch;
                imagine.Width = 250;
                DataGridViewImageColumn qr = new DataGridViewImageColumn();
                qr = (DataGridViewImageColumn)dataGridView1.Columns[8];
                qr.ImageLayout = DataGridViewImageCellLayout.Stretch;
                qr.Width = 250;
                Constante.mySqlConnection.Close();

            }catch (Exception ex)
            {
                throw ex;
            }
        }
        private string VerificareProdus(int id_produs)
        {
            int marime, stoc;
            string marimi_disponibile = "";
            try
            {
                
                Constante.mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "Select nr_marime,stoc from marime where id_produs=@id_produs";
                mySqlCommand.Parameters.AddWithValue("@id_produs", id_produs);
                mySqlCommand.Connection = Constante.mySqlConnection;
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    marime = mySqlDataReader.GetInt32(0);
                    stoc = mySqlDataReader.GetInt32(1);
                    marimi_disponibile += "Marime: " + marime + " - Stoc: " + stoc + "\n";
                }

                Constante.mySqlConnection.Close();
                return marimi_disponibile;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void ModificaImagine_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            id_produs_redirect = Int32.Parse(Convert.ToString(selectedRow.Cells[0].Value));
            ModificareImagine modificareImagine = new ModificareImagine();
            modificareImagine.ShowDialog();
        }

        private void Producator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Aprovizionare_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            id_produs_redirect = Int32.Parse(Convert.ToString(selectedRow.Cells[0].Value));
            Aprovizionare aprovizionare = new Aprovizionare();
            aprovizionare.ShowDialog();
        }

        private void VerificareStoc_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int id_produs = Int32.Parse(Convert.ToString(selectedRow.Cells[0].Value));

            MessageBox.Show(VerificareProdus(id_produs));
        }


        private void cauta_Click(object sender, EventArgs e)
        {
            queryConditions = "";
            string denumire = Denumire.Text;
            string producator = Producator.Text;

            if (denumire != "")
            {
                queryConditions += "and p.denumire=\'" + denumire + "\' ";
            }

            if (producator != "")
            {
                queryConditions += "and producator=\'" + producator + "\' ";
            }

            if (Tip.SelectedItem!=null)
            {
                string tip = Tip.SelectedItem.ToString();
                queryConditions += "and tip=\'" + tip + "\' ";
            }
            if (Sex.SelectedItem != null)
            {
                string sex = Sex.SelectedItem.ToString();
                queryConditions += "and sex=\'" + sex + "\' ";
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
            id_produs_redirect = Int32.Parse(Convert.ToString(selectedRow.Cells[0].Value));
            denumire_redirect = Convert.ToString(selectedRow.Cells[2].Value);
            producator_redirect = Convert.ToString(selectedRow.Cells[3].Value);
            tip_redirect = Convert.ToString(selectedRow.Cells[4].Value);
            sex_redirect = Convert.ToString(selectedRow.Cells[5].Value);
            pret_redirect = Int32.Parse(Convert.ToString(selectedRow.Cells[6].Value));
            distribuitor_redirect = Convert.ToString(selectedRow.Cells[7].Value);
            ModificareProdus modificareProdus = new ModificareProdus();
            modificareProdus.ShowDialog();
        }
    }
}
