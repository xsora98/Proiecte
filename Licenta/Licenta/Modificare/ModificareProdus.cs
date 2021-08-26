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
using MySql.Data.MySqlClient;
using QRCoder;

namespace Licenta
{
    public partial class ModificareProdus : Form
    {

        public ModificareProdus()
        {
            InitializeComponent();
            PopulateDistribuitor();
        }

        private void PopulateDistribuitor()
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "Select denumire from distribuitor";
                mySqlCommand.Connection = Constante.mySqlConnection;
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Distribuitor.Items.Add(mySqlDataReader.GetString(0));
                }
                Constante.mySqlConnection.Close();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        private void DenumireCheck_CheckedChanged(object sender, EventArgs e)
        {
            Denumire.Enabled = !Denumire.Enabled;
        }

        private void ProducatorCheck_CheckedChanged(object sender, EventArgs e)
        {
            Producator.Enabled = !Producator.Enabled;
        }

        private void TipCheck_CheckedChanged(object sender, EventArgs e)
        {
            Tip.Enabled = !Tip.Enabled;
        }

        private void SexCheck_CheckedChanged(object sender, EventArgs e)
        {
            Sex.Enabled = !Sex.Enabled;
        }

        private void DistribuitorCheck_CheckedChanged(object sender, EventArgs e)
        {
            Distribuitor.Enabled = !Distribuitor.Enabled;
        }


        private void PretCheck_CheckedChanged(object sender, EventArgs e)
        {
            PretNou.Enabled = !PretNou.Enabled;
        }

        private void Modifica_Click(object sender, EventArgs e)
        {
            string qrCode = "";
            string update = "update produs set";
            int modificariFacute = 0;
            if (DenumireCheck.Checked.Equals(true))
            {
                if (Denumire.Text != "")
                {
                    modificariFacute++;
                    update += " denumire=\'" + Denumire.Text + "\' ,";
                    qrCode += Denumire.Text + " ";
                }
                else
                {
                    MessageBox.Show("Introduceti o valoare!");
                    return;
                }
            }
            else
            {
                qrCode += VizualizareProduse.denumire_redirect + " ";
            }
            if (ProducatorCheck.Checked.Equals(true))
            {
                if (Producator.Text != "")
                {
                    modificariFacute++;
                    update += " producator=\'" + Producator.Text + "\' ,";
                    qrCode += Producator.Text + " ";
                }
                else
                {
                    MessageBox.Show("Introduceti o valoare!");
                    return;
                }
            }
            else
            {
                qrCode += VizualizareProduse.producator_redirect + " ";
            }
            if (TipCheck.Checked.Equals(true))
            {
                if (Tip.SelectedItem != null)
                {
                    modificariFacute++;
                    update += " tip=\'" + Tip.SelectedItem.ToString() + "\' ,";
                    qrCode += Tip.SelectedItem.ToString() + " ";
                }
                else
                {
                    MessageBox.Show("Selectati o valoare!");
                    return;
                }
            }
            else
            {
                qrCode += VizualizareProduse.tip_redirect + " ";
            }
            if (SexCheck.Checked.Equals(true))
            {
                if (Sex.SelectedItem != null)
                {
                    modificariFacute++;
                    update += " sex=\'" + Sex.SelectedItem.ToString() + "\' ,";
                    qrCode += Sex.SelectedItem.ToString() + " ";
                }
                else
                {
                    MessageBox.Show("Selectati o valoare!");
                    return;
                }
            }
            else
            {
                qrCode += VizualizareProduse.sex_redirect + " ";
            }
            if (DistribuitorCheck.Checked.Equals(true))
            {
                if (Distribuitor.SelectedItem != null)
                {
                    modificariFacute++;
                    update += " id_distribuitor=(select id_distribuitor from distribuitor where denumire=\'" + Distribuitor.SelectedItem.ToString() + "\') ,";
                    qrCode += Distribuitor.SelectedItem.ToString() + " ";
                }
                else
                {
                    MessageBox.Show("Selectati o valoare!");
                    return;
                }
            }
            else
            {
                qrCode += VizualizareProduse.distribuitor_redirect + " ";
            }
            if (PretCheck.Checked.Equals(true))
            {
                if (PretNou.Text != "")
                {
                    modificariFacute++;
                    update += " pret=" + PretNou.Text + " ,";
                }
                else
                {
                    MessageBox.Show("Introduceti o valoare!");
                    return;
                }
            }
            if (modificariFacute == 0)
            {
                MessageBox.Show("Selectează cel putin o modificare!");
                return;
            }
            qrCode = qrCode.Remove(qrCode.Length - 1);
            QRCodeGenerator qr = new QRCodeGenerator();
            var codeData = qr.CreateQrCode(qrCode, QRCodeGenerator.ECCLevel.H);
            var code = new QRCode(codeData);
            QrCode.Image = code.GetGraphic(50);
            Image image= QrCode.Image;
            MemoryStream memoryStreamQR = new MemoryStream();
            image.Save(memoryStreamQR, ImageFormat.Png);
            byte[] imageByteQR = memoryStreamQR.ToArray();
            update += "qrcode=@qr ";
            update += " where id_produs=@id_produs";
          
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(update, Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@qr", imageByteQR);
                mySqlCommand.Parameters.AddWithValue("@id_produs", VizualizareProduse.id_produs_redirect);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                Constante.mySqlConnection.Close();
                QrCode.Visible = true;
                Save.Visible = true;
                Constante.Log("ModificareProdus", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
                MessageBox.Show("Modificare realizată cu succes");

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void Producator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PretNou_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Images | *.png";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                QrCode.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
            }
        }
    }
}
