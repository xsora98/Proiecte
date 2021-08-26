namespace Licenta
{
    partial class SchimbareParolaCod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchimbareParolaCod));
            this.ParolaNouaLabel = new System.Windows.Forms.Label();
            this.ConfirmareParolaNouaLabel = new System.Windows.Forms.Label();
            this.Modifică = new System.Windows.Forms.Button();
            this.ParolaNoua = new System.Windows.Forms.TextBox();
            this.ConfirmareParolaNoua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParolaNouaLabel
            // 
            this.ParolaNouaLabel.AutoSize = true;
            this.ParolaNouaLabel.Location = new System.Drawing.Point(52, 110);
            this.ParolaNouaLabel.Name = "ParolaNouaLabel";
            this.ParolaNouaLabel.Size = new System.Drawing.Size(85, 17);
            this.ParolaNouaLabel.TabIndex = 0;
            this.ParolaNouaLabel.Text = "Parolă nouă";
            // 
            // ConfirmareParolaNouaLabel
            // 
            this.ConfirmareParolaNouaLabel.AutoSize = true;
            this.ConfirmareParolaNouaLabel.Location = new System.Drawing.Point(52, 172);
            this.ConfirmareParolaNouaLabel.Name = "ConfirmareParolaNouaLabel";
            this.ConfirmareParolaNouaLabel.Size = new System.Drawing.Size(157, 17);
            this.ConfirmareParolaNouaLabel.TabIndex = 1;
            this.ConfirmareParolaNouaLabel.Text = "Confirmare parolă nouă";
            // 
            // Modifică
            // 
            this.Modifică.Image = global::Licenta.Properties.Resources.Save;
            this.Modifică.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modifică.Location = new System.Drawing.Point(172, 210);
            this.Modifică.Name = "Modifică";
            this.Modifică.Size = new System.Drawing.Size(111, 46);
            this.Modifică.TabIndex = 2;
            this.Modifică.Text = "Modifică";
            this.Modifică.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Modifică.UseVisualStyleBackColor = true;
            this.Modifică.Click += new System.EventHandler(this.Modifică_Click);
            // 
            // ParolaNoua
            // 
            this.ParolaNoua.Location = new System.Drawing.Point(231, 105);
            this.ParolaNoua.Name = "ParolaNoua";
            this.ParolaNoua.PasswordChar = '*';
            this.ParolaNoua.Size = new System.Drawing.Size(121, 22);
            this.ParolaNoua.TabIndex = 3;
            // 
            // ConfirmareParolaNoua
            // 
            this.ConfirmareParolaNoua.Location = new System.Drawing.Point(231, 169);
            this.ConfirmareParolaNoua.Name = "ConfirmareParolaNoua";
            this.ConfirmareParolaNoua.PasswordChar = '*';
            this.ConfirmareParolaNoua.Size = new System.Drawing.Size(121, 22);
            this.ConfirmareParolaNoua.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Recuperare parolă";
            // 
            // SchimbareParolaCod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(441, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmareParolaNoua);
            this.Controls.Add(this.ParolaNoua);
            this.Controls.Add(this.Modifică);
            this.Controls.Add(this.ConfirmareParolaNouaLabel);
            this.Controls.Add(this.ParolaNouaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchimbareParolaCod";
            this.Text = "SchimbareParolaCod";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SchimbareParolaCod_FormClosed);
            this.Load += new System.EventHandler(this.SchimbareParolaCod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ParolaNouaLabel;
        private System.Windows.Forms.Label ConfirmareParolaNouaLabel;
        private System.Windows.Forms.Button Modifică;
        private System.Windows.Forms.TextBox ParolaNoua;
        private System.Windows.Forms.TextBox ConfirmareParolaNoua;
        private System.Windows.Forms.Label label1;
    }
}