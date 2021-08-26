using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using QRCoder;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net;

namespace Licenta.Introducere
{
    public partial class IntroducereVanzare : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        public static int id_produs_redirect;
        public List<int> id_produs = new List<int>();
        public List<string> produse=new List<string>();
        public List<int> nr_marime = new List<int>();
        public List<int> cantitate = new List<int>();
        public List<int> pret = new List<int>();
        public List<int> cantitate_maxima = new List<int>();
        public static string result_copy;
        public int id_bon;
            
        public IntroducereVanzare()
        {
            InitializeComponent();
        }

        private void IntroducereVanzareScan_Load(object sender, EventArgs e)
        {
            resetDomiciliuPanel();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                Camera.Items.Add(filterInfo.Name);
        }

        public int Id_Produs(byte[] qr)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("Select id_produs from produs where qrcode=@qrcode",Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@qrcode", qr);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    int x = mySqlDataReader.GetInt32(0);
                    Constante.mySqlConnection.Close();
                    return x;
                }
                else
                {
                    Constante.mySqlConnection.Close();
                    return 0;
                }
            }catch(Exception ex){
                throw ex;
            }
        }

        public int Id_Bon(byte[] qr)
        {
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("Select id_bon from bon where qrcode=@qrcode", Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@qrcode", qr);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.Read())
                {
                    int x = mySqlDataReader.GetInt32(0);
                    Constante.mySqlConnection.Close();
                    return x;
                }
                else
                {
                    Constante.mySqlConnection.Close();
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Camera_SelectedIndexChanged(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[Camera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ScanImage.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void PopulateBon()
        {
            int pret_total = 0;
            Bon.Text = "";
            ProduseSelect.Items.Clear();
            for (int i = 0; i < produse.Count; i++)
            {
                Bon.Text += produse[i] + Environment.NewLine + "Marime: " + nr_marime[i] + Environment.NewLine + "Cantitate: " + cantitate[i] + Environment.NewLine +"Pret: " + pret[i] + Environment.NewLine ;
                pret_total = pret_total + (cantitate[i] * pret[i]);
                ProduseSelect.Items.Add(produse[i]);
            }
            if (pret_total > 0)
            {
                Bon.Text += Environment.NewLine + Environment.NewLine + "Pret total: " + pret_total;
            }
        }

        private bool ValidateProdus(List<string> list,string produs)
        {
            bool x=false;
            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == produs)
                    {
                        x = true;
                        break;
                    }
                }
            }
            return x;
        }

        private bool ValidateMarime(List<int> list, int marime)
        {
            bool x = false;
            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == marime)
                    {
                        x = true;
                        break;
                    }
                }
            }
            return x;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ScanImage.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)ScanImage.Image);
                if (result != null)
                {
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                    produse.Add(result.ToString());
                    result_copy = result.ToString();
                    QRCodeGenerator qr = new QRCodeGenerator();
                    var codeData = qr.CreateQrCode(result.ToString(), QRCodeGenerator.ECCLevel.H);
                    var code = new QRCode(codeData);
                    QrVerify.Image = code.GetGraphic(50);
                    Image imageQR = QrVerify.Image;
                    MemoryStream memoryStreamQR = new MemoryStream();
                    imageQR.Save(memoryStreamQR, ImageFormat.Png);
                    byte[] imageByteQR = memoryStreamQR.ToArray();
                    if (Id_Produs(imageByteQR) == 0)
                    {
                        MessageBox.Show("Fail");
                        ScanImage.Image = null;
                        captureDevice.NewFrame += CaptureDevice_NewFrame;
                        captureDevice.Start();
                        timer1.Start();
                    }
                    else
                    {
                        id_produs_redirect = Id_Produs(imageByteQR);
                        IntroducereMarimeCantitate introducereMarimeCantitate = new IntroducereMarimeCantitate();
                        introducereMarimeCantitate.ShowDialog();
                    }
                }
            }
            if (IntroducereMarimeCantitate.start_stop)
            {
                if (IntroducereMarimeCantitate.marime_redirect == 0)
                {
                    produse.RemoveAt(produse.Count-1);
                }
                else
                {
                    if(ValidateProdus(produse,result_copy) && ValidateMarime(nr_marime, IntroducereMarimeCantitate.marime_redirect) && produse.IndexOf(result_copy)==nr_marime.IndexOf(IntroducereMarimeCantitate.marime_redirect))
                    {
                        if(cantitate[produse.IndexOf(result_copy)]+IntroducereMarimeCantitate.cantitate_redirect> cantitate_maxima[produse.IndexOf(result_copy)])
                        {
                            produse.RemoveAt(produse.Count - 1);
                            MessageBox.Show("Nu se poate adauga numarul de produse deoarece stocul disponibil este de: " + cantitate_maxima[produse.IndexOf(result_copy)]);
                        }
                        else
                        {
                            produse.RemoveAt(produse.Count - 1);
                            cantitate[produse.IndexOf(result_copy)] = cantitate[produse.IndexOf(result_copy)] + IntroducereMarimeCantitate.cantitate_redirect;
                        }
                    }
                    else
                    {
                        id_produs.Add(id_produs_redirect);
                        nr_marime.Add(IntroducereMarimeCantitate.marime_redirect);
                        cantitate.Add(IntroducereMarimeCantitate.cantitate_redirect);
                        cantitate_maxima.Add(IntroducereMarimeCantitate.stoc_redirect);
                        pret.Add(IntroducereMarimeCantitate.pret_redirect);   
                    }
                    
                }
                PopulateBon();
                ScanImage.Image = null;
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                timer1.Start();
                IntroducereMarimeCantitate.start_stop=false;
            }
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            if (ProduseSelect.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza un produs");
            }
            else
            {
                int index = produse.IndexOf(ProduseSelect.SelectedItem.ToString());
                id_produs.RemoveAt(index);
                produse.RemoveAt(index);
                nr_marime.RemoveAt(index);
                cantitate.RemoveAt(index);
                pret.RemoveAt(index);
                cantitate_maxima.RemoveAt(index);
                ProduseSelect.ResetText();
                ProduseSelect.SelectedIndex = -1;
                PopulateBon();
            }
        }

        private void CantitateAdd_Click(object sender, EventArgs e)
        {
            if (ProduseSelect.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza un produs");
            }
            else
            {
                int index = produse.IndexOf(ProduseSelect.SelectedItem.ToString());
                if (cantitate[index] < cantitate_maxima[index])
                {
                    cantitate[index]++;
                }
                else
                {
                    MessageBox.Show("Nu se poate adauga numarul de produse deoarece stocul disponibil este de: " + cantitate_maxima[index]);
                }
                ProduseSelect.ResetText();
                ProduseSelect.SelectedIndex = -1;
                PopulateBon();
            }
        }

        private void CantitateRemove_Click(object sender, EventArgs e)
        {
            if (ProduseSelect.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza un produs");
            }
            else
            {
                int index = produse.IndexOf(ProduseSelect.SelectedItem.ToString());
                if (cantitate[index] > 1)
                {
                    cantitate[index]--;
                }
                else
                {
                    id_produs.RemoveAt(index);
                    produse.RemoveAt(index);
                    nr_marime.RemoveAt(index);
                    cantitate.RemoveAt(index);
                    pret.RemoveAt(index);
                    cantitate_maxima.RemoveAt(index);
                }
                ProduseSelect.ResetText();
                ProduseSelect.SelectedIndex = -1;
                PopulateBon();
            }
        }

        private void Vanzare_Click(object sender, EventArgs e)
        {
            if (Bon.Text == "")
            {
                return;
            }
            if (checkBox1.Checked)
            {
                VanzareCuLivrare();
            }
            else
            {
                VanzareNormala();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DomiciliuPanel.Visible = true;
                resetDomiciliuPanel();
            }
            else
            {
                DomiciliuPanel.Visible = false;
            }
        }

        private void resetDomiciliuPanel()
        {
            Nume.Text = "";
            Prenume.Text = "";
            Email.Text = "";
            Adresa.Text = "";
        }

        private void VanzareNormala()
        {
            try
            {
                Bon.Text += Environment.NewLine + "Data: " + DateTime.Now.ToString();
                QRCodeGenerator qr = new QRCodeGenerator();
                var codeData = qr.CreateQrCode(Bon.Text, QRCodeGenerator.ECCLevel.H);
                var code = new QRCode(codeData);
                QrBon.Image = code.GetGraphic(50);
                Image imageQR = QrBon.Image;
                MemoryStream memoryStreamQR = new MemoryStream();
                imageQR.Save(memoryStreamQR, ImageFormat.Png);
                byte[] imageByteQR = memoryStreamQR.ToArray();
                MySqlCommand insertBon = new MySqlCommand("insert into bon(qrcode) values(@qrcode)", Constante.mySqlConnection);
                insertBon.Parameters.AddWithValue("@qrcode", imageByteQR);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = insertBon.ExecuteReader();
                Constante.mySqlConnection.Close();
                id_bon = Id_Bon(imageByteQR);
                if (id_bon == 0)
                {
                    MessageBox.Show("Bon inexistent");
                }
                else
                {
                    for (int i = 0; i < id_produs.Count; i++)
                    {
                        try
                        {
                            MySqlCommand insertVanzare = new MySqlCommand("insert into vanzare(id_produs,marime,cantitate,id_bon) values(@id_produs,@marime,@cantitate,@id_bon)", Constante.mySqlConnection);
                            insertVanzare.Parameters.AddWithValue("@id_produs", id_produs[i]);
                            insertVanzare.Parameters.AddWithValue("@marime", nr_marime[i]);
                            insertVanzare.Parameters.AddWithValue("@cantitate", cantitate[i]);
                            insertVanzare.Parameters.AddWithValue("@id_bon", id_bon);
                            Constante.mySqlConnection.Open();
                            MySqlDataReader mySqlDataReader1 = insertVanzare.ExecuteReader();
                            Constante.mySqlConnection.Close();
                            insertVanzare.Parameters.Clear();
                        }
                        catch (Exception E)
                        {
                            throw E;
                        }

                        try
                        {
                            MySqlCommand update = new MySqlCommand("Update marime set stoc=stoc-@cantitate where id_produs=@id_produs and nr_marime=@nr_marime", Constante.mySqlConnection);
                            update.Parameters.AddWithValue("@cantitate", cantitate[i]);
                            update.Parameters.AddWithValue("@id_produs", id_produs[i]);
                            update.Parameters.AddWithValue("@nr_marime", nr_marime[i]);
                            Constante.mySqlConnection.Open();
                            MySqlDataReader mySqlDataReader2 = update.ExecuteReader();
                            Constante.mySqlConnection.Close();
                            update.Parameters.Clear();
                        }catch(Exception Ex)
                        {
                            throw Ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Constante.Log("IntroducereVanzare", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
            Save.Visible = true;
            Chestionar.Visible = true;
        }

        private void VanzareCuLivrare()
        {
            if (Nume.Text == "")
            {
                Nume.Focus();
                MessageBox.Show("Introduceti un nume");
                return;
            }
            if (Prenume.Text == "")
            {
                Prenume.Focus();
                MessageBox.Show("Introduceti un prenume");
                return;
            }
            if (Email.Text == "")
            {
                Email.Focus();
                MessageBox.Show("Introduceti un email");
                return;
            }
            if (Adresa.Text == "")
            {
                Adresa.Focus();
                MessageBox.Show("Introduceti o adresa");
                return;
            }
            if (!Constante.EmailValidate(Email.Text))
            {
                MessageBox.Show("Introduceti un email valid");
                Email.Focus();
                return;
            }
            try
            {
                Bon.Text += Environment.NewLine + "Data: " + DateTime.Now.ToString();
                QRCodeGenerator qr = new QRCodeGenerator();
                var codeData = qr.CreateQrCode(Bon.Text, QRCodeGenerator.ECCLevel.H);
                var code = new QRCode(codeData);
                QrBon.Image = code.GetGraphic(50);
                Image imageQR = QrBon.Image;
                MemoryStream memoryStreamQR = new MemoryStream();
                imageQR.Save(memoryStreamQR, ImageFormat.Png);
                byte[] imageByteQR = memoryStreamQR.ToArray();
                MySqlCommand insertBon = new MySqlCommand("insert into bon(qrcode) values(@qrcode)", Constante.mySqlConnection);
                insertBon.Parameters.AddWithValue("@qrcode", imageByteQR);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = insertBon.ExecuteReader();
                Constante.mySqlConnection.Close();
                id_bon = Id_Bon(imageByteQR);
                if (id_bon == 0)
                {
                    MessageBox.Show("Bon inexistent");
                }
                else
                {
                    for (int i = 0; i < id_produs.Count; i++)
                    {
                        try
                        {
                            MySqlCommand insertVanzare = new MySqlCommand("insert into vanzare(id_produs,marime,cantitate,id_bon) values(@id_produs,@marime,@cantitate,@id_bon)", Constante.mySqlConnection);
                            insertVanzare.Parameters.AddWithValue("@id_produs", id_produs[i]);
                            insertVanzare.Parameters.AddWithValue("@marime", nr_marime[i]);
                            insertVanzare.Parameters.AddWithValue("@cantitate", cantitate[i]);
                            insertVanzare.Parameters.AddWithValue("@id_bon", id_bon);
                            Constante.mySqlConnection.Open();
                            MySqlDataReader mySqlDataReader1 = insertVanzare.ExecuteReader();
                            Constante.mySqlConnection.Close();
                            insertVanzare.Parameters.Clear();
                        }
                        catch (Exception E)
                        {
                            throw E;
                        }

                        try
                        {
                            MySqlCommand update = new MySqlCommand("Update marime set stoc=stoc-@cantitate where id_produs=@id_produs and nr_marime=@nr_marime", Constante.mySqlConnection);
                            update.Parameters.AddWithValue("@cantitate", cantitate[i]);
                            update.Parameters.AddWithValue("@id_produs", id_produs[i]);
                            update.Parameters.AddWithValue("@nr_marime", nr_marime[i]);
                            Constante.mySqlConnection.Open();
                            MySqlDataReader mySqlDataReader2 = update.ExecuteReader();
                            Constante.mySqlConnection.Close();
                            update.Parameters.Clear();
                        }
                        catch (Exception Ex)
                        {
                            throw Ex;
                        }
                    }
                }

                try
                {
                    MySqlCommand insertLivrare = new MySqlCommand("insert into livrare(nume,prenume,email,adresa,id_bon) values(@nume,@prenume,@email,@adresa,@id_bon)", Constante.mySqlConnection);
                    insertLivrare.Parameters.AddWithValue("@nume", Nume.Text);
                    insertLivrare.Parameters.AddWithValue("@prenume", Prenume.Text);
                    insertLivrare.Parameters.AddWithValue("@email", Email.Text);
                    insertLivrare.Parameters.AddWithValue("@adresa", Adresa.Text);
                    insertLivrare.Parameters.AddWithValue("@id_bon", id_bon);
                    Constante.mySqlConnection.Open();
                    MySqlDataReader mySqlDataReader1 = insertLivrare.ExecuteReader();
                    Constante.mySqlConnection.Close();

                    string produse_cumparate = "";
                    for(int i = 0; i < produse.Count; i++)
                    {
                        produse_cumparate +=produse[i] + "\nCantitate: "+cantitate[i]+"\nPret: "+pret[i]+"\n\n";
                    }

                    MailMessage mesaj = new MailMessage();
                    mesaj.From = new MailAddress("licenta98@gmail.com");
                    mesaj.To.Add(Email.Text);
                    mesaj.Subject = "Comanda Nr."+id_bon;
                    mesaj.Body = "Comanda dumneavoastra cu numarul "+ id_bon+" a fost procesata si urmeaza sa fie livrata.\nDetalii comanda:\nNume: "+Nume.Text+"\nPrenume: "+Prenume.Text+"\nAdresa: "+Adresa.Text+"\n\nProdusele dumeavoastra:\n"+produse_cumparate+"\n\nVa dorim o zi buna!";
                    SmtpClient smtp = new SmtpClient();
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Host = "smtp.gmail.com";
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("licenta98@gmail.com", "Sora1998!");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(mesaj);
                }
                catch (Exception E)
                {
                    throw E;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Save.Visible = true;
            Chestionar.Visible = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "BonNr_" + id_bon;
            saveFileDialog1.Filter = "Images | *.png";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                QrBon.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
            }
        }

        private void Chestionar_Click(object sender, EventArgs e)
        {
            IntroducereChestionar introducereChestionar = new IntroducereChestionar();
            introducereChestionar.ShowDialog();
        }

        private void IntroducereVanzare_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (captureDevice != null)
                captureDevice.Stop();
            timer1.Stop();
        }

        private void Nume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
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
    }
}
