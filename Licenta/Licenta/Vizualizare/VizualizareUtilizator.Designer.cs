namespace Licenta.Vizualizare
{
    partial class VizualizareUtilizator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizareUtilizator));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sterge = new System.Windows.Forms.Button();
            this.ArataTot = new System.Windows.Forms.Button();
            this.Cauta = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.PrenumeLabel = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.TextBox();
            this.NumeLabel = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // Sterge
            // 
            this.Sterge.Image = global::Licenta.Properties.Resources.Delete;
            this.Sterge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sterge.Location = new System.Drawing.Point(206, 107);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(102, 29);
            this.Sterge.TabIndex = 20;
            this.Sterge.Text = "Sterge";
            this.Sterge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // ArataTot
            // 
            this.ArataTot.Image = global::Licenta.Properties.Resources.ShowAll;
            this.ArataTot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArataTot.Location = new System.Drawing.Point(12, 107);
            this.ArataTot.Name = "ArataTot";
            this.ArataTot.Size = new System.Drawing.Size(188, 29);
            this.ArataTot.TabIndex = 18;
            this.ArataTot.Text = "Arata toti utilizatorii";
            this.ArataTot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArataTot.UseVisualStyleBackColor = true;
            this.ArataTot.Click += new System.EventHandler(this.ArataTot_Click);
            // 
            // Cauta
            // 
            this.Cauta.Image = global::Licenta.Properties.Resources.Search;
            this.Cauta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cauta.Location = new System.Drawing.Point(618, 75);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(101, 29);
            this.Cauta.TabIndex = 17;
            this.Cauta.Text = "Caută";
            this.Cauta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cauta.UseVisualStyleBackColor = true;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(473, 79);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(139, 22);
            this.Email.TabIndex = 16;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Location = new System.Drawing.Point(425, 82);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "Email";
            // 
            // Prenume
            // 
            this.Prenume.Location = new System.Drawing.Point(280, 79);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(139, 22);
            this.Prenume.TabIndex = 14;
            this.Prenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prenume_KeyPress);
            // 
            // PrenumeLabel
            // 
            this.PrenumeLabel.AutoSize = true;
            this.PrenumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrenumeLabel.Location = new System.Drawing.Point(206, 82);
            this.PrenumeLabel.Name = "PrenumeLabel";
            this.PrenumeLabel.Size = new System.Drawing.Size(65, 17);
            this.PrenumeLabel.TabIndex = 13;
            this.PrenumeLabel.Text = "Prenume";
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(61, 79);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(139, 22);
            this.Nume.TabIndex = 12;
            this.Nume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nume_KeyPress);
            // 
            // NumeLabel
            // 
            this.NumeLabel.AutoSize = true;
            this.NumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumeLabel.Location = new System.Drawing.Point(12, 82);
            this.NumeLabel.Name = "NumeLabel";
            this.NumeLabel.Size = new System.Drawing.Size(45, 17);
            this.NumeLabel.TabIndex = 11;
            this.NumeLabel.Text = "Nume";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Utilizatori";
            // 
            // VizualizareUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.ArataTot);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.PrenumeLabel);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.NumeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VizualizareUtilizator";
            this.Text = "VizualizareUtilizator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VizualizareUtilizator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Sterge;
        private System.Windows.Forms.Button ArataTot;
        private System.Windows.Forms.Button Cauta;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.Label PrenumeLabel;
        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.Label NumeLabel;
        private System.Windows.Forms.Label label1;
    }
}