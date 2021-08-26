using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;
using QRCoder;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using AForge.Video;

namespace Licenta.Main
{
    public partial class VerificareProdusScan : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        public VerificareProdusScan()
        {
            InitializeComponent();
        }

        private void VerificareProdusScan_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                Camera.Items.Add(filterInfo.Name);
        }

        public string MarimiDisponibile(byte[] qr)
        {
            string x = "";
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand("Select nr_marime,stoc from marime where id_produs=(select id_produs from produs where qrcode=@qrcode) and stoc>0", Constante.mySqlConnection);
                mySqlCommand.Parameters.AddWithValue("@qrcode", qr);
                Constante.mySqlConnection.Open();
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    x += "Marime: "+mySqlDataReader.GetInt32(0) +" - Stoc: "+ mySqlDataReader.GetInt32(1)+"\n";
                    
                }
                Constante.mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return x;
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
                    string result_copy = result.ToString();
                    QRCodeGenerator qr = new QRCodeGenerator();
                    var codeData = qr.CreateQrCode(result.ToString(), QRCodeGenerator.ECCLevel.H);
                    var code = new QRCode(codeData);
                    QrVerify.Image = code.GetGraphic(50);
                    Image imageQR = QrVerify.Image;
                    MemoryStream memoryStreamQR = new MemoryStream();
                    imageQR.Save(memoryStreamQR, ImageFormat.Png);
                    byte[] imageByteQR = memoryStreamQR.ToArray();
                    if (MarimiDisponibile(imageByteQR) == "")
                    {
                        MessageBox.Show("Stoc indisponibil");
                        ScanImage.Image = null;
                        captureDevice.NewFrame += CaptureDevice_NewFrame;
                        captureDevice.Start();
                        timer1.Start();
                    }
                    else
                    {
                        MessageBox.Show(MarimiDisponibile(imageByteQR));
                        ScanImage.Image = null;
                        captureDevice.NewFrame += CaptureDevice_NewFrame;
                        captureDevice.Start();
                        timer1.Start();
                    }
                }
            }
        }

        private void VerificareProdusScan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(captureDevice!=null)
                captureDevice.Stop();
            timer1.Stop();
        }
    }
}
