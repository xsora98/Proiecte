namespace Licenta
{
    partial class IntroducereDepartament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroducereDepartament));
            this.DenumireLabel = new System.Windows.Forms.Label();
            this.Insert = new System.Windows.Forms.Button();
            this.Denumire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DenumireLabel
            // 
            this.DenumireLabel.AutoSize = true;
            this.DenumireLabel.BackColor = System.Drawing.Color.Transparent;
            this.DenumireLabel.Location = new System.Drawing.Point(109, 117);
            this.DenumireLabel.Name = "DenumireLabel";
            this.DenumireLabel.Size = new System.Drawing.Size(69, 17);
            this.DenumireLabel.TabIndex = 0;
            this.DenumireLabel.Text = "Denumire";
            // 
            // Insert
            // 
            this.Insert.Image = global::Licenta.Properties.Resources.Insert;
            this.Insert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Insert.Location = new System.Drawing.Point(184, 164);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(108, 36);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Adaugă";
            this.Insert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Denumire
            // 
            this.Denumire.Location = new System.Drawing.Point(184, 114);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(136, 22);
            this.Denumire.TabIndex = 2;
            this.Denumire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Denumire_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adăugare departament";
            // 
            // IntroducereDepartament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(452, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.DenumireLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroducereDepartament";
            this.Text = "IntroducereDepartament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DenumireLabel;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox Denumire;
        private System.Windows.Forms.Label label1;
    }
}