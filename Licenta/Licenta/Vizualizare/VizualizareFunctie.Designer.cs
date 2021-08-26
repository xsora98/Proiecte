namespace Licenta.Vizualizare
{
    partial class VizualizareFunctie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizareFunctie));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ArataTot = new System.Windows.Forms.Button();
            this.Cauta = new System.Windows.Forms.Button();
            this.Denumire = new System.Windows.Forms.TextBox();
            this.DenumireLabel = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // ArataTot
            // 
            this.ArataTot.Image = global::Licenta.Properties.Resources.ShowAll;
            this.ArataTot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArataTot.Location = new System.Drawing.Point(12, 109);
            this.ArataTot.Name = "ArataTot";
            this.ArataTot.Size = new System.Drawing.Size(239, 29);
            this.ArataTot.TabIndex = 24;
            this.ArataTot.Text = "Arată toate funcțiile";
            this.ArataTot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArataTot.UseVisualStyleBackColor = true;
            this.ArataTot.Click += new System.EventHandler(this.ArataTot_Click);
            // 
            // Cauta
            // 
            this.Cauta.Image = global::Licenta.Properties.Resources.Search;
            this.Cauta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cauta.Location = new System.Drawing.Point(257, 77);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(100, 29);
            this.Cauta.TabIndex = 23;
            this.Cauta.Text = "Caută";
            this.Cauta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cauta.UseVisualStyleBackColor = true;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // Denumire
            // 
            this.Denumire.Location = new System.Drawing.Point(87, 81);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(164, 22);
            this.Denumire.TabIndex = 22;
            this.Denumire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Denumire_KeyPress);
            // 
            // DenumireLabel
            // 
            this.DenumireLabel.AutoSize = true;
            this.DenumireLabel.BackColor = System.Drawing.Color.Transparent;
            this.DenumireLabel.Location = new System.Drawing.Point(12, 83);
            this.DenumireLabel.Name = "DenumireLabel";
            this.DenumireLabel.Size = new System.Drawing.Size(69, 17);
            this.DenumireLabel.TabIndex = 21;
            this.DenumireLabel.Text = "Denumire";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Funcții";
            // 
            // VizualizareFunctie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArataTot);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.DenumireLabel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VizualizareFunctie";
            this.Text = "VizualizareFunctie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VizualizareFunctie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ArataTot;
        private System.Windows.Forms.Button Cauta;
        private System.Windows.Forms.TextBox Denumire;
        private System.Windows.Forms.Label DenumireLabel;
        private System.Windows.Forms.Label label1;
    }
}