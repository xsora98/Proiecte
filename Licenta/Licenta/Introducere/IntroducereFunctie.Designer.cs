namespace Licenta
{
    partial class IntroducereFunctie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroducereFunctie));
            this.DenumireLabel = new System.Windows.Forms.Label();
            this.SalariuLabel = new System.Windows.Forms.Label();
            this.DepartamentLabel = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.Denumire = new System.Windows.Forms.TextBox();
            this.Salariu = new System.Windows.Forms.TextBox();
            this.Departament = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DenumireLabel
            // 
            this.DenumireLabel.AutoSize = true;
            this.DenumireLabel.BackColor = System.Drawing.Color.Transparent;
            this.DenumireLabel.Location = new System.Drawing.Point(65, 129);
            this.DenumireLabel.Name = "DenumireLabel";
            this.DenumireLabel.Size = new System.Drawing.Size(69, 17);
            this.DenumireLabel.TabIndex = 0;
            this.DenumireLabel.Text = "Denumire";
            // 
            // SalariuLabel
            // 
            this.SalariuLabel.AutoSize = true;
            this.SalariuLabel.BackColor = System.Drawing.Color.Transparent;
            this.SalariuLabel.Location = new System.Drawing.Point(65, 208);
            this.SalariuLabel.Name = "SalariuLabel";
            this.SalariuLabel.Size = new System.Drawing.Size(52, 17);
            this.SalariuLabel.TabIndex = 1;
            this.SalariuLabel.Text = "Salariu";
            // 
            // DepartamentLabel
            // 
            this.DepartamentLabel.AutoSize = true;
            this.DepartamentLabel.BackColor = System.Drawing.Color.Transparent;
            this.DepartamentLabel.Location = new System.Drawing.Point(65, 166);
            this.DepartamentLabel.Name = "DepartamentLabel";
            this.DepartamentLabel.Size = new System.Drawing.Size(90, 17);
            this.DepartamentLabel.TabIndex = 2;
            this.DepartamentLabel.Text = "Departament";
            // 
            // Insert
            // 
            this.Insert.Image = global::Licenta.Properties.Resources.Insert;
            this.Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Insert.Location = new System.Drawing.Point(175, 262);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(111, 42);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Adaugă";
            this.Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Denumire
            // 
            this.Denumire.Location = new System.Drawing.Point(162, 126);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(188, 22);
            this.Denumire.TabIndex = 4;
            this.Denumire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Denumire_KeyPress);
            // 
            // Salariu
            // 
            this.Salariu.Location = new System.Drawing.Point(162, 205);
            this.Salariu.Name = "Salariu";
            this.Salariu.Size = new System.Drawing.Size(188, 22);
            this.Salariu.TabIndex = 5;
            this.Salariu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Salariu_KeyPress);
            // 
            // Departament
            // 
            this.Departament.FormattingEnabled = true;
            this.Departament.Location = new System.Drawing.Point(162, 163);
            this.Departament.Name = "Departament";
            this.Departament.Size = new System.Drawing.Size(188, 24);
            this.Departament.TabIndex = 6;
            this.Departament.Text = "Selectează departamentul";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adăugare funcție";
            // 
            // IntroducereFunctie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(430, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Departament);
            this.Controls.Add(this.Salariu);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.DepartamentLabel);
            this.Controls.Add(this.SalariuLabel);
            this.Controls.Add(this.DenumireLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroducereFunctie";
            this.Text = "IntroducereFunctie";
            this.Load += new System.EventHandler(this.IntroducereFunctie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DenumireLabel;
        private System.Windows.Forms.Label SalariuLabel;
        private System.Windows.Forms.Label DepartamentLabel;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox Denumire;
        private System.Windows.Forms.TextBox Salariu;
        private System.Windows.Forms.ComboBox Departament;
        private System.Windows.Forms.Label label1;
    }
}