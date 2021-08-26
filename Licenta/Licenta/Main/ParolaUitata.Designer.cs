namespace Licenta
{
    partial class ParolaUitata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParolaUitata));
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Trimite = new System.Windows.Forms.Button();
            this.CodExistent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(95, 148);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(143, 145);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(225, 22);
            this.Email.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(98, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(270, 57);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Vă rugăm să introduceți email-ul dumneavoastră pentru a putea primi parola asocia" +
    "tă contului.";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Trimite
            // 
            this.Trimite.Image = global::Licenta.Properties.Resources.Send;
            this.Trimite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Trimite.Location = new System.Drawing.Point(197, 173);
            this.Trimite.Name = "Trimite";
            this.Trimite.Size = new System.Drawing.Size(110, 47);
            this.Trimite.TabIndex = 3;
            this.Trimite.Text = "Trimite";
            this.Trimite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Trimite.UseVisualStyleBackColor = true;
            this.Trimite.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodExistent
            // 
            this.CodExistent.Image = global::Licenta.Properties.Resources.Select;
            this.CodExistent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CodExistent.Location = new System.Drawing.Point(173, 226);
            this.CodExistent.Name = "CodExistent";
            this.CodExistent.Size = new System.Drawing.Size(159, 47);
            this.CodExistent.TabIndex = 4;
            this.CodExistent.Text = "Am deja un cod";
            this.CodExistent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CodExistent.UseVisualStyleBackColor = true;
            this.CodExistent.Click += new System.EventHandler(this.CodExistent_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Recuperare parolă";
            // 
            // ParolaUitata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodExistent);
            this.Controls.Add(this.Trimite);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EmailLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParolaUitata";
            this.Text = "ParolaUitata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Trimite;
        private System.Windows.Forms.Button CodExistent;
        private System.Windows.Forms.Label label1;
    }
}