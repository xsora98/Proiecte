namespace Licenta
{
    partial class IntroducereUtilizator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroducereUtilizator));
            this.NumeLabel = new System.Windows.Forms.Label();
            this.PrenumeLabel = new System.Windows.Forms.Label();
            this.AdresaLabel = new System.Windows.Forms.Label();
            this.VarstaLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.RolLabel = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.TextBox();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.Varsta = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Rol = new System.Windows.Forms.ComboBox();
            this.Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumeLabel
            // 
            this.NumeLabel.AutoSize = true;
            this.NumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumeLabel.Location = new System.Drawing.Point(52, 94);
            this.NumeLabel.Name = "NumeLabel";
            this.NumeLabel.Size = new System.Drawing.Size(45, 17);
            this.NumeLabel.TabIndex = 0;
            this.NumeLabel.Text = "Nume";
            // 
            // PrenumeLabel
            // 
            this.PrenumeLabel.AutoSize = true;
            this.PrenumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrenumeLabel.Location = new System.Drawing.Point(52, 121);
            this.PrenumeLabel.Name = "PrenumeLabel";
            this.PrenumeLabel.Size = new System.Drawing.Size(65, 17);
            this.PrenumeLabel.TabIndex = 1;
            this.PrenumeLabel.Text = "Prenume";
            // 
            // AdresaLabel
            // 
            this.AdresaLabel.AutoSize = true;
            this.AdresaLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdresaLabel.Location = new System.Drawing.Point(52, 150);
            this.AdresaLabel.Name = "AdresaLabel";
            this.AdresaLabel.Size = new System.Drawing.Size(53, 17);
            this.AdresaLabel.TabIndex = 2;
            this.AdresaLabel.Text = "Adresă";
            // 
            // VarstaLabel
            // 
            this.VarstaLabel.AutoSize = true;
            this.VarstaLabel.BackColor = System.Drawing.Color.Transparent;
            this.VarstaLabel.Location = new System.Drawing.Point(52, 230);
            this.VarstaLabel.Name = "VarstaLabel";
            this.VarstaLabel.Size = new System.Drawing.Size(49, 17);
            this.VarstaLabel.TabIndex = 3;
            this.VarstaLabel.Text = "Vârstă";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Location = new System.Drawing.Point(52, 258);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email";
            // 
            // RolLabel
            // 
            this.RolLabel.AutoSize = true;
            this.RolLabel.BackColor = System.Drawing.Color.Transparent;
            this.RolLabel.Location = new System.Drawing.Point(52, 286);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(29, 17);
            this.RolLabel.TabIndex = 6;
            this.RolLabel.Text = "Rol";
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(125, 91);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(182, 22);
            this.Nume.TabIndex = 7;
            this.Nume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nume_KeyPress);
            // 
            // Prenume
            // 
            this.Prenume.Location = new System.Drawing.Point(125, 118);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(182, 22);
            this.Prenume.TabIndex = 8;
            this.Prenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prenume_KeyPress);
            // 
            // Adresa
            // 
            this.Adresa.Location = new System.Drawing.Point(125, 147);
            this.Adresa.Multiline = true;
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(182, 74);
            this.Adresa.TabIndex = 9;
            // 
            // Varsta
            // 
            this.Varsta.Location = new System.Drawing.Point(125, 227);
            this.Varsta.Name = "Varsta";
            this.Varsta.Size = new System.Drawing.Size(182, 22);
            this.Varsta.TabIndex = 10;
            this.Varsta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Varsta_KeyPress);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(125, 255);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(182, 22);
            this.Email.TabIndex = 11;
            // 
            // Rol
            // 
            this.Rol.FormattingEnabled = true;
            this.Rol.Items.AddRange(new object[] {
            "Admin",
            "Casier"});
            this.Rol.Location = new System.Drawing.Point(125, 286);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(182, 24);
            this.Rol.TabIndex = 12;
            this.Rol.Text = "Selectează rolul";
            // 
            // Insert
            // 
            this.Insert.Image = global::Licenta.Properties.Resources.Insert;
            this.Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Insert.Location = new System.Drawing.Point(146, 334);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(105, 38);
            this.Insert.TabIndex = 13;
            this.Insert.Text = "Adaugă";
            this.Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Adăugare utilizator";
            // 
            // IntroducereUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(375, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Varsta);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.RolLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.VarstaLabel);
            this.Controls.Add(this.AdresaLabel);
            this.Controls.Add(this.PrenumeLabel);
            this.Controls.Add(this.NumeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroducereUtilizator";
            this.Text = "IntroducereUtilizator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeLabel;
        private System.Windows.Forms.Label PrenumeLabel;
        private System.Windows.Forms.Label AdresaLabel;
        private System.Windows.Forms.Label VarstaLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label RolLabel;
        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.TextBox Varsta;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.ComboBox Rol;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label1;
    }
}