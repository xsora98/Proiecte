using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licenta
{
    public partial class ModificareImagine : Form
    {
        public Image image;
        public byte[] imageByte;
        public bool imageChange = false;
        public ModificareImagine()
        {
            InitializeComponent();
        }

        private void Selecteaza_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Imagine.Image = new Bitmap(openFileDialog.FileName);
                image = Imagine.Image;
                MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, ImageFormat.Png);
                imageByte = memoryStream.ToArray();
                imageChange = true;
            }
        }

        private void Modifica_Click(object sender, EventArgs e)
        {
            if (imageChange == true)
            {
                try
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("update produs set imagine=@imagine where id_produs=@id_produs", Constante.mySqlConnection);
                    mySqlCommand.Parameters.AddWithValue("@imagine", imageByte);
                    mySqlCommand.Parameters.AddWithValue("@id_produs", VizualizareProduse.id_produs_redirect);
                    Constante.mySqlConnection.Open();
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                    Constante.mySqlConnection.Close();
                    Constante.Log("ModificareImagine", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
                    MessageBox.Show("Modificare realizată cu succes");

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
