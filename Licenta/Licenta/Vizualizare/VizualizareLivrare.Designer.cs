namespace Licenta.Vizualizare
{
    partial class VizualizareLivrare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizareLivrare));
            this.ArataTot = new System.Windows.Forms.Button();
            this.Cauta = new System.Windows.Forms.Button();
            this.Nume = new System.Windows.Forms.TextBox();
            this.DenumireLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdComanda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ArataTot
            // 
            this.ArataTot.Image = global::Licenta.Properties.Resources.ShowAll;
            this.ArataTot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArataTot.Location = new System.Drawing.Point(12, 113);
            this.ArataTot.Name = "ArataTot";
            this.ArataTot.Size = new System.Drawing.Size(214, 29);
            this.ArataTot.TabIndex = 31;
            this.ArataTot.Text = "Arată toate livrările";
            this.ArataTot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArataTot.UseVisualStyleBackColor = true;
            this.ArataTot.Click += new System.EventHandler(this.ArataTot_Click);
            // 
            // Cauta
            // 
            this.Cauta.Image = global::Licenta.Properties.Resources.Search;
            this.Cauta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cauta.Location = new System.Drawing.Point(683, 85);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(93, 29);
            this.Cauta.TabIndex = 30;
            this.Cauta.Text = "Caută";
            this.Cauta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cauta.UseVisualStyleBackColor = true;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(63, 85);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(163, 22);
            this.Nume.TabIndex = 29;
            this.Nume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nume_KeyPress);
            // 
            // DenumireLabel
            // 
            this.DenumireLabel.AutoSize = true;
            this.DenumireLabel.BackColor = System.Drawing.Color.Transparent;
            this.DenumireLabel.Location = new System.Drawing.Point(12, 87);
            this.DenumireLabel.Name = "DenumireLabel";
            this.DenumireLabel.Size = new System.Drawing.Size(45, 17);
            this.DenumireLabel.TabIndex = 28;
            this.DenumireLabel.Text = "Nume";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(822, 375);
            this.dataGridView1.TabIndex = 27;
            // 
            // Prenume
            // 
            this.Prenume.Location = new System.Drawing.Point(304, 87);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(139, 22);
            this.Prenume.TabIndex = 34;
            this.Prenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prenume_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(233, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Prenume";
            // 
            // IdComanda
            // 
            this.IdComanda.Location = new System.Drawing.Point(538, 87);
            this.IdComanda.Name = "IdComanda";
            this.IdComanda.Size = new System.Drawing.Size(139, 22);
            this.IdComanda.TabIndex = 36;
            this.IdComanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdComanda_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(449, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID comandă";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 36);
            this.label3.TabIndex = 37;
            this.label3.Text = "Livrări";
            // 
            // VizualizareLivrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 535);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdComanda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArataTot);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.DenumireLabel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VizualizareLivrare";
            this.Text = "VizualizareLivrare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VizualizareLivrare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ArataTot;
        private System.Windows.Forms.Button Cauta;
        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.Label DenumireLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdComanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}