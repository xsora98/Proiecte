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
    public partial class VizualizareProduseVandute : Form
    {
        public string queryConditions = "";
        public string select = "SELECT v.Id_vanzare as 'Id',p.Producator as 'Producator',p.Denumire as 'Denumire',p.Tip as 'Tip',p.Sex as 'Sex',d.Denumire as 'Distribuitor',v.Marime as 'Marime',v.Cantitate as 'Cantitate',v.Id_Bon as 'Id bon' from vanzare v, produs p,distribuitor d where v.Id_produs=p.Id_produs and p.Id_distribuitor=d.Id_distribuitor ";
        public VizualizareProduseVandute()
        {
            InitializeComponent();
        }

        private void VizualizareProduseVandute_Load(object sender, EventArgs e)
        {
            PopulateProduseVandute(select, queryConditions);
            PopulateDistribuitor();
        }

        private void PopulateProduseVandute(string select,string queryConditions)
        {
            try
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(select + queryConditions, Constante.mySqlConnection);
                Constante.mySqlConnection.Open();
                DataSet ds = new DataSet();
                mySqlDataAdapter.Fill(ds, "vanzare");
                dataGridView1.DataSource = ds.Tables["vanzare"];
                Constante.mySqlConnection.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void PopulateDistribuitor()
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("Select denumire from distribuitor", Constante.mySqlConnection);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Distribuitor.Items.Add(mySqlDataReader.GetString(0));
                }
                Constante.mySqlConnection.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void Cauta_Click(object sender, EventArgs e)
        {
            queryConditions = "";
            if (Producator.Text != "")
            {
                queryConditions += "and p.producator=\'" + Producator.Text + "\' ";
            }

            if (Denumire.Text != "")
            {
                queryConditions += "and p.denumire=\'" + Denumire.Text + "\' ";
            }

            if (Tip.SelectedItem !=null)
            {
                queryConditions += "and p.tip=\'" + Tip.SelectedItem.ToString() + "\' ";
            }

            if (Sex.SelectedItem != null)
            {
                queryConditions += "and p.sex=\'" + Sex.SelectedItem.ToString()+ "\' ";
            }

            if (Distribuitor.SelectedItem != null)
            {
                queryConditions += "and d.denumire=\'" + Distribuitor.SelectedItem.ToString() + "\' ";
            }

            if (Bon.Text != "")
            {
                queryConditions += "and v.id_bon=\'" + Bon.Text + "\' ";
            }
            PopulateProduseVandute(select, queryConditions);
        }

        private void ArataTot_Click(object sender, EventArgs e)
        {
            queryConditions = "";
            PopulateProduseVandute(select, queryConditions);
        }

        private void Diagrame_Click(object sender, EventArgs e)
        {
            VizualizareDiagrame vizualizareDiagrame = new VizualizareDiagrame();
            vizualizareDiagrame.ShowDialog();
        }

        private void Producator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Bon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
