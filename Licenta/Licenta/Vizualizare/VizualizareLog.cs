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
    public partial class VizualizareLog : Form
    {
        public string queryConditions = "";
        public string select = "Select id_log as 'ID',actiune as 'Actiune',data as 'Data',id_utilizator as 'Id utilizator' from log where 1 ";
        public VizualizareLog()
        {
            InitializeComponent();
        }

        private void VizualizareLog_Load(object sender, EventArgs e)
        {
            Populate(select,queryConditions);
        }

        private void Populate(string query,string queryCond)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query + queryCond, Constante.mySqlConnection);
                Constante.mySqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "log");
                dataGridView1.DataSource = ds.Tables["log"];
                Constante.mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ArataTot_Click(object sender, EventArgs e)
        {
            queryConditions = "";
            Populate(select, queryConditions);
        }

        private void Cauta_Click(object sender, EventArgs e)
        {
            queryConditions = "";
            if (Idsearch.Text != "")
            {
                queryConditions += "and id_utilizator=" + Idsearch.Text;
            }
            Populate(select, queryConditions);
        }

        private void Idsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
