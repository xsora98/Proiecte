namespace Licenta
{
    partial class IntroducereProdus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroducereProdus));
            this.ImagineLabel = new System.Windows.Forms.Label();
            this.DenumireLabel = new System.Windows.Forms.Label();
            this.ProducatorLabel = new System.Windows.Forms.Label();
            this.TipLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.PretLabel = new System.Windows.Forms.Label();
            this.DistribuitorLabel = new System.Windows.Forms.Label();
            this.Adauga = new System.Windows.Forms.Button();
            this.Denumire = new System.Windows.Forms.TextBox();
            this.Producator = new System.Windows.Forms.TextBox();
            this.Pret = new System.Windows.Forms.TextBox();
            this.Tip = new System.Windows.Forms.ComboBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.Distribuitor = new System.Windows.Forms.ComboBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Imagine = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Marime = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.QRCode = new System.Windows.Forms.PictureBox();
            this.QRCodeLabel = new System.Windows.Forms.Label();
            this.ImaginePicLabel = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Imagine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagineLabel
            // 
            this.ImagineLabel.AutoSize = true;
            this.ImagineLabel.BackColor = System.Drawing.Color.Transparent;
            this.ImagineLabel.Location = new System.Drawing.Point(597, 173);
            this.ImagineLabel.Name = "ImagineLabel";
            this.ImagineLabel.Size = new System.Drawing.Size(57, 17);
            this.ImagineLabel.TabIndex = 0;
            this.ImagineLabel.Text = "Imagine";
            // 
            // DenumireLabel
            // 
            this.DenumireLabel.AutoSize = true;
            this.DenumireLabel.BackColor = System.Drawing.Color.Transparent;
            this.DenumireLabel.Location = new System.Drawing.Point(597, 210);
            this.DenumireLabel.Name = "DenumireLabel";
            this.DenumireLabel.Size = new System.Drawing.Size(69, 17);
            this.DenumireLabel.TabIndex = 1;
            this.DenumireLabel.Text = "Denumire";
            // 
            // ProducatorLabel
            // 
            this.ProducatorLabel.AutoSize = true;
            this.ProducatorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProducatorLabel.Location = new System.Drawing.Point(597, 248);
            this.ProducatorLabel.Name = "ProducatorLabel";
            this.ProducatorLabel.Size = new System.Drawing.Size(78, 17);
            this.ProducatorLabel.TabIndex = 2;
            this.ProducatorLabel.Text = "Producător";
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.BackColor = System.Drawing.Color.Transparent;
            this.TipLabel.Location = new System.Drawing.Point(597, 285);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(28, 17);
            this.TipLabel.TabIndex = 3;
            this.TipLabel.Text = "Tip";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.BackColor = System.Drawing.Color.Transparent;
            this.SexLabel.Location = new System.Drawing.Point(597, 327);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(31, 17);
            this.SexLabel.TabIndex = 4;
            this.SexLabel.Text = "Sex";
            // 
            // PretLabel
            // 
            this.PretLabel.AutoSize = true;
            this.PretLabel.BackColor = System.Drawing.Color.Transparent;
            this.PretLabel.Location = new System.Drawing.Point(597, 367);
            this.PretLabel.Name = "PretLabel";
            this.PretLabel.Size = new System.Drawing.Size(34, 17);
            this.PretLabel.TabIndex = 5;
            this.PretLabel.Text = "Preț";
            // 
            // DistribuitorLabel
            // 
            this.DistribuitorLabel.AutoSize = true;
            this.DistribuitorLabel.BackColor = System.Drawing.Color.Transparent;
            this.DistribuitorLabel.Location = new System.Drawing.Point(597, 406);
            this.DistribuitorLabel.Name = "DistribuitorLabel";
            this.DistribuitorLabel.Size = new System.Drawing.Size(76, 17);
            this.DistribuitorLabel.TabIndex = 6;
            this.DistribuitorLabel.Text = "Distribuitor";
            // 
            // Adauga
            // 
            this.Adauga.Image = global::Licenta.Properties.Resources.Select;
            this.Adauga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adauga.Location = new System.Drawing.Point(695, 166);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(203, 31);
            this.Adauga.TabIndex = 7;
            this.Adauga.Text = "Adaugă imagine...";
            this.Adauga.UseVisualStyleBackColor = true;
            this.Adauga.Click += new System.EventHandler(this.Adauga_Click);
            // 
            // Denumire
            // 
            this.Denumire.Location = new System.Drawing.Point(695, 207);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(203, 22);
            this.Denumire.TabIndex = 8;
            // 
            // Producator
            // 
            this.Producator.Location = new System.Drawing.Point(695, 245);
            this.Producator.Name = "Producator";
            this.Producator.Size = new System.Drawing.Size(203, 22);
            this.Producator.TabIndex = 9;
            this.Producator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Producator_KeyPress);
            // 
            // Pret
            // 
            this.Pret.Location = new System.Drawing.Point(695, 364);
            this.Pret.Name = "Pret";
            this.Pret.Size = new System.Drawing.Size(203, 22);
            this.Pret.TabIndex = 11;
            this.Pret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pret_KeyPress);
            // 
            // Tip
            // 
            this.Tip.FormattingEnabled = true;
            this.Tip.Items.AddRange(new object[] {
            "Casual",
            "Sport",
            "Running",
            "Hiking",
            "Elegance"});
            this.Tip.Location = new System.Drawing.Point(695, 282);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(203, 24);
            this.Tip.TabIndex = 12;
            this.Tip.Text = "Selectează tipul";
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "Masculin",
            "Feminin",
            "Unisex"});
            this.Sex.Location = new System.Drawing.Point(695, 324);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(203, 24);
            this.Sex.TabIndex = 13;
            this.Sex.Text = "Selectează sexul";
            // 
            // Distribuitor
            // 
            this.Distribuitor.FormattingEnabled = true;
            this.Distribuitor.Location = new System.Drawing.Point(695, 403);
            this.Distribuitor.Name = "Distribuitor";
            this.Distribuitor.Size = new System.Drawing.Size(203, 24);
            this.Distribuitor.TabIndex = 14;
            this.Distribuitor.Text = "Selectează distribuitorul";
            // 
            // Insert
            // 
            this.Insert.Image = global::Licenta.Properties.Resources.Insert;
            this.Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Insert.Location = new System.Drawing.Point(720, 502);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(109, 38);
            this.Insert.TabIndex = 15;
            this.Insert.Text = "Adaugă";
            this.Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Imagine
            // 
            this.Imagine.BackColor = System.Drawing.Color.Transparent;
            this.Imagine.Location = new System.Drawing.Point(74, 86);
            this.Imagine.Name = "Imagine";
            this.Imagine.Size = new System.Drawing.Size(391, 278);
            this.Imagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagine.TabIndex = 16;
            this.Imagine.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(597, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mărime";
            // 
            // Marime
            // 
            this.Marime.Image = global::Licenta.Properties.Resources.Select;
            this.Marime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Marime.Location = new System.Drawing.Point(695, 442);
            this.Marime.Name = "Marime";
            this.Marime.Size = new System.Drawing.Size(203, 31);
            this.Marime.TabIndex = 18;
            this.Marime.Text = "Selectează mărimile...";
            this.Marime.UseVisualStyleBackColor = true;
            this.Marime.Click += new System.EventHandler(this.Marime_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFile";
            // 
            // QRCode
            // 
            this.QRCode.BackColor = System.Drawing.Color.Transparent;
            this.QRCode.Location = new System.Drawing.Point(74, 406);
            this.QRCode.Name = "QRCode";
            this.QRCode.Size = new System.Drawing.Size(391, 278);
            this.QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRCode.TabIndex = 19;
            this.QRCode.TabStop = false;
            // 
            // QRCodeLabel
            // 
            this.QRCodeLabel.AutoSize = true;
            this.QRCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.QRCodeLabel.Location = new System.Drawing.Point(238, 386);
            this.QRCodeLabel.Name = "QRCodeLabel";
            this.QRCodeLabel.Size = new System.Drawing.Size(66, 17);
            this.QRCodeLabel.TabIndex = 20;
            this.QRCodeLabel.Text = "QR Code";
            // 
            // ImaginePicLabel
            // 
            this.ImaginePicLabel.AutoSize = true;
            this.ImaginePicLabel.BackColor = System.Drawing.Color.Transparent;
            this.ImaginePicLabel.Location = new System.Drawing.Point(241, 63);
            this.ImaginePicLabel.Name = "ImaginePicLabel";
            this.ImaginePicLabel.Size = new System.Drawing.Size(57, 17);
            this.ImaginePicLabel.TabIndex = 21;
            this.ImaginePicLabel.Text = "Imagine";
            // 
            // Save
            // 
            this.Save.Image = global::Licenta.Properties.Resources.Save;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.Location = new System.Drawing.Point(190, 690);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(163, 45);
            this.Save.TabIndex = 22;
            this.Save.Text = "Salvează QR";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 36);
            this.label2.TabIndex = 23;
            this.label2.Text = "Adăugare produs";
            // 
            // IntroducereProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 746);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ImaginePicLabel);
            this.Controls.Add(this.QRCodeLabel);
            this.Controls.Add(this.QRCode);
            this.Controls.Add(this.Marime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imagine);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Distribuitor);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.Pret);
            this.Controls.Add(this.Producator);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.Adauga);
            this.Controls.Add(this.DistribuitorLabel);
            this.Controls.Add(this.PretLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.ProducatorLabel);
            this.Controls.Add(this.DenumireLabel);
            this.Controls.Add(this.ImagineLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroducereProdus";
            this.Text = "IntroducereProdus";
            this.Load += new System.EventHandler(this.IntroducereProdus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imagine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImagineLabel;
        private System.Windows.Forms.Label DenumireLabel;
        private System.Windows.Forms.Label ProducatorLabel;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label PretLabel;
        private System.Windows.Forms.Label DistribuitorLabel;
        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.TextBox Denumire;
        private System.Windows.Forms.TextBox Producator;
        private System.Windows.Forms.TextBox Pret;
        private System.Windows.Forms.ComboBox Tip;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.ComboBox Distribuitor;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.PictureBox Imagine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Marime;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox QRCode;
        private System.Windows.Forms.Label QRCodeLabel;
        private System.Windows.Forms.Label ImaginePicLabel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
    }
}