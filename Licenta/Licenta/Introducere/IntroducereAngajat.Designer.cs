namespace Licenta
{
    partial class IntroducereAngajat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroducereAngajat));
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.NumeLabel = new System.Windows.Forms.Label();
            this.PrenumeLabel = new System.Windows.Forms.Label();
            this.AdresaLabel = new System.Windows.Forms.Label();
            this.VarstaLabel = new System.Windows.Forms.Label();
            this.TelefonLabel = new System.Windows.Forms.Label();
            this.CnpLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.DataLabel = new System.Windows.Forms.Label();
            this.FunctieLabel = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.TextBox();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.Varsta = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.CNP = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Durata = new System.Windows.Forms.TextBox();
            this.Functie = new System.Windows.Forms.ComboBox();
            this.DurataLabel = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.CustomFormat = "";
            this.Data.Location = new System.Drawing.Point(274, 437);
            this.Data.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(245, 22);
            this.Data.TabIndex = 18;
            this.Data.Value = new System.DateTime(2021, 2, 19, 8, 13, 47, 0);
            // 
            // NumeLabel
            // 
            this.NumeLabel.AutoSize = true;
            this.NumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumeLabel.Location = new System.Drawing.Point(133, 119);
            this.NumeLabel.Name = "NumeLabel";
            this.NumeLabel.Size = new System.Drawing.Size(45, 17);
            this.NumeLabel.TabIndex = 1;
            this.NumeLabel.Text = "Nume";
            // 
            // PrenumeLabel
            // 
            this.PrenumeLabel.AutoSize = true;
            this.PrenumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrenumeLabel.Location = new System.Drawing.Point(133, 158);
            this.PrenumeLabel.Name = "PrenumeLabel";
            this.PrenumeLabel.Size = new System.Drawing.Size(65, 17);
            this.PrenumeLabel.TabIndex = 2;
            this.PrenumeLabel.Text = "Prenume";
            // 
            // AdresaLabel
            // 
            this.AdresaLabel.AutoSize = true;
            this.AdresaLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdresaLabel.Location = new System.Drawing.Point(133, 195);
            this.AdresaLabel.Name = "AdresaLabel";
            this.AdresaLabel.Size = new System.Drawing.Size(53, 17);
            this.AdresaLabel.TabIndex = 3;
            this.AdresaLabel.Text = "Adresă";
            // 
            // VarstaLabel
            // 
            this.VarstaLabel.AutoSize = true;
            this.VarstaLabel.BackColor = System.Drawing.Color.Transparent;
            this.VarstaLabel.Location = new System.Drawing.Point(133, 285);
            this.VarstaLabel.Name = "VarstaLabel";
            this.VarstaLabel.Size = new System.Drawing.Size(49, 17);
            this.VarstaLabel.TabIndex = 4;
            this.VarstaLabel.Text = "Vârstă";
            // 
            // TelefonLabel
            // 
            this.TelefonLabel.AutoSize = true;
            this.TelefonLabel.BackColor = System.Drawing.Color.Transparent;
            this.TelefonLabel.Location = new System.Drawing.Point(133, 324);
            this.TelefonLabel.Name = "TelefonLabel";
            this.TelefonLabel.Size = new System.Drawing.Size(56, 17);
            this.TelefonLabel.TabIndex = 5;
            this.TelefonLabel.Text = "Telefon";
            // 
            // CnpLabel
            // 
            this.CnpLabel.AutoSize = true;
            this.CnpLabel.BackColor = System.Drawing.Color.Transparent;
            this.CnpLabel.Location = new System.Drawing.Point(133, 366);
            this.CnpLabel.Name = "CnpLabel";
            this.CnpLabel.Size = new System.Drawing.Size(36, 17);
            this.CnpLabel.TabIndex = 6;
            this.CnpLabel.Text = "CNP";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Location = new System.Drawing.Point(133, 404);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email";
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.BackColor = System.Drawing.Color.Transparent;
            this.DataLabel.Location = new System.Drawing.Point(133, 442);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(96, 17);
            this.DataLabel.TabIndex = 8;
            this.DataLabel.Text = "Data angajării";
            // 
            // FunctieLabel
            // 
            this.FunctieLabel.AutoSize = true;
            this.FunctieLabel.BackColor = System.Drawing.Color.Transparent;
            this.FunctieLabel.Location = new System.Drawing.Point(133, 519);
            this.FunctieLabel.Name = "FunctieLabel";
            this.FunctieLabel.Size = new System.Drawing.Size(54, 17);
            this.FunctieLabel.TabIndex = 10;
            this.FunctieLabel.Text = "Funcția";
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(274, 116);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(245, 22);
            this.Nume.TabIndex = 11;
            this.Nume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nume_KeyPress);
            // 
            // Prenume
            // 
            this.Prenume.Location = new System.Drawing.Point(274, 155);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(245, 22);
            this.Prenume.TabIndex = 12;
            this.Prenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prenume_KeyPress);
            // 
            // Adresa
            // 
            this.Adresa.Location = new System.Drawing.Point(274, 192);
            this.Adresa.Multiline = true;
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(245, 71);
            this.Adresa.TabIndex = 13;
            // 
            // Varsta
            // 
            this.Varsta.Location = new System.Drawing.Point(274, 282);
            this.Varsta.Name = "Varsta";
            this.Varsta.Size = new System.Drawing.Size(245, 22);
            this.Varsta.TabIndex = 14;
            this.Varsta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Varsta_KeyPress);
            // 
            // Telefon
            // 
            this.Telefon.Location = new System.Drawing.Point(274, 321);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(245, 22);
            this.Telefon.TabIndex = 15;
            this.Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefon_KeyPress);
            // 
            // CNP
            // 
            this.CNP.Location = new System.Drawing.Point(274, 363);
            this.CNP.Name = "CNP";
            this.CNP.Size = new System.Drawing.Size(245, 22);
            this.CNP.TabIndex = 16;
            this.CNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CNP_KeyPress);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(274, 401);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(245, 22);
            this.Email.TabIndex = 17;
            // 
            // Durata
            // 
            this.Durata.Location = new System.Drawing.Point(274, 479);
            this.Durata.Name = "Durata";
            this.Durata.Size = new System.Drawing.Size(245, 22);
            this.Durata.TabIndex = 19;
            this.Durata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Durata_KeyPress);
            // 
            // Functie
            // 
            this.Functie.FormattingEnabled = true;
            this.Functie.Location = new System.Drawing.Point(274, 516);
            this.Functie.Name = "Functie";
            this.Functie.Size = new System.Drawing.Size(245, 24);
            this.Functie.TabIndex = 20;
            this.Functie.Text = "Selectează funcția";
            // 
            // DurataLabel
            // 
            this.DurataLabel.AutoSize = true;
            this.DurataLabel.BackColor = System.Drawing.Color.Transparent;
            this.DurataLabel.Location = new System.Drawing.Point(133, 482);
            this.DurataLabel.Name = "DurataLabel";
            this.DurataLabel.Size = new System.Drawing.Size(128, 17);
            this.DurataLabel.TabIndex = 9;
            this.DurataLabel.Text = "Durata contractului";
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.SystemColors.Control;
            this.Insert.Image = global::Licenta.Properties.Resources.Insert;
            this.Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Insert.Location = new System.Drawing.Point(274, 572);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(104, 36);
            this.Insert.TabIndex = 21;
            this.Insert.Text = "Adaugă";
            this.Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Adăugare angajat";
            // 
            // IntroducereAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(678, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Functie);
            this.Controls.Add(this.Durata);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.CNP);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Varsta);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.FunctieLabel);
            this.Controls.Add(this.DurataLabel);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.CnpLabel);
            this.Controls.Add(this.TelefonLabel);
            this.Controls.Add(this.VarstaLabel);
            this.Controls.Add(this.AdresaLabel);
            this.Controls.Add(this.PrenumeLabel);
            this.Controls.Add(this.NumeLabel);
            this.Controls.Add(this.Data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroducereAngajat";
            this.Text = "IntroducereAngajat";
            this.Load += new System.EventHandler(this.IntroducereAngajat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.Label NumeLabel;
        private System.Windows.Forms.Label PrenumeLabel;
        private System.Windows.Forms.Label AdresaLabel;
        private System.Windows.Forms.Label VarstaLabel;
        private System.Windows.Forms.Label TelefonLabel;
        private System.Windows.Forms.Label CnpLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label FunctieLabel;
        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.TextBox Varsta;
        private System.Windows.Forms.TextBox Telefon;
        private System.Windows.Forms.TextBox CNP;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Durata;
        private System.Windows.Forms.ComboBox Functie;
        private System.Windows.Forms.Label DurataLabel;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label1;
    }
}