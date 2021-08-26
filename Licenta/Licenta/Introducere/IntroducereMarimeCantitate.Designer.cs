namespace Licenta.Introducere
{
    partial class IntroducereMarimeCantitate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroducereMarimeCantitate));
            this.Marime = new System.Windows.Forms.ComboBox();
            this.MarimeLabel = new System.Windows.Forms.Label();
            this.CantitateLabel = new System.Windows.Forms.Label();
            this.Cantitate = new System.Windows.Forms.NumericUpDown();
            this.Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // Marime
            // 
            this.Marime.FormattingEnabled = true;
            this.Marime.Location = new System.Drawing.Point(185, 88);
            this.Marime.Name = "Marime";
            this.Marime.Size = new System.Drawing.Size(85, 24);
            this.Marime.TabIndex = 0;
            // 
            // MarimeLabel
            // 
            this.MarimeLabel.AutoSize = true;
            this.MarimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MarimeLabel.Location = new System.Drawing.Point(43, 91);
            this.MarimeLabel.Name = "MarimeLabel";
            this.MarimeLabel.Size = new System.Drawing.Size(136, 17);
            this.MarimeLabel.TabIndex = 1;
            this.MarimeLabel.Text = "Selectează mărimea";
            // 
            // CantitateLabel
            // 
            this.CantitateLabel.AutoSize = true;
            this.CantitateLabel.BackColor = System.Drawing.Color.Transparent;
            this.CantitateLabel.Location = new System.Drawing.Point(43, 135);
            this.CantitateLabel.Name = "CantitateLabel";
            this.CantitateLabel.Size = new System.Drawing.Size(64, 17);
            this.CantitateLabel.TabIndex = 2;
            this.CantitateLabel.Text = "Cantitate";
            // 
            // Cantitate
            // 
            this.Cantitate.Location = new System.Drawing.Point(185, 133);
            this.Cantitate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.Size = new System.Drawing.Size(85, 22);
            this.Cantitate.TabIndex = 3;
            this.Cantitate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Confirm
            // 
            this.Confirm.Image = global::Licenta.Properties.Resources.Select;
            this.Confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Confirm.Location = new System.Drawing.Point(107, 181);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(120, 41);
            this.Confirm.TabIndex = 4;
            this.Confirm.Text = "Confirmă";
            this.Confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // IntroducereMarimeCantitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(343, 286);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Cantitate);
            this.Controls.Add(this.CantitateLabel);
            this.Controls.Add(this.MarimeLabel);
            this.Controls.Add(this.Marime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroducereMarimeCantitate";
            this.Text = "IntroducereMarimeCantitate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IntroducereMarimeCantitate_FormClosed);
            this.Load += new System.EventHandler(this.IntroducereMarimeCantitate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Marime;
        private System.Windows.Forms.Label MarimeLabel;
        private System.Windows.Forms.Label CantitateLabel;
        private System.Windows.Forms.NumericUpDown Cantitate;
        private System.Windows.Forms.Button Confirm;
    }
}