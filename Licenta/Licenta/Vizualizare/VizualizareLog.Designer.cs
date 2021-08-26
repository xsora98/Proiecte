namespace Licenta.Vizualizare
{
    partial class VizualizareLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizareLog));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ArataTot = new System.Windows.Forms.Button();
            this.Cauta = new System.Windows.Forms.Button();
            this.Idsearch = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(791, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // ArataTot
            // 
            this.ArataTot.Image = global::Licenta.Properties.Resources.ShowAll;
            this.ArataTot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArataTot.Location = new System.Drawing.Point(12, 94);
            this.ArataTot.Name = "ArataTot";
            this.ArataTot.Size = new System.Drawing.Size(212, 29);
            this.ArataTot.TabIndex = 12;
            this.ArataTot.Text = "Arată tot istoricul";
            this.ArataTot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArataTot.UseVisualStyleBackColor = true;
            this.ArataTot.Click += new System.EventHandler(this.ArataTot_Click);
            // 
            // Cauta
            // 
            this.Cauta.Image = global::Licenta.Properties.Resources.Search;
            this.Cauta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cauta.Location = new System.Drawing.Point(230, 66);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(97, 30);
            this.Cauta.TabIndex = 11;
            this.Cauta.Text = "Caută";
            this.Cauta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cauta.UseVisualStyleBackColor = true;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // Idsearch
            // 
            this.Idsearch.Location = new System.Drawing.Point(37, 66);
            this.Idsearch.Name = "Idsearch";
            this.Idsearch.Size = new System.Drawing.Size(187, 22);
            this.Idsearch.TabIndex = 10;
            this.Idsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Idsearch_KeyPress);
            // 
            // NumeLabel
            // 
            this.NumeLabel.AutoSize = true;
            this.NumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumeLabel.Location = new System.Drawing.Point(12, 69);
            this.NumeLabel.Name = "NumeLabel";
            this.NumeLabel.Size = new System.Drawing.Size(21, 17);
            this.NumeLabel.TabIndex = 9;
            this.NumeLabel.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Istoric";
            // 
            // VizualizareLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArataTot);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.Idsearch);
            this.Controls.Add(this.NumeLabel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VizualizareLog";
            this.Text = "VizualizareLog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VizualizareLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ArataTot;
        private System.Windows.Forms.Button Cauta;
        private System.Windows.Forms.TextBox Idsearch;
        private System.Windows.Forms.Label NumeLabel;
        private System.Windows.Forms.Label label1;
    }
}