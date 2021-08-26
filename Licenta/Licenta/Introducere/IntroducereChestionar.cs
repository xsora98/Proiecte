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

namespace Licenta.Introducere
{
    public partial class IntroducereChestionar : Form
    {
        public int intrebare1 = 0;
        public int intrebare2 = 0;
        public int intrebare3 = 0;
        public IntroducereChestionar()
        {
            InitializeComponent();
        }

        private void A11_CheckedChanged(object sender, EventArgs e)
        {
            if (A11.Checked)
            {
                intrebare1 = 1;
                A12.Enabled=false;
                A13.Enabled = false;
                A14.Enabled = false;
                A15.Enabled = false;
            }
            else
            {
                intrebare1 = 0;
                A12.Enabled = true;
                A13.Enabled = true;
                A14.Enabled = true;
                A15.Enabled = true;
            }
        }

        private void A12_CheckedChanged(object sender, EventArgs e)
        {
            if (A12.Checked)
            {
                intrebare1 = 2;
                A11.Enabled = false;
                A13.Enabled = false;
                A14.Enabled = false;
                A15.Enabled = false;
            }
            else
            {
                intrebare1 = 0;
                A11.Enabled = true;
                A13.Enabled = true;
                A14.Enabled = true;
                A15.Enabled = true;
            }
        }

        private void A13_CheckedChanged(object sender, EventArgs e)
        {
            if (A13.Checked)
            {
                intrebare1 = 3;
                A11.Enabled = false;
                A12.Enabled = false;
                A14.Enabled = false;
                A15.Enabled = false;
            }
            else
            {
                intrebare1 = 0;
                A11.Enabled = true;
                A12.Enabled = true;
                A14.Enabled = true;
                A15.Enabled = true;
            }
        }

        private void A14_CheckedChanged(object sender, EventArgs e)
        {
            if (A14.Checked)
            {
                intrebare1 = 4;
                A11.Enabled = false;
                A12.Enabled = false;
                A13.Enabled = false;
                A15.Enabled = false;
            }
            else
            {
                intrebare1 = 0;
                A11.Enabled = true;
                A12.Enabled = true;
                A13.Enabled = true;
                A15.Enabled = true;
            }
        }

        private void A15_CheckedChanged(object sender, EventArgs e)
        {
            if (A15.Checked)
            {
                intrebare1 = 5;
                A11.Enabled = false;
                A12.Enabled = false;
                A13.Enabled = false;
                A14.Enabled = false;
            }
            else
            {
                intrebare1 = 0;
                A12.Enabled = true;
                A13.Enabled = true;
                A14.Enabled = true;
                A15.Enabled = true;
            }
        }

        private void A21_CheckedChanged(object sender, EventArgs e)
        {
            if (A21.Checked)
            {
                intrebare2 = 1;
                A22.Enabled = false;
                A23.Enabled = false;
                A24.Enabled = false;
                A25.Enabled = false;
            }
            else
            {
                intrebare2 = 0;
                A22.Enabled = true;
                A23.Enabled = true;
                A24.Enabled = true;
                A25.Enabled = true;
            }
        }

        private void A22_CheckedChanged(object sender, EventArgs e)
        {
            if (A22.Checked)
            {
                intrebare2 = 2;
                A21.Enabled = false;
                A23.Enabled = false;
                A24.Enabled = false;
                A25.Enabled = false;
            }
            else
            {
                intrebare2 = 0;
                A21.Enabled = true;
                A23.Enabled = true;
                A24.Enabled = true;
                A25.Enabled = true;
            }
        }

        private void A23_CheckedChanged(object sender, EventArgs e)
        {
            if (A23.Checked)
            {
                intrebare2 = 3;
                A21.Enabled = false;
                A22.Enabled = false;
                A24.Enabled = false;
                A25.Enabled = false;
            }
            else
            {
                intrebare2 = 0;
                A21.Enabled = true;
                A22.Enabled = true;
                A24.Enabled = true;
                A25.Enabled = true;
            }
        }

