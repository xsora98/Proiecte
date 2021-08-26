namespace Licenta
{
    partial class VizualizareProduse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizareProduse));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producator = new System.Windows.Forms.TextBox();
            this.Denumire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.ComboBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cauta = new System.Windows.Forms.Button();
            this.ArataTot = new System.Windows.Forms.Button();
            this.Modifica = new System.Windows.Forms.Button();
            this.ModificaImagine = new System.Windows.Forms.Button();
            this.Aprovizionare = new System.Windows.Forms.Button();
            this.VerificareStoc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 250;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1416, 570);
            this.dataGridView1.TabIndex = 0;
            // 
            // Producator
            // 
            this.Producator.Location = new System.Drawing.Point(96, 82);
            this.Producator.Name = "Producator";
            this.Producator.Size = new System.Drawing.Size(165, 22);
            this.Producator.TabIndex = 1;
            this.Producator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Producator_KeyPress);
            // 
            // Denumire
            // 
            this.Denumire.Location = new System.Drawing.Point(342, 82);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(165, 22);
            this.Denumire.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(267, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(513, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip";
            // 
            // Tip
            // 
            this.Tip.DisplayMember = "(none)";
            this.Tip.FormattingEnabled = true;
            this.Tip.Items.AddRange(new object[] {
            "Casual",
            "Sport",
            "Running",
            "Hiking",
            "Elegance"});
            this.Tip.Location = new System.Drawing.Point(547, 82);
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(165, 24);
            this.Tip.TabIndex = 6;
            // 
            // Sex
            // 
            this.Sex.DisplayMember = "(none)";
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "Masculin",
            "Feminin",
            "Unisex"});
            this.Sex.Location = new System.Drawing.Point(755, 82);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(165, 24);
            this.Sex.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(718, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sex";
            // 
            // cauta
            // 
            this.cauta.Image = global::Licenta.Properties.Resources.Search;
            this.cauta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cauta.Location = new System.Drawing.Point(926, 79);
            this.cauta.Name = "cauta";
            this.cauta.Size = new System.Drawing.Size(110, 32);
            this.cauta.TabIndex = 9;
            this.cauta.Text = "Caută";
            this.cauta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cauta.UseVisualStyleBackColor = true;
            this.cauta.Click += new System.EventHandler(this.cauta_Click);
            // 
            // ArataTot
            // 
            this.ArataTot.Image = global::Licenta.Properties.Resources.ShowAll;
            this.ArataTot.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ArataTot.Location = new System.Drawing.Point(12, 124);
            this.ArataTot.Name = "ArataTot";
            this.ArataTot.Size = new System.Drawing.Size(249, 34);
            this.ArataTot.TabIndex = 10;
            this.ArataTot.Text = "Arată toate produsele";
            this.ArataTot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArataTot.UseVisualStyleBackColor = true;
            this.ArataTot.Click += new System.EventHandler(this.ArataTot_Click);
            // 
            // Modifica
            // 
            this.Modifica.Image = global::Licenta.Properties.Resources.Edit;
            this.Modifica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modifica.Location = new System.Drawing.Point(463, 124);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(187, 34);
            this.Modifica.TabIndex = 12;
            this.Modifica.Text = "Modifică";
            this.Modifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Modifica.UseVisualStyleBackColor = true;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // ModificaImagine
            // 
            this.ModificaImagine.Image = global::Licenta.Properties.Resources.Edit;
            this.ModificaImagine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModificaImagine.Location = new System.Drawing.Point(656, 124);
            this.ModificaImagine.Name = "ModificaImagine";
            this.ModificaImagine.Size = new System.Drawing.Size(187, 34);
            this.ModificaImagine.TabIndex = 14;
            this.ModificaImagine.Text = "Modifică imaginea";
            this.ModificaImagine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ModificaImagine.UseVisualStyleBackColor = true;
            this.ModificaImagine.Click += new System.EventHandler(this.ModificaImagine_Click);
            // 
            // Aprovizionare
            // 
            this.Aprovizionare.Image = global::Licenta.Properties.Resources.Update;
            this.Aprovizionare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aprovizionare.Location = new System.Drawing.Point(849, 124);
            this.Aprovizionare.Name = "Aprovizionare";
            this.Aprovizionare.Size = new System.Drawing.Size(187, 34);
            this.Aprovizionare.TabIndex = 15;
            this.Aprovizionare.Text = "Aprovizionare";
            this.Aprovizionare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Aprovizionare.UseVisualStyleBackColor = true;
            this.Aprovizionare.Click += new System.EventHandler(this.Aprovizionare_Click);
            // 
            // VerificareStoc
            // 
            this.VerificareStoc.Image = global::Licenta.Properties.Resources.Select;
            this.VerificareStoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VerificareStoc.Location = new System.Drawing.Point(270, 124);
            this.VerificareStoc.Name = "VerificareStoc";
            this.VerificareStoc.Size = new System.Drawing.Size(187, 34);
            this.VerificareStoc.TabIndex = 11;
            this.VerificareStoc.Text = "Verificare stoc";
            this.VerificareStoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VerificareStoc.UseVisualStyleBackColor = true;
            this.VerificareStoc.Click += new System.EventHandler(this.VerificareStoc_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(636, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 36);
            this.label5.TabIndex = 26;
            this.label5.Text = "Produse";
            // 
            // VizualizareProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1438, 746);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Aprovizionare);
            this.Controls.Add(this.ModificaImagine);
            this.Controls.Add(this.Modifica);
            this.Controls.Add(this.VerificareStoc);
            this.Controls.Add(this.ArataTot);
            this.Controls.Add(this.cauta);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.Producator);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VizualizareProduse";
            this.Text = "VizualizareProduse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VizualizareProduse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Producator;
        private System.Windows.Forms.TextBox Denumire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Tip;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cauta;
        private System.Windows.Forms.Button ArataTot;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.Button ModificaImagine;
        private System.Windows.Forms.Button Aprovizionare;
        private System.Windows.Forms.Button VerificareStoc;
        private System.Windows.Forms.Label label5;
    }
}