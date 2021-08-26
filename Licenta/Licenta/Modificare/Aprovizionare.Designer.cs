namespace Licenta.Modificare
{
    partial class Aprovizionare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aprovizionare));
            this.MarimeLabel = new System.Windows.Forms.Label();
            this.Marime = new System.Windows.Forms.ComboBox();
            this.NumarProduseLabel = new System.Windows.Forms.Label();
            this.Stoc = new System.Windows.Forms.NumericUpDown();
            this.Actualizeaza = new System.Windows.Forms.Button();
            this.Adauga = new System.Windows.Forms.Button();
            this.ActualizarePanel = new System.Windows.Forms.Panel();
            this.AdaugaPanel = new System.Windows.Forms.Panel();
            this.StocNou = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.MarimeNoua = new System.Windows.Forms.NumericUpDown();
            this.MarimeExistenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MarimeLabel2 = new System.Windows.Forms.Label();
            this.ActualizareStoc = new System.Windows.Forms.Button();
            this.MarimiNoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Stoc)).BeginInit();
            this.ActualizarePanel.SuspendLayout();
            this.AdaugaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StocNou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarimeNoua)).BeginInit();
            this.SuspendLayout();
            // 
            // MarimeLabel
            // 
            this.MarimeLabel.AutoSize = true;
            this.MarimeLabel.Location = new System.Drawing.Point(17, 24);
            this.MarimeLabel.Name = "MarimeLabel";
            this.MarimeLabel.Size = new System.Drawing.Size(54, 17);
            this.MarimeLabel.TabIndex = 0;
            this.MarimeLabel.Text = "Mărime";
            // 
            // Marime
            // 
            this.Marime.FormattingEnabled = true;
            this.Marime.Location = new System.Drawing.Point(129, 24);
            this.Marime.Name = "Marime";
            this.Marime.Size = new System.Drawing.Size(71, 24);
            this.Marime.TabIndex = 1;
            // 
            // NumarProduseLabel
            // 
            this.NumarProduseLabel.AutoSize = true;
            this.NumarProduseLabel.Location = new System.Drawing.Point(17, 61);
            this.NumarProduseLabel.Name = "NumarProduseLabel";
            this.NumarProduseLabel.Size = new System.Drawing.Size(106, 17);
            this.NumarProduseLabel.TabIndex = 2;
            this.NumarProduseLabel.Text = "Număr produse";
            // 
            // Stoc
            // 
            this.Stoc.Location = new System.Drawing.Point(129, 56);
            this.Stoc.Name = "Stoc";
            this.Stoc.Size = new System.Drawing.Size(71, 22);
            this.Stoc.TabIndex = 3;
            // 
            // Actualizeaza
            // 
            this.Actualizeaza.Image = global::Licenta.Properties.Resources.Insert;
            this.Actualizeaza.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Actualizeaza.Location = new System.Drawing.Point(48, 175);
            this.Actualizeaza.Name = "Actualizeaza";
            this.Actualizeaza.Size = new System.Drawing.Size(152, 50);
            this.Actualizeaza.TabIndex = 6;
            this.Actualizeaza.Text = "Actualizeaza";
            this.Actualizeaza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Actualizeaza.UseVisualStyleBackColor = true;
            this.Actualizeaza.Click += new System.EventHandler(this.Actualizeaza_Click);
            // 
            // Adauga
            // 
            this.Adauga.Image = global::Licenta.Properties.Resources.Insert;
            this.Adauga.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Adauga.Location = new System.Drawing.Point(93, 178);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(152, 50);
            this.Adauga.TabIndex = 7;
            this.Adauga.Text = "Adaugă";
            this.Adauga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Adauga.UseVisualStyleBackColor = true;
            this.Adauga.Click += new System.EventHandler(this.Adauga_Click);
            // 
            // ActualizarePanel
            // 
            this.ActualizarePanel.BackColor = System.Drawing.Color.Transparent;
            this.ActualizarePanel.Controls.Add(this.Actualizeaza);
            this.ActualizarePanel.Controls.Add(this.MarimeLabel);
            this.ActualizarePanel.Controls.Add(this.Marime);
            this.ActualizarePanel.Controls.Add(this.NumarProduseLabel);
            this.ActualizarePanel.Controls.Add(this.Stoc);
            this.ActualizarePanel.Location = new System.Drawing.Point(316, 79);
            this.ActualizarePanel.Name = "ActualizarePanel";
            this.ActualizarePanel.Size = new System.Drawing.Size(225, 228);
            this.ActualizarePanel.TabIndex = 8;
            this.ActualizarePanel.Visible = false;
            // 
            // AdaugaPanel
            // 
            this.AdaugaPanel.BackColor = System.Drawing.Color.Transparent;
            this.AdaugaPanel.Controls.Add(this.StocNou);
            this.AdaugaPanel.Controls.Add(this.label2);
            this.AdaugaPanel.Controls.Add(this.MarimeNoua);
            this.AdaugaPanel.Controls.Add(this.MarimeExistenta);
            this.AdaugaPanel.Controls.Add(this.label1);
            this.AdaugaPanel.Controls.Add(this.MarimeLabel2);
            this.AdaugaPanel.Controls.Add(this.Adauga);
            this.AdaugaPanel.Location = new System.Drawing.Point(271, 79);
            this.AdaugaPanel.Name = "AdaugaPanel";
            this.AdaugaPanel.Size = new System.Drawing.Size(322, 228);
            this.AdaugaPanel.TabIndex = 9;
            this.AdaugaPanel.Visible = false;
            // 
            // StocNou
            // 
            this.StocNou.Location = new System.Drawing.Point(135, 131);
            this.StocNou.Name = "StocNou";
            this.StocNou.Size = new System.Drawing.Size(61, 22);
            this.StocNou.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stoc";
            // 
            // MarimeNoua
            // 
            this.MarimeNoua.Location = new System.Drawing.Point(135, 102);
            this.MarimeNoua.Maximum = new decimal(new int[] {
            47,
            0,
            0,
            0});
            this.MarimeNoua.Minimum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.MarimeNoua.Name = "MarimeNoua";
            this.MarimeNoua.Size = new System.Drawing.Size(61, 22);
            this.MarimeNoua.TabIndex = 10;
            this.MarimeNoua.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // MarimeExistenta
            // 
            this.MarimeExistenta.BackColor = System.Drawing.SystemColors.Menu;
            this.MarimeExistenta.Enabled = false;
            this.MarimeExistenta.Location = new System.Drawing.Point(135, 18);
            this.MarimeExistenta.Multiline = true;
            this.MarimeExistenta.Name = "MarimeExistenta";
            this.MarimeExistenta.ReadOnly = true;
            this.MarimeExistenta.Size = new System.Drawing.Size(175, 78);
            this.MarimeExistenta.TabIndex = 9;
            this.MarimeExistenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mărimi existente";
            // 
            // MarimeLabel2
            // 
            this.MarimeLabel2.AutoSize = true;
            this.MarimeLabel2.Location = new System.Drawing.Point(13, 107);
            this.MarimeLabel2.Name = "MarimeLabel2";
            this.MarimeLabel2.Size = new System.Drawing.Size(90, 17);
            this.MarimeLabel2.TabIndex = 7;
            this.MarimeLabel2.Text = "Mărime nouă";
            // 
            // ActualizareStoc
            // 
            this.ActualizareStoc.Image = global::Licenta.Properties.Resources.Update;
            this.ActualizareStoc.Location = new System.Drawing.Point(54, 126);
            this.ActualizareStoc.Name = "ActualizareStoc";
            this.ActualizareStoc.Size = new System.Drawing.Size(173, 32);
            this.ActualizareStoc.TabIndex = 10;
            this.ActualizareStoc.Text = "Actualizare stoc";
            this.ActualizareStoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ActualizareStoc.UseVisualStyleBackColor = true;
            this.ActualizareStoc.Click += new System.EventHandler(this.ActualizareStoc_Click);
            // 
            // MarimiNoi
            // 
            this.MarimiNoi.Image = global::Licenta.Properties.Resources.Plus;
            this.MarimiNoi.Location = new System.Drawing.Point(54, 234);
            this.MarimiNoi.Name = "MarimiNoi";
            this.MarimiNoi.Size = new System.Drawing.Size(173, 32);
            this.MarimiNoi.TabIndex = 11;
            this.MarimiNoi.Text = "Mărimi noi";
            this.MarimiNoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MarimiNoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MarimiNoi.UseVisualStyleBackColor = true;
            this.MarimiNoi.Click += new System.EventHandler(this.MarimiNoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aprovizionare";
            // 
            // Aprovizionare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(633, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MarimiNoi);
            this.Controls.Add(this.ActualizareStoc);
            this.Controls.Add(this.AdaugaPanel);
            this.Controls.Add(this.ActualizarePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Aprovizionare";
            this.Text = "Aprovizionare";
            ((System.ComponentModel.ISupportInitialize)(this.Stoc)).EndInit();
            this.ActualizarePanel.ResumeLayout(false);
            this.ActualizarePanel.PerformLayout();
            this.AdaugaPanel.ResumeLayout(false);
            this.AdaugaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StocNou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarimeNoua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MarimeLabel;
        private System.Windows.Forms.ComboBox Marime;
        private System.Windows.Forms.Label NumarProduseLabel;
        private System.Windows.Forms.NumericUpDown Stoc;
        private System.Windows.Forms.Button Actualizeaza;
        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.Panel ActualizarePanel;
        private System.Windows.Forms.Panel AdaugaPanel;
        private System.Windows.Forms.Label MarimeLabel2;
        private System.Windows.Forms.Button ActualizareStoc;
        private System.Windows.Forms.Button MarimiNoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MarimeExistenta;
        private System.Windows.Forms.NumericUpDown StocNou;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MarimeNoua;
        private System.Windows.Forms.Label label3;
    }
}