        private void A24_CheckedChanged(object sender, EventArgs e)
        {
            if (A24.Checked)
            {
                intrebare2 = 4;
                A21.Enabled = false;
                A22.Enabled = false;
                A23.Enabled = false;
                A25.Enabled = false;
            }
            else
            {
                intrebare2 = 0;
                A21.Enabled = true;
                A22.Enabled = true;
                A23.Enabled = true;
                A25.Enabled = true;
            }
        }

        private void A25_CheckedChanged(object sender, EventArgs e)
        {
            if (A25.Checked)
            {
                intrebare2 = 5;
                A21.Enabled = false;
                A22.Enabled = false;
                A23.Enabled = false;
                A24.Enabled = false;
            }
            else
            {
                intrebare2 = 0;
                A21.Enabled = true;
                A22.Enabled = true;
                A23.Enabled = true;
                A24.Enabled = true;
            }
        }

        private void A31_CheckedChanged(object sender, EventArgs e)
        {
            if (A31.Checked)
            {
                intrebare3 = 1;
                A32.Enabled = false;
                A33.Enabled = false;
                A34.Enabled = false;
                A35.Enabled = false;
            }
            else
            {
                intrebare3 = 0;
                A32.Enabled = true;
                A33.Enabled = true;
                A34.Enabled = true;
                A35.Enabled = true;
            }
        }

        private void A32_CheckedChanged(object sender, EventArgs e)
        {
            if (A32.Checked)
            {
                intrebare3 = 2;
                A31.Enabled = false;
                A33.Enabled = false;
                A34.Enabled = false;
                A35.Enabled = false;
            }
            else
            {
                intrebare3 = 0;
                A31.Enabled = true;
                A33.Enabled = true;
                A34.Enabled = true;
                A35.Enabled = true;
            }
        }

        private void A33_CheckedChanged(object sender, EventArgs e)
        {
            if (A33.Checked)
            {
                intrebare3 = 3;
                A31.Enabled = false;
                A32.Enabled = false;
                A34.Enabled = false;
                A35.Enabled = false;
            }
            else
            {
                intrebare3 = 0;
                A31.Enabled = true;
                A32.Enabled = true;
                A34.Enabled = true;
                A35.Enabled = true;
            }
        }

        private void A34_CheckedChanged(object sender, EventArgs e)
        {
            if (A34.Checked)
            {
                intrebare3 = 4;
                A31.Enabled = false;
                A32.Enabled = false;
                A33.Enabled = false;
                A35.Enabled = false;
            }
            else
            {
                intrebare3 = 0;
                A31.Enabled = true;
                A32.Enabled = true;
                A33.Enabled = true;
                A35.Enabled = true;
            }
        }

        private void A35_CheckedChanged(object sender, EventArgs e)
        {
            if (A35.Checked)
            {
                intrebare3 = 5;
                A31.Enabled = false;
                A32.Enabled = false;
                A33.Enabled = false;
                A34.Enabled = false;
            }
            else
            {
                intrebare3 = 0;
                A31.Enabled = true;
                A32.Enabled = true;
                A33.Enabled = true;
                A34.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (intrebare1 == 0)
            {
                MessageBox.Show("Va rugam sa raspundeti la prima intrebare.");
                return;
            }
            if (intrebare2 == 0)
            {
                MessageBox.Show("Va rugam sa raspundeti la a doua intrebare.");
                return;
            }
            if (intrebare3 == 0)
            {
                MessageBox.Show("Va rugam sa raspundeti la a treia intrebare.");
                return;
            }

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("insert into chestionar(intrebarea1,intrebarea2,intrebarea3,sugestie) values(@intrebarea1,@intrebarea2,@intrebarea3,@sugestie)",Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@intrebarea1", intrebare1);
                mySqlCommand.Parameters.AddWithValue("@intrebarea2", intrebare2);
                mySqlCommand.Parameters.AddWithValue("@intrebarea3", intrebare3);
                mySqlCommand.Parameters.AddWithValue("@sugestie", Sugestie.Text);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                Constante.mySqlConnection.Close();
                Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            Constante.Log("IntroducereChestionar", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);

            MessageBox.Show("Salvare realizată cu succes");
            Close();
        }
    }
}
