namespace Licenta
{
    partial class IntroducereDistribuitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroducereDistribuitor));
            this.Insert = new System.Windows.Forms.Button();
            this.DenumireLabel = new System.Windows.Forms.Label();
            this.AdresaLabel = new System.Windows.Forms.Label();
            this.Denumire = new System.Windows.Forms.TextBox();
            this.Adresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Image = global::Licenta.Properties.Resources.Insert;
            this.Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Insert.Location = new System.Drawing.Point(173, 264);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(117, 42);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Adaugă";
            this.Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // DenumireLabel
            // 
            this.DenumireLabel.AutoSize = true;
            this.DenumireLabel.BackColor = System.Drawing.Color.Transparent;
            this.DenumireLabel.Location = new System.Drawing.Point(78, 104);
            this.DenumireLabel.Name = "DenumireLabel";
            this.DenumireLabel.Size = new System.Drawing.Size(69, 17);
            this.DenumireLabel.TabIndex = 1;
            this.DenumireLabel.Text = "Denumire";
            // 
            // AdresaLabel
            // 
            this.AdresaLabel.AutoSize = true;
            this.AdresaLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdresaLabel.Location = new System.Drawing.Point(78, 149);
            this.AdresaLabel.Name = "AdresaLabel";
            this.AdresaLabel.Size = new System.Drawing.Size(53, 17);
            this.AdresaLabel.TabIndex = 2;
            this.AdresaLabel.Text = "Adresă";
            // 
            // Denumire
            // 
            this.Denumire.Location = new System.Drawing.Point(153, 101);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(205, 22);
            this.Denumire.TabIndex = 3;
            this.Denumire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Denumire_KeyPress);
            // 
            // Adresa
            // 
            this.Adresa.Location = new System.Drawing.Point(153, 146);
            this.Adresa.Multiline = true;
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(205, 88);
            this.Adresa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adăugare distribuitor";
            // 
            // IntroducereDistribuitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(459, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.AdresaLabel);
            this.Controls.Add(this.DenumireLabel);
            this.Controls.Add(this.Insert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroducereDistribuitor";
            this.Text = "IntroducereDistribuitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label DenumireLabel;
        private System.Windows.Forms.Label AdresaLabel;
        private System.Windows.Forms.TextBox Denumire;
        private System.Windows.Forms.TextBox Adresa;
        private System.Windows.Forms.Label label1;
    }
}