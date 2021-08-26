namespace Licenta.Vizualizare
{
    partial class VizualizareProduseVandute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizareProduseVandute));
            this.ArataTot = new System.Windows.Forms.Button();
            this.Cauta = new System.Windows.Forms.Button();
            this.TipLabel = new System.Windows.Forms.Label();
            this.Producator = new System.Windows.Forms.TextBox();
            this.ProducatorLabel = new System.Windows.Forms.Label();
            this.Denumire = new System.Windows.Forms.TextBox();
            this.DenumireLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.ComboBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DistribuitorLabel = new System.Windows.Forms.Label();
            this.Distribuitor = new System.Windows.Forms.ComboBox();
            this.Diagrame = new System.Windows.Forms.Button();
            this.Bon = new System.Windows.Forms.TextBox();
            this.BonLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ArataTot
            // 
            this.ArataTot.Image = global::Licenta.Properties.Resources.ShowAll;
            this.ArataTot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArataTot.Location = new System.Drawing.Point(12, 107);
            this.ArataTot.Name = "ArataTot";
            this.ArataTot.Size = new System.Drawing.Size(214, 29);
            this.ArataTot.TabIndex = 18;
            this.ArataTot.Text = "Arată toate produsele";
            this.ArataTot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArataTot.UseVisualStyleBackColor = true;
            this.ArataTot.Click += new System.EventHandler(this.ArataTot_Click);
            // 
            // Cauta
            // 
            this.Cauta.Image = global::Licenta.Properties.Resources.Search;
            this.Cauta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cauta.Location = new System.Drawing.Point(1233, 76);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(93, 29);
            this.Cauta.TabIndex = 17;
            this.Cauta.Text = "Caută";
            this.Cauta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cauta.UseVisualStyleBackColor = true;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.BackColor = System.Drawing.Color.Transparent;
            this.TipLabel.Location = new System.Drawing.Point(459, 82);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(28, 17);
            this.TipLabel.TabIndex = 15;
            this.TipLabel.Text = "Tip";
            // 
            // Producator
            // 
            this.Producator.Location = new System.Drawing.Point(94, 79);
            this.Producator.Name = "Producator";
            this.Producator.Size = new System.Drawing.Size(139, 22);
            this.Producator.TabIndex = 14;
            this.Producator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Producator_KeyPress);
            // 
            // ProducatorLabel
            // 
            this.ProducatorLabel.AutoSize = true;
            this.ProducatorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProducatorLabel.Location = new System.Drawing.Point(12, 82);
            this.ProducatorLabel.Name = "ProducatorLabel";
            this.ProducatorLabel.Size = new System.Drawing.Size(78, 17);
            this.ProducatorLabel.TabIndex = 13;
            this.ProducatorLabel.Text = "Producator";
            // 
            // Denumire
            // 
            this.Denumire.Location = new System.Drawing.Point(314, 79);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(139, 22);
            this.Denumire.TabIndex = 12;
            // 
            // DenumireLabel
            // 
            this.DenumireLabel.AutoSize = true;
            this.DenumireLabel.BackColor = System.Drawing.Color.Transparent;
            this.DenumireLabel.Location = new System.Drawing.Point(239, 82);
            this.DenumireLabel.Name = "DenumireLabel";
            this.DenumireLabel.Size = new System.Drawing.Size(69, 17);
            this.DenumireLabel.TabIndex = 11;
            this.DenumireLabel.Text = "Denumire";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.BackColor = System.Drawing.Color.Transparent;
            this.SexLabel.Location = new System.Drawing.Point(638, 82);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(31, 17);
            this.SexLabel.TabIndex = 21;
            this.SexLabel.Text = "Sex";
            // 
            // Tip
            // 
            this.Tip.FormattingEnabled = true;
            this.Tip.Items.AddRange(new object[] {
            "Casual",
            "Sport",
            "Running",
            "Hiking",
            "Elegance"});
            this.Tip.Location = new System.Drawing.Point(493, 79);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(139, 24);
            this.Tip.TabIndex = 22;
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "Masculin",
            "Feminin",
            "Unisex"});
            this.Sex.Location = new System.Drawing.Point(675, 79);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(139, 24);
            this.Sex.TabIndex = 23;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1314, 512);
            this.dataGridView1.TabIndex = 24;
            // 
            // DistribuitorLabel
            // 
            this.DistribuitorLabel.AutoSize = true;
            this.DistribuitorLabel.BackColor = System.Drawing.Color.Transparent;
            this.DistribuitorLabel.Location = new System.Drawing.Point(820, 82);
            this.DistribuitorLabel.Name = "DistribuitorLabel";
            this.DistribuitorLabel.Size = new System.Drawing.Size(76, 17);
            this.DistribuitorLabel.TabIndex = 25;
            this.DistribuitorLabel.Text = "Distribuitor";
            // 
            // Distribuitor
            // 
            this.Distribuitor.FormattingEnabled = true;
            this.Distribuitor.Location = new System.Drawing.Point(902, 79);
            this.Distribuitor.Name = "Distribuitor";
            this.Distribuitor.Size = new System.Drawing.Size(139, 24);
            this.Distribuitor.TabIndex = 26;
            // 
            // Diagrame
            // 
            this.Diagrame.Image = global::Licenta.Properties.Resources.ShowAll;
            this.Diagrame.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Diagrame.Location = new System.Drawing.Point(232, 107);
            this.Diagrame.Name = "Diagrame";
            this.Diagrame.Size = new System.Drawing.Size(221, 29);
            this.Diagrame.TabIndex = 27;
            this.Diagrame.Text = "Vizualizare diagrame";
            this.Diagrame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Diagrame.UseVisualStyleBackColor = true;
            this.Diagrame.Click += new System.EventHandler(this.Diagrame_Click);
            // 
            // Bon
            // 
            this.Bon.Location = new System.Drawing.Point(1088, 79);
            this.Bon.Name = "Bon";
            this.Bon.Size = new System.Drawing.Size(139, 22);
            this.Bon.TabIndex = 29;
            this.Bon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bon_KeyPress);
            // 
            // BonLabel
            // 
            this.BonLabel.AutoSize = true;
            this.BonLabel.BackColor = System.Drawing.Color.Transparent;
            this.BonLabel.Location = new System.Drawing.Point(1049, 82);
            this.BonLabel.Name = "BonLabel";
            this.BonLabel.Size = new System.Drawing.Size(33, 17);
            this.BonLabel.TabIndex = 28;
            this.BonLabel.Text = "Bon";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "Vânzări";
            // 
            // VizualizareProduseVandute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 666);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bon);
            this.Controls.Add(this.BonLabel);
            this.Controls.Add(this.Diagrame);
            this.Controls.Add(this.Distribuitor);
            this.Controls.Add(this.DistribuitorLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.ArataTot);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.TipLabel);
            this.Controls.Add(this.Producator);
            this.Controls.Add(this.ProducatorLabel);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.DenumireLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VizualizareProduseVandute";
            this.Text = "VizualizareProduseVandute";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VizualizareProduseVandute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ArataTot;
        private System.Windows.Forms.Button Cauta;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.TextBox Producator;
        private System.Windows.Forms.Label ProducatorLabel;
        private System.Windows.Forms.TextBox Denumire;
        private System.Windows.Forms.Label DenumireLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.ComboBox Tip;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DistribuitorLabel;
        private System.Windows.Forms.ComboBox Distribuitor;
        private System.Windows.Forms.Button Diagrame;
        private System.Windows.Forms.TextBox Bon;
        private System.Windows.Forms.Label BonLabel;
        private System.Windows.Forms.Label label1;
    }
}