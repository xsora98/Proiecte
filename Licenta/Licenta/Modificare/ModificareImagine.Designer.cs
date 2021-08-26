namespace Licenta
{
    partial class ModificareImagine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificareImagine));
            this.label1 = new System.Windows.Forms.Label();
            this.Imagine = new System.Windows.Forms.PictureBox();
            this.Selecteaza = new System.Windows.Forms.Button();
            this.Modifica = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Imagine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(152, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imagine";
            // 
            // Imagine
            // 
            this.Imagine.BackColor = System.Drawing.Color.Transparent;
            this.Imagine.Location = new System.Drawing.Point(12, 98);
            this.Imagine.Name = "Imagine";
            this.Imagine.Size = new System.Drawing.Size(335, 289);
            this.Imagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagine.TabIndex = 1;
            this.Imagine.TabStop = false;
            // 
            // Selecteaza
            // 
            this.Selecteaza.Image = global::Licenta.Properties.Resources.Select;
            this.Selecteaza.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Selecteaza.Location = new System.Drawing.Point(353, 98);
            this.Selecteaza.Name = "Selecteaza";
            this.Selecteaza.Size = new System.Drawing.Size(217, 44);
            this.Selecteaza.TabIndex = 2;
            this.Selecteaza.Text = "Selectează imaginea...";
            this.Selecteaza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Selecteaza.UseVisualStyleBackColor = true;
            this.Selecteaza.Click += new System.EventHandler(this.Selecteaza_Click);
            // 
            // Modifica
            // 
            this.Modifica.Image = global::Licenta.Properties.Resources.Insert;
            this.Modifica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modifica.Location = new System.Drawing.Point(353, 345);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(217, 42);
            this.Modifica.TabIndex = 3;
            this.Modifica.Text = "Modifică";
            this.Modifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Modifica.UseVisualStyleBackColor = true;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modificare imagine";
            // 
            // ModificareImagine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(582, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Modifica);
            this.Controls.Add(this.Selecteaza);
            this.Controls.Add(this.Imagine);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificareImagine";
            this.Text = "ModificareImagine";
            ((System.ComponentModel.ISupportInitialize)(this.Imagine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Imagine;
        private System.Windows.Forms.Button Selecteaza;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
    }
}