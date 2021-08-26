namespace Licenta.Vizualizare
{
    partial class VizualizareAngajat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizareAngajat));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeLabel = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.TextBox();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.PrenumeLabel = new System.Windows.Forms.Label();
            this.Cnp = new System.Windows.Forms.TextBox();
            this.CnpLabel = new System.Windows.Forms.Label();
            this.Cauta = new System.Windows.Forms.Button();
            this.ArataTot = new System.Windows.Forms.Button();
            this.Modifica = new System.Windows.Forms.Button();
            this.Sterge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(831, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // NumeLabel
            // 
            this.NumeLabel.AutoSize = true;
            this.NumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumeLabel.Location = new System.Drawing.Point(12, 79);
            this.NumeLabel.Name = "NumeLabel";
            this.NumeLabel.Size = new System.Drawing.Size(45, 17);
            this.NumeLabel.TabIndex = 1;
            this.NumeLabel.Text = "Nume";
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(64, 76);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(139, 22);
            this.Nume.TabIndex = 2;
            this.Nume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nume_KeyPress);
            // 
            // Prenume
            // 
            this.Prenume.Location = new System.Drawing.Point(280, 76);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(139, 22);
            this.Prenume.TabIndex = 4;
            this.Prenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prenume_KeyPress);
            // 
            // PrenumeLabel
            // 
            this.PrenumeLabel.AutoSize = true;
            this.PrenumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrenumeLabel.Location = new System.Drawing.Point(209, 79);
            this.PrenumeLabel.Name = "PrenumeLabel";
            this.PrenumeLabel.Size = new System.Drawing.Size(65, 17);
            this.PrenumeLabel.TabIndex = 3;
            this.PrenumeLabel.Text = "Prenume";
            // 
            // Cnp
            // 
            this.Cnp.Location = new System.Drawing.Point(467, 76);
            this.Cnp.Name = "Cnp";
            this.Cnp.Size = new System.Drawing.Size(139, 22);
            this.Cnp.TabIndex = 6;
            this.Cnp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cnp_KeyPress);
            // 
            // CnpLabel
            // 
            this.CnpLabel.AutoSize = true;
            this.CnpLabel.BackColor = System.Drawing.Color.Transparent;
            this.CnpLabel.Location = new System.Drawing.Point(425, 79);
            this.CnpLabel.Name = "CnpLabel";
            this.CnpLabel.Size = new System.Drawing.Size(36, 17);
            this.CnpLabel.TabIndex = 5;
            this.CnpLabel.Text = "CNP";
            // 
            // Cauta
            // 
            this.Cauta.Image = global::Licenta.Properties.Resources.Search;
            this.Cauta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cauta.Location = new System.Drawing.Point(622, 73);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(100, 29);
            this.Cauta.TabIndex = 7;
            this.Cauta.Text = "Caută";
            this.Cauta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cauta.UseVisualStyleBackColor = true;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // ArataTot
            // 
            this.ArataTot.Image = global::Licenta.Properties.Resources.ShowAll;
            this.ArataTot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArataTot.Location = new System.Drawing.Point(12, 104);
            this.ArataTot.Name = "ArataTot";
            this.ArataTot.Size = new System.Drawing.Size(191, 29);
            this.ArataTot.TabIndex = 8;
            this.ArataTot.Text = "Arată toți angajații";
            this.ArataTot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArataTot.UseVisualStyleBackColor = true;
            this.ArataTot.Click += new System.EventHandler(this.ArataTot_Click);
            // 
            // Modifica
            // 
            this.Modifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Modifica.Image = global::Licenta.Properties.Resources.Edit;
            this.Modifica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modifica.Location = new System.Drawing.Point(209, 104);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(126, 29);
            this.Modifica.TabIndex = 9;
            this.Modifica.Text = "Modifică";
            this.Modifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Modifica.UseVisualStyleBackColor = true;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // Sterge
            // 
            this.Sterge.Image = global::Licenta.Properties.Resources.Delete;
            this.Sterge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sterge.Location = new System.Drawing.Point(346, 104);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(105, 29);
            this.Sterge.TabIndex = 10;
            this.Sterge.Text = "Șterge";
            this.Sterge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Angajați";
            // 
            // VizualizareAngajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.Modifica);
            this.Controls.Add(this.ArataTot);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.Cnp);
            this.Controls.Add(this.CnpLabel);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.PrenumeLabel);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.NumeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VizualizareAngajat";
            this.Text = "VizualizareAngajat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VizualizareAngajat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label NumeLabel;
        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.Label PrenumeLabel;
        private System.Windows.Forms.TextBox Cnp;
        private System.Windows.Forms.Label CnpLabel;
        private System.Windows.Forms.Button Cauta;
        private System.Windows.Forms.Button ArataTot;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.Button Sterge;
        private System.Windows.Forms.Label label1;
    }
}