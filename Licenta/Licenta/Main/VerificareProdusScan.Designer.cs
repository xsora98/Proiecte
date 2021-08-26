namespace Licenta.Main
{
    partial class VerificareProdusScan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificareProdusScan));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Camera = new System.Windows.Forms.ComboBox();
            this.ScanImage = new System.Windows.Forms.PictureBox();
            this.QrVerify = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScanImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrVerify)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Camera
            // 
            this.Camera.FormattingEnabled = true;
            this.Camera.Location = new System.Drawing.Point(11, 82);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(776, 24);
            this.Camera.TabIndex = 0;
            this.Camera.SelectedIndexChanged += new System.EventHandler(this.Camera_SelectedIndexChanged);
            // 
            // ScanImage
            // 
            this.ScanImage.BackColor = System.Drawing.Color.Transparent;
            this.ScanImage.Location = new System.Drawing.Point(12, 113);
            this.ScanImage.Name = "ScanImage";
            this.ScanImage.Size = new System.Drawing.Size(775, 395);
            this.ScanImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScanImage.TabIndex = 1;
            this.ScanImage.TabStop = false;
            // 
            // QrVerify
            // 
            this.QrVerify.BackColor = System.Drawing.Color.Transparent;
            this.QrVerify.Location = new System.Drawing.Point(12, 515);
            this.QrVerify.Name = "QrVerify";
            this.QrVerify.Size = new System.Drawing.Size(132, 82);
            this.QrVerify.TabIndex = 2;
            this.QrVerify.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Verificare stoc disponibil";
            // 
            // VerificareProdusScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(808, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QrVerify);
            this.Controls.Add(this.ScanImage);
            this.Controls.Add(this.Camera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerificareProdusScan";
            this.Text = "VerificareProdusScan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerificareProdusScan_FormClosed);
            this.Load += new System.EventHandler(this.VerificareProdusScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScanImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrVerify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox Camera;
        private System.Windows.Forms.PictureBox ScanImage;
        private System.Windows.Forms.PictureBox QrVerify;
        private System.Windows.Forms.Label label1;
    }
}