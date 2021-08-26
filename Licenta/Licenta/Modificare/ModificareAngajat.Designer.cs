namespace Licenta.Modificare
{
    partial class ModificareAngajat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificareAngajat));
            this.Nume = new System.Windows.Forms.TextBox();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.Functie = new System.Windows.Forms.ComboBox();
            this.EmailCheck = new System.Windows.Forms.CheckBox();
            this.CnpCheck = new System.Windows.Forms.CheckBox();
            this.TelefonCheck = new System.Windows.Forms.CheckBox();
            this.AdresaCheck = new System.Windows.Forms.CheckBox();
            this.PrenumeCheck = new System.Windows.Forms.CheckBox();
            this.NumeCheck = new System.Windows.Forms.CheckBox();
            this.Modifica = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.FunctieCheck = new System.Windows.Forms.CheckBox();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.CNP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nume
            // 
            this.Nume.Enabled = false;
            this.Nume.Location = new System.Drawing.Point(147, 105);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(182, 22);
            this.Nume.TabIndex = 28;
            this.Nume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nume_KeyPress);
            // 
            // Prenume
            // 
            this.Prenume.Enabled = false;
            this.Prenume.Location = new System.Drawing.Point(147, 135);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(182, 22);
            this.Prenume.TabIndex = 27;
            this.Prenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prenume_KeyPress);
            // 
            // Functie
            // 
            this.Functie.Enabled = false;
            this.Functie.FormattingEnabled = true;
            this.Functie.Location = new System.Drawing.Point(147, 351);
            this.Functie.Name = "Functie";
            this.Functie.Size = new System.Drawing.Size(182, 24);
            this.Functie.TabIndex = 25;
            // 
            // EmailCheck
            // 
            this.EmailCheck.AutoSize = true;
            this.EmailCheck.BackColor = System.Drawing.Color.Transparent;
            this.EmailCheck.Location = new System.Drawing.Point(47, 326);
            this.EmailCheck.Name = "EmailCheck";
            this.EmailCheck.Size = new System.Drawing.Size(64, 21);
            this.EmailCheck.TabIndex = 23;
            this.EmailCheck.Text = "Email";
            this.EmailCheck.UseVisualStyleBackColor = false;
            this.EmailCheck.CheckedChanged += new System.EventHandler(this.EmailCheck_CheckedChanged);
            // 
            // CnpCheck
            // 
            this.CnpCheck.AutoSize = true;
            this.CnpCheck.BackColor = System.Drawing.Color.Transparent;
            this.CnpCheck.Location = new System.Drawing.Point(47, 296);
            this.CnpCheck.Name = "CnpCheck";
            this.CnpCheck.Size = new System.Drawing.Size(58, 21);
            this.CnpCheck.TabIndex = 22;
            this.CnpCheck.Text = "CNP";
            this.CnpCheck.UseVisualStyleBackColor = false;
            this.CnpCheck.CheckedChanged += new System.EventHandler(this.CnpCheck_CheckedChanged);
            // 
            // TelefonCheck
            // 
            this.TelefonCheck.AutoSize = true;
            this.TelefonCheck.BackColor = System.Drawing.Color.Transparent;
            this.TelefonCheck.Location = new System.Drawing.Point(47, 266);
            this.TelefonCheck.Name = "TelefonCheck";
            this.TelefonCheck.Size = new System.Drawing.Size(78, 21);
            this.TelefonCheck.TabIndex = 21;
            this.TelefonCheck.Text = "Telefon";
            this.TelefonCheck.UseVisualStyleBackColor = false;
            this.TelefonCheck.CheckedChanged += new System.EventHandler(this.TelefonCheck_CheckedChanged);
            // 
            // AdresaCheck
            // 
            this.AdresaCheck.AutoSize = true;
            this.AdresaCheck.BackColor = System.Drawing.Color.Transparent;
            this.AdresaCheck.Location = new System.Drawing.Point(47, 165);
            this.AdresaCheck.Name = "AdresaCheck";
            this.AdresaCheck.Size = new System.Drawing.Size(75, 21);
            this.AdresaCheck.TabIndex = 20;
            this.AdresaCheck.Text = "Adresa";
            this.AdresaCheck.UseVisualStyleBackColor = false;
            this.AdresaCheck.CheckedChanged += new System.EventHandler(this.AdresaCheck_CheckedChanged);
            // 
            // PrenumeCheck
            // 
            this.PrenumeCheck.AutoSize = true;
            this.PrenumeCheck.BackColor = System.Drawing.Color.Transparent;
            this.PrenumeCheck.Location = new System.Drawing.Point(47, 137);
            this.PrenumeCheck.Name = "PrenumeCheck";
            this.PrenumeCheck.Size = new System.Drawing.Size(87, 21);
            this.PrenumeCheck.TabIndex = 19;
            this.PrenumeCheck.Text = "Prenume";
            this.PrenumeCheck.UseVisualStyleBackColor = false;
            this.PrenumeCheck.CheckedChanged += new System.EventHandler(this.PrenumeCheck_CheckedChanged);
            // 
            // NumeCheck
            // 
            this.NumeCheck.AutoSize = true;
            this.NumeCheck.BackColor = System.Drawing.Color.Transparent;
            this.NumeCheck.Location = new System.Drawing.Point(47, 107);
            this.NumeCheck.Name = "NumeCheck";
            this.NumeCheck.Size = new System.Drawing.Size(67, 21);
            this.NumeCheck.TabIndex = 18;
            this.NumeCheck.Text = "Nume";
            this.NumeCheck.UseVisualStyleBackColor = false;
            this.NumeCheck.CheckedChanged += new System.EventHandler(this.NumeCheck_CheckedChanged);
            // 
            // Modifica
            // 
            this.Modifica.Image = global::Licenta.Properties.Resources.Insert;
            this.Modifica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modifica.Location = new System.Drawing.Point(147, 404);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(116, 42);
            this.Modifica.TabIndex = 17;
            this.Modifica.Text = "Modifică";
            this.Modifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Modifica.UseVisualStyleBackColor = true;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // Email
            // 
            this.Email.Enabled = false;
            this.Email.Location = new System.Drawing.Point(147, 324);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(182, 22);
            this.Email.TabIndex = 16;
            // 
            // FunctieCheck
            // 
            this.FunctieCheck.AutoSize = true;
            this.FunctieCheck.BackColor = System.Drawing.Color.Transparent;
            this.FunctieCheck.Location = new System.Drawing.Point(47, 353);
            this.FunctieCheck.Name = "FunctieCheck";
            this.FunctieCheck.Size = new System.Drawing.Size(76, 21);
            this.FunctieCheck.TabIndex = 29;
            this.FunctieCheck.Text = "Functie";
            this.FunctieCheck.UseVisualStyleBackColor = false;
            this.FunctieCheck.CheckedChanged += new System.EventHandler(this.FunctieCheck_CheckedChanged);
            // 
            // Adresa
            // 
            this.Adresa.Enabled = false;
            this.Adresa.Location = new System.Drawing.Point(147, 163);
            this.Adresa.Multiline = true;
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(182, 95);
            this.Adresa.TabIndex = 30;
            // 
            // Telefon
            // 
            this.Telefon.Enabled = false;
            this.Telefon.Location = new System.Drawing.Point(147, 264);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(182, 22);
            this.Telefon.TabIndex = 31;
            this.Telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefon_KeyPress);
            // 
            // CNP
            // 
            this.CNP.Enabled = false;
            this.CNP.Location = new System.Drawing.Point(147, 294);
            this.CNP.Name = "CNP";
            this.CNP.Size = new System.Drawing.Size(182, 22);
            this.CNP.TabIndex = 32;
            this.CNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CNP_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 36);
            this.label5.TabIndex = 33;
            this.label5.Text = "Produse";
            // 
            // ModificareAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(417, 473);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CNP);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.FunctieCheck);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.Functie);
            this.Controls.Add(this.EmailCheck);
            this.Controls.Add(this.CnpCheck);
            this.Controls.Add(this.TelefonCheck);
            this.Controls.Add(this.AdresaCheck);
            this.Controls.Add(this.PrenumeCheck);
            this.Controls.Add(this.NumeCheck);
            this.Controls.Add(this.Modifica);
            this.Controls.Add(this.Email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificareAngajat";
            this.Text = "ModificareAngajat";
            this.Load += new System.EventHandler(this.ModificareAngajat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.ComboBox Functie;
        private System.Windows.Forms.CheckBox EmailCheck;
        private System.Windows.Forms.CheckBox CnpCheck;
        private System.Windows.Forms.CheckBox TelefonCheck;
        private System.Windows.Forms.CheckBox AdresaCheck;
        private System.Windows.Forms.CheckBox PrenumeCheck;
        private System.Windows.Forms.CheckBox NumeCheck;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.CheckBox FunctieCheck;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.TextBox Telefon;
        private System.Windows.Forms.TextBox CNP;
        private System.Windows.Forms.Label label5;
    }
}