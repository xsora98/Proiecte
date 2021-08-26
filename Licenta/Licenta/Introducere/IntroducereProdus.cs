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
    public partial class IntroducereProdus : Form
    {
        public IntroducereProdus()
        {
            InitializeComponent();
        }

        private void IntroducereProdus_Load(object sender, EventArgs e)
        {
            DistribuitorPopulate();
        }

        private void DistribuitorPopulate()
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "Select denumire from distribuitor;";
                mySqlCommand.Connection = Constante.mySqlConnection;
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    Distribuitor.Items.Add(mySqlDataReader.GetString(0));
                }
            }
            catch (MySqlException E)
            {
                throw E;
            }
            Constante.mySqlConnection.Close();
        }

        private void Adauga_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Imagine.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private int IdDistribuitor(string denumire)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "Select id_distribuitor from distribuitor where denumire=@denumire";
                mySqlCommand.Parameters.AddWithValue("@denumire", denumire);
                mySqlCommand.Connection = Constante.mySqlConnection;
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    int id = mySqlDataReader.GetInt32(0);
                    Constante.mySqlConnection.Close();
                    return id;
                }
                else
                {
                    Constante.mySqlConnection.Close();
                    return 0;
                }
            }catch(MySqlException E)
            {
                throw E;
            }
        }

        private int IdProdus(string denumire, string producator, string tip, string sex, int pret, int iddis)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = "Select id_produs from produs where denumire=@denumire and producator=@producator and tip=@tip and pret=@pret and id_distribuitor=@id_distribuitor";
                mySqlCommand.Parameters.AddWithValue("@denumire", denumire);
                mySqlCommand.Parameters.AddWithValue("@producator", producator);
                mySqlCommand.Parameters.AddWithValue("@tip", tip);
                mySqlCommand.Parameters.AddWithValue("@sex", sex);
                mySqlCommand.Parameters.AddWithValue("@pret", pret);
                mySqlCommand.Parameters.AddWithValue("@id_distribuitor", iddis);
                mySqlCommand.Connection = Constante.mySqlConnection;
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    int id = mySqlDataReader.GetInt32(0);
                    Constante.mySqlConnection.Close();
                    return id;
                }
                else
                {
                    Constante.mySqlConnection.Close();
                    return 0;
                }
            }
            catch (MySqlException E)
            {
                throw E;
            }
        }

        private void Marime_Click(object sender, EventArgs e)
        {
            Marimi marimi = new Marimi();
            marimi.ShowDialog();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (Imagine.Image == null)
            {
                MessageBox.Show("Introduceți o imagine!");
                return;
            }
            if (Denumire.Text == "")
            {
                MessageBox.Show("Introduceți o denumire!");
                return;
            }
            if (Producator.Text == "")
            {
                MessageBox.Show("Introduceți un producător!");
                return;
            }
            if (Tip.SelectedItem == null)
            {
                MessageBox.Show("Selectați un tip!");
                return;
            }
            if (Sex.SelectedItem == null)
            {
                MessageBox.Show("Selectați un sex!");
                return;
            }
            if (Pret.Text == "")
            {
                MessageBox.Show("Introduceți un preț!");
                return;
            }
            if (Distribuitor.SelectedItem == null)
            {
                MessageBox.Show("Selectați un distribuitor!");
                return;
            }
            if (Marimi.marime == null || Marimi.marime.Length == 0)
            {
                MessageBox.Show("Selectați cel puțin o mărime");
                return;
            }
            Image image = Imagine.Image;
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            byte[] imageByte = memoryStream.ToArray();
            string denumire = Denumire.Text;
            string producator = Producator.Text;
            string tip = Tip.SelectedItem.ToString();
            string sex = Sex.SelectedItem.ToString();
            int pret = Int32.Parse(Pret.Text.ToString());
            string distribuitor = Distribuitor.SelectedItem.ToString();
            string qrText =denumire+" "+producator+" "+tip+" "+sex+" "+distribuitor;
            QRCodeGenerator qr = new QRCodeGenerator();
            var codeData = qr.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.H);
            var code = new QRCode(codeData);
            QRCode.Image = code.GetGraphic(50);
            Image imageQR = QRCode.Image;
            MemoryStream memoryStreamQR = new MemoryStream();
            imageQR.Save(memoryStreamQR, ImageFormat.Png);
            byte[] imageByteQR = memoryStreamQR.ToArray();
            
            try
            {
                string insertProdus = "Insert into produs(imagine,denumire,producator,tip,sex,pret,id_distribuitor,qrcode) values(@imagine,@denumire,@producator,@tip,@sex,@pret,@id_distribuitor,@qrcode);";
                MySqlCommand mySqlCommand = new MySqlCommand(insertProdus, Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@imagine",imageByte);
                mySqlCommand.Parameters.AddWithValue("@denumire",denumire);
                mySqlCommand.Parameters.AddWithValue("@producator",producator);
                mySqlCommand.Parameters.AddWithValue("@tip",tip);
                mySqlCommand.Parameters.AddWithValue("@sex",sex);
                mySqlCommand.Parameters.AddWithValue("@pret",pret);
                mySqlCommand.Parameters.AddWithValue("@id_distribuitor",IdDistribuitor(distribuitor));
                mySqlCommand.Parameters.AddWithValue("@qrcode",imageByteQR);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                Constante.mySqlConnection.Close();

            }
            catch(MySqlException E)
            {
                throw E;
            }
            int i = 0;
            string[] marimiDisponibile = Marimi.marime.Split(',');
            string[] stocDisponibil = Marimi.stoc.Split(',');


            foreach (string x in marimiDisponibile)
            {
                try
                {

                    string insertMarimi = "insert into marime(nr_marime,stoc,id_produs) values(@nr_marime,@stoc,@id_produs);";
                    MySqlCommand mySqlCommandMarimi = new MySqlCommand(insertMarimi, Constante.mySqlConnection);
                    int nr = Int32.Parse(x,System.Globalization.NumberStyles.Any);
                    int stoc = Int32.Parse(stocDisponibil[i], System.Globalization.NumberStyles.Any);
                    mySqlCommandMarimi.Parameters.AddWithValue("@nr_marime", nr);
                    mySqlCommandMarimi.Parameters.AddWithValue("@stoc", stoc);
                    mySqlCommandMarimi.Parameters.AddWithValue("@id_produs", IdProdus(denumire,producator,tip,sex,pret,IdDistribuitor(distribuitor)));
                    Constante.mySqlConnection.Open();
                    MySqlDataReader mySqlDataReaderMarimi = mySqlCommandMarimi.ExecuteReader();
                    Constante.mySqlConnection.Close();
                }
                catch (MySqlException E)
                {
                    throw E;
                }
                i++;
            }
            Constante.Log("IntroducereProdus", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
            Save.Visible=true;
            MessageBox.Show("Inserare realizată cu succes");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = Denumire.Text + "_" + Producator.Text;
            saveFileDialog1.Filter = "Images | *.png";
            saveFileDialog1.AddExtension=true;
            saveFileDialog1.DefaultExt = "*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                QRCode.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
            }
        }

        private void Producator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Pret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
