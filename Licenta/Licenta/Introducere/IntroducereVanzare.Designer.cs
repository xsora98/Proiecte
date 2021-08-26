namespace Licenta.Introducere
{
    partial class IntroducereVanzare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroducereVanzare));
            this.Camera = new System.Windows.Forms.ComboBox();
            this.ScanImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Bon = new System.Windows.Forms.TextBox();
            this.ProduseLabel = new System.Windows.Forms.Label();
            this.QrVerify = new System.Windows.Forms.PictureBox();
            this.ProduseSelect = new System.Windows.Forms.ComboBox();
            this.Sterge = new System.Windows.Forms.Button();
            this.CantitateAdd = new System.Windows.Forms.Button();
            this.CantitateRemove = new System.Windows.Forms.Button();
            this.Vanzare = new System.Windows.Forms.Button();
            this.QrBon = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.DomiciliuPanel = new System.Windows.Forms.Panel();
            this.Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.Nume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Chestionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScanImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrVerify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrBon)).BeginInit();
            this.DomiciliuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Camera
            // 
            this.Camera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Camera.FormattingEnabled = true;
            this.Camera.Location = new System.Drawing.Point(22, 88);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(640, 24);
            this.Camera.TabIndex = 0;
            this.Camera.SelectedIndexChanged += new System.EventHandler(this.Camera_SelectedIndexChanged);
            // 
            // ScanImage
            // 
            this.ScanImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScanImage.BackColor = System.Drawing.Color.Transparent;
            this.ScanImage.Location = new System.Drawing.Point(22, 118);
            this.ScanImage.Name = "ScanImage";
            this.ScanImage.Size = new System.Drawing.Size(640, 334);
            this.ScanImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScanImage.TabIndex = 1;
            this.ScanImage.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Bon
            // 
            this.Bon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Bon.Location = new System.Drawing.Point(723, 118);
            this.Bon.Multiline = true;
            this.Bon.Name = "Bon";
            this.Bon.ReadOnly = true;
            this.Bon.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Bon.Size = new System.Drawing.Size(402, 334);
            this.Bon.TabIndex = 2;
            // 
            // ProduseLabel
            // 
            this.ProduseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProduseLabel.AutoSize = true;
            this.ProduseLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProduseLabel.Location = new System.Drawing.Point(878, 89);
            this.ProduseLabel.Name = "ProduseLabel";
            this.ProduseLabel.Size = new System.Drawing.Size(61, 17);
            this.ProduseLabel.TabIndex = 3;
            this.ProduseLabel.Text = "Produse";
            // 
            // QrVerify
            // 
            this.QrVerify.BackColor = System.Drawing.Color.Transparent;
            this.QrVerify.Location = new System.Drawing.Point(22, 458);
            this.QrVerify.Name = "QrVerify";
            this.QrVerify.Size = new System.Drawing.Size(204, 104);
            this.QrVerify.TabIndex = 4;
            this.QrVerify.TabStop = false;
            this.QrVerify.Visible = false;
            // 
            // ProduseSelect
            // 
            this.ProduseSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProduseSelect.FormattingEnabled = true;
            this.ProduseSelect.Location = new System.Drawing.Point(723, 458);
            this.ProduseSelect.Name = "ProduseSelect";
            this.ProduseSelect.Size = new System.Drawing.Size(402, 24);
            this.ProduseSelect.TabIndex = 5;
            // 
            // Sterge
            // 
            this.Sterge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sterge.Image = global::Licenta.Properties.Resources.Delete;
            this.Sterge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sterge.Location = new System.Drawing.Point(723, 488);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(127, 34);
            this.Sterge.TabIndex = 6;
            this.Sterge.Text = "Șterge";
            this.Sterge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sterge.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // CantitateAdd
            // 
            this.CantitateAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CantitateAdd.Image = global::Licenta.Properties.Resources.Plus;
            this.CantitateAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CantitateAdd.Location = new System.Drawing.Point(862, 488);
            this.CantitateAdd.Name = "CantitateAdd";
            this.CantitateAdd.Size = new System.Drawing.Size(127, 34);
            this.CantitateAdd.TabIndex = 7;
            this.CantitateAdd.Text = "Cantitate";
            this.CantitateAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CantitateAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CantitateAdd.UseVisualStyleBackColor = true;
            this.CantitateAdd.Click += new System.EventHandler(this.CantitateAdd_Click);
            // 
            // CantitateRemove
            // 
            this.CantitateRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CantitateRemove.Image = global::Licenta.Properties.Resources.Minus;
            this.CantitateRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CantitateRemove.Location = new System.Drawing.Point(998, 488);
            this.CantitateRemove.Name = "CantitateRemove";
            this.CantitateRemove.Size = new System.Drawing.Size(127, 34);
            this.CantitateRemove.TabIndex = 8;
            this.CantitateRemove.Text = "Cantitate";
            this.CantitateRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CantitateRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CantitateRemove.UseVisualStyleBackColor = true;
            this.CantitateRemove.Click += new System.EventHandler(this.CantitateRemove_Click);
            // 
            // Vanzare
            // 
            this.Vanzare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Vanzare.Image = global::Licenta.Properties.Resources.Insert;
            this.Vanzare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vanzare.Location = new System.Drawing.Point(723, 528);
            this.Vanzare.Name = "Vanzare";
            this.Vanzare.Size = new System.Drawing.Size(402, 34);
            this.Vanzare.TabIndex = 9;
            this.Vanzare.Text = "Finalizează cumpărăturile";
            this.Vanzare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Vanzare.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Vanzare.UseVisualStyleBackColor = true;
            this.Vanzare.Click += new System.EventHandler(this.Vanzare_Click);
            // 
            // QrBon
            // 
            this.QrBon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QrBon.BackColor = System.Drawing.Color.Transparent;
            this.QrBon.Location = new System.Drawing.Point(382, 458);
            this.QrBon.Name = "QrBon";
            this.QrBon.Size = new System.Drawing.Size(280, 213);
            this.QrBon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QrBon.TabIndex = 10;
            this.QrBon.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Image = global::Licenta.Properties.Resources.Delivery;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox1.Location = new System.Drawing.Point(1134, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Livrare la domiciliu";
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adresă";
            // 
            // Adresa
            // 
            this.Adresa.Location = new System.Drawing.Point(86, 94);
            this.Adresa.Multiline = true;
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(240, 94);
            this.Adresa.TabIndex = 13;
            // 
            // DomiciliuPanel
            // 
            this.DomiciliuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DomiciliuPanel.BackColor = System.Drawing.Color.Transparent;
            this.DomiciliuPanel.Controls.Add(this.Email);
            this.DomiciliuPanel.Controls.Add(this.label4);
            this.DomiciliuPanel.Controls.Add(this.Prenume);
            this.DomiciliuPanel.Controls.Add(this.Nume);
            this.DomiciliuPanel.Controls.Add(this.label3);
            this.DomiciliuPanel.Controls.Add(this.label2);
            this.DomiciliuPanel.Controls.Add(this.Adresa);
            this.DomiciliuPanel.Controls.Add(this.label1);
            this.DomiciliuPanel.Location = new System.Drawing.Point(1134, 145);
            this.DomiciliuPanel.Name = "DomiciliuPanel";
            this.DomiciliuPanel.Size = new System.Drawing.Size(329, 212);
            this.DomiciliuPanel.TabIndex = 14;
            this.DomiciliuPanel.Visible = false;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(86, 65);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(240, 22);
            this.Email.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // Prenume
            // 
            this.Prenume.Location = new System.Drawing.Point(86, 37);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(240, 22);
            this.Prenume.TabIndex = 17;
            this.Prenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prenume_KeyPress);
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(86, 9);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(240, 22);
            this.Nume.TabIndex = 16;
            this.Nume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nume_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prenume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nume";
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Save.Image = global::Licenta.Properties.Resources.Save;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.Location = new System.Drawing.Point(462, 677);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(136, 41);
            this.Save.TabIndex = 15;
            this.Save.Text = "Salvează QR";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Chestionar
            // 
            this.Chestionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Chestionar.Image = global::Licenta.Properties.Resources.Select;
            this.Chestionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Chestionar.Location = new System.Drawing.Point(723, 568);
            this.Chestionar.Name = "Chestionar";
            this.Chestionar.Size = new System.Drawing.Size(402, 34);
            this.Chestionar.TabIndex = 16;
            this.Chestionar.Text = "Realizare chestionar";
            this.Chestionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Chestionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Chestionar.UseVisualStyleBackColor = true;
            this.Chestionar.Visible = false;
            this.Chestionar.Click += new System.EventHandler(this.Chestionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(592, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Vânzare produse";
            // 
            // IntroducereVanzare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1475, 722);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Chestionar);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DomiciliuPanel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.QrBon);
            this.Controls.Add(this.Vanzare);
            this.Controls.Add(this.CantitateRemove);
            this.Controls.Add(this.CantitateAdd);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.ProduseSelect);
            this.Controls.Add(this.QrVerify);
            this.Controls.Add(this.ProduseLabel);
            this.Controls.Add(this.Bon);
            this.Controls.Add(this.ScanImage);
            this.Controls.Add(this.Camera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroducereVanzare";
            this.Text = "IntroducereVanzareScan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IntroducereVanzare_FormClosed);
            this.Load += new System.EventHandler(this.IntroducereVanzareScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScanImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrVerify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QrBon)).EndInit();
            this.DomiciliuPanel.ResumeLayout(false);
            this.DomiciliuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Camera;
        private System.Windows.Forms.PictureBox ScanImage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Bon;
        private System.Windows.Forms.Label ProduseLabel;
        private System.Windows.Forms.PictureBox QrVerify;
        private System.Windows.Forms.ComboBox ProduseSelect;
        private System.Windows.Forms.Button Sterge;
        private System.Windows.Forms.Button CantitateAdd;
        private System.Windows.Forms.Button CantitateRemove;
        private System.Windows.Forms.Button Vanzare;
        private System.Windows.Forms.PictureBox QrBon;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.Panel DomiciliuPanel;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Chestionar;
        private System.Windows.Forms.Label label5;
    }
}