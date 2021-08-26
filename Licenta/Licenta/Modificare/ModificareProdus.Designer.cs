namespace Licenta
{
    partial class ModificareProdus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificareProdus));
            this.PretNou = new System.Windows.Forms.TextBox();
            this.Modifica = new System.Windows.Forms.Button();
            this.DenumireCheck = new System.Windows.Forms.CheckBox();
            this.ProducatorCheck = new System.Windows.Forms.CheckBox();
            this.TipCheck = new System.Windows.Forms.CheckBox();
            this.SexCheck = new System.Windows.Forms.CheckBox();
            this.DistribuitorCheck = new System.Windows.Forms.CheckBox();
            this.PretCheck = new System.Windows.Forms.CheckBox();
            this.Distribuitor = new System.Windows.Forms.ComboBox();
            this.Tip = new System.Windows.Forms.ComboBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.Producator = new System.Windows.Forms.TextBox();
            this.Denumire = new System.Windows.Forms.TextBox();
            this.QrCode = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // PretNou
            // 
            this.PretNou.Enabled = false;
            this.PretNou.Location = new System.Drawing.Point(148, 244);
            this.PretNou.Name = "PretNou";
            this.PretNou.Size = new System.Drawing.Size(206, 22);
            this.PretNou.TabIndex = 2;
            this.PretNou.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PretNou_KeyPress);
            // 
            // Modifica
            // 
            this.Modifica.Image = global::Licenta.Properties.Resources.Insert;
            this.Modifica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modifica.Location = new System.Drawing.Point(148, 297);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(127, 43);
            this.Modifica.TabIndex = 4;
            this.Modifica.Text = "Modifică";
            this.Modifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Modifica.UseVisualStyleBackColor = true;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // DenumireCheck
            // 
            this.DenumireCheck.AutoSize = true;
            this.DenumireCheck.BackColor = System.Drawing.Color.Transparent;
            this.DenumireCheck.Location = new System.Drawing.Point(27, 98);
            this.DenumireCheck.Name = "DenumireCheck";
            this.DenumireCheck.Size = new System.Drawing.Size(91, 21);
            this.DenumireCheck.TabIndex = 5;
            this.DenumireCheck.Text = "Denumire";
            this.DenumireCheck.UseVisualStyleBackColor = false;
            this.DenumireCheck.CheckedChanged += new System.EventHandler(this.DenumireCheck_CheckedChanged);
            // 
            // ProducatorCheck
            // 
            this.ProducatorCheck.AutoSize = true;
            this.ProducatorCheck.BackColor = System.Drawing.Color.Transparent;
            this.ProducatorCheck.Location = new System.Drawing.Point(27, 128);
            this.ProducatorCheck.Name = "ProducatorCheck";
            this.ProducatorCheck.Size = new System.Drawing.Size(100, 21);
            this.ProducatorCheck.TabIndex = 6;
            this.ProducatorCheck.Text = "Producator";
            this.ProducatorCheck.UseVisualStyleBackColor = false;
            this.ProducatorCheck.CheckedChanged += new System.EventHandler(this.ProducatorCheck_CheckedChanged);
            // 
            // TipCheck
            // 
            this.TipCheck.AutoSize = true;
            this.TipCheck.BackColor = System.Drawing.Color.Transparent;
            this.TipCheck.Location = new System.Drawing.Point(27, 156);
            this.TipCheck.Name = "TipCheck";
            this.TipCheck.Size = new System.Drawing.Size(50, 21);
            this.TipCheck.TabIndex = 7;
            this.TipCheck.Text = "Tip";
            this.TipCheck.UseVisualStyleBackColor = false;
            this.TipCheck.CheckedChanged += new System.EventHandler(this.TipCheck_CheckedChanged);
            // 
            // SexCheck
            // 
            this.SexCheck.AutoSize = true;
            this.SexCheck.BackColor = System.Drawing.Color.Transparent;
            this.SexCheck.Location = new System.Drawing.Point(27, 186);
            this.SexCheck.Name = "SexCheck";
            this.SexCheck.Size = new System.Drawing.Size(53, 21);
            this.SexCheck.TabIndex = 8;
            this.SexCheck.Text = "Sex";
            this.SexCheck.UseVisualStyleBackColor = false;
            this.SexCheck.CheckedChanged += new System.EventHandler(this.SexCheck_CheckedChanged);
            // 
            // DistribuitorCheck
            // 
            this.DistribuitorCheck.AutoSize = true;
            this.DistribuitorCheck.BackColor = System.Drawing.Color.Transparent;
            this.DistribuitorCheck.Location = new System.Drawing.Point(27, 216);
            this.DistribuitorCheck.Name = "DistribuitorCheck";
            this.DistribuitorCheck.Size = new System.Drawing.Size(98, 21);
            this.DistribuitorCheck.TabIndex = 9;
            this.DistribuitorCheck.Text = "Distribuitor";
            this.DistribuitorCheck.UseVisualStyleBackColor = false;
            this.DistribuitorCheck.CheckedChanged += new System.EventHandler(this.DistribuitorCheck_CheckedChanged);
            // 
            // PretCheck
            // 
            this.PretCheck.AutoSize = true;
            this.PretCheck.BackColor = System.Drawing.Color.Transparent;
            this.PretCheck.Location = new System.Drawing.Point(27, 246);
            this.PretCheck.Name = "PretCheck";
            this.PretCheck.Size = new System.Drawing.Size(56, 21);
            this.PretCheck.TabIndex = 10;
            this.PretCheck.Text = "Preț";
            this.PretCheck.UseVisualStyleBackColor = false;
            this.PretCheck.CheckedChanged += new System.EventHandler(this.PretCheck_CheckedChanged);
            // 
            // Distribuitor
            // 
            this.Distribuitor.Enabled = false;
            this.Distribuitor.FormattingEnabled = true;
            this.Distribuitor.Location = new System.Drawing.Point(148, 214);
            this.Distribuitor.Name = "Distribuitor";
            this.Distribuitor.Size = new System.Drawing.Size(206, 24);
            this.Distribuitor.TabIndex = 11;
            // 
            // Tip
            // 
            this.Tip.Enabled = false;
            this.Tip.FormattingEnabled = true;
            this.Tip.Items.AddRange(new object[] {
            "Casual",
            "Sport",
            "Running",
            "Hiking",
            "Elegance"});
            this.Tip.Location = new System.Drawing.Point(148, 154);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(206, 24);
            this.Tip.TabIndex = 12;
            // 
            // Sex
            // 
            this.Sex.Enabled = false;
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "Masculin",
            "Feminin",
            "Unisex"});
            this.Sex.Location = new System.Drawing.Point(148, 184);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(206, 24);
            this.Sex.TabIndex = 13;
            // 
            // Producator
            // 
            this.Producator.Enabled = false;
            this.Producator.Location = new System.Drawing.Point(148, 126);
            this.Producator.Name = "Producator";
            this.Producator.Size = new System.Drawing.Size(206, 22);
            this.Producator.TabIndex = 14;
            this.Producator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Producator_KeyPress);
            // 
            // Denumire
            // 
            this.Denumire.Enabled = false;
            this.Denumire.Location = new System.Drawing.Point(148, 96);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(206, 22);
            this.Denumire.TabIndex = 15;
            // 
            // QrCode
            // 
            this.QrCode.BackColor = System.Drawing.Color.Transparent;
            this.QrCode.Location = new System.Drawing.Point(393, 95);
            this.QrCode.Name = "QrCode";
            this.QrCode.Size = new System.Drawing.Size(228, 171);
            this.QrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QrCode.TabIndex = 16;
            this.QrCode.TabStop = false;
            this.QrCode.Visible = false;
            // 
            // Save
            // 
            this.Save.Image = global::Licenta.Properties.Resources.Save;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.Location = new System.Drawing.Point(438, 297);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(137, 43);
            this.Save.TabIndex = 17;
            this.Save.Text = "Salvează";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Modificare produs";
            // 
            // ModificareProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(650, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.QrCode);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.Producator);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.Distribuitor);
            this.Controls.Add(this.PretCheck);
            this.Controls.Add(this.DistribuitorCheck);
            this.Controls.Add(this.SexCheck);
            this.Controls.Add(this.TipCheck);
            this.Controls.Add(this.ProducatorCheck);
            this.Controls.Add(this.DenumireCheck);
            this.Controls.Add(this.Modifica);
            this.Controls.Add(this.PretNou);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificareProdus";
            this.Text = "ModificareProdus";
            ((System.ComponentModel.ISupportInitialize)(this.QrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PretNou;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.CheckBox DenumireCheck;
        private System.Windows.Forms.CheckBox ProducatorCheck;
        private System.Windows.Forms.CheckBox TipCheck;
        private System.Windows.Forms.CheckBox SexCheck;
        private System.Windows.Forms.CheckBox DistribuitorCheck;
        private System.Windows.Forms.CheckBox PretCheck;
        private System.Windows.Forms.ComboBox Distribuitor;
        private System.Windows.Forms.ComboBox Tip;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.TextBox Producator;
        private System.Windows.Forms.TextBox Denumire;
        private System.Windows.Forms.PictureBox QrCode;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}