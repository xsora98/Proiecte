namespace Licenta
{
    partial class CodParola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodParola));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cod = new System.Windows.Forms.TextBox();
            this.Trimite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(72, 98);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(196, 47);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Vă rugăm să introduceți codul primit pe email.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cod
            // 
            this.Cod.Location = new System.Drawing.Point(72, 151);
            this.Cod.Name = "Cod";
            this.Cod.Size = new System.Drawing.Size(196, 22);
            this.Cod.TabIndex = 1;
            this.Cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cod_KeyPress);
            // 
            // Trimite
            // 
            this.Trimite.Image = global::Licenta.Properties.Resources.Send;
            this.Trimite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Trimite.Location = new System.Drawing.Point(123, 193);
            this.Trimite.Name = "Trimite";
            this.Trimite.Size = new System.Drawing.Size(98, 41);
            this.Trimite.TabIndex = 2;
            this.Trimite.Text = "Trimite";
            this.Trimite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Trimite.UseVisualStyleBackColor = true;
            this.Trimite.Click += new System.EventHandler(this.Trimite_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Recuperare parolă";
            // 
            // CodParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trimite);
            this.Controls.Add(this.Cod);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodParola";
            this.Text = "CodParola";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CodParola_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Cod;
        private System.Windows.Forms.Button Trimite;
        private System.Windows.Forms.Label label1;
    }
}