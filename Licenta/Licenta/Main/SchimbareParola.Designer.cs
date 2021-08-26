namespace Licenta
{
    partial class SchimbareParola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchimbareParola));
            this.ParolaCurentaLabel = new System.Windows.Forms.Label();
            this.ParolaNouaLabel = new System.Windows.Forms.Label();
            this.ConfirmaParolaNouaLabel = new System.Windows.Forms.Label();
            this.ParolaCurenta = new System.Windows.Forms.TextBox();
            this.ParolaNoua = new System.Windows.Forms.TextBox();
            this.ConfirmaParolaNoua = new System.Windows.Forms.TextBox();
            this.Modifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParolaCurentaLabel
            // 
            this.ParolaCurentaLabel.AutoSize = true;
            this.ParolaCurentaLabel.BackColor = System.Drawing.Color.Transparent;
            this.ParolaCurentaLabel.Location = new System.Drawing.Point(53, 102);
            this.ParolaCurentaLabel.Name = "ParolaCurentaLabel";
            this.ParolaCurentaLabel.Size = new System.Drawing.Size(101, 17);
            this.ParolaCurentaLabel.TabIndex = 0;
            this.ParolaCurentaLabel.Text = "Parola curentă";
            // 
            // ParolaNouaLabel
            // 
            this.ParolaNouaLabel.AutoSize = true;
            this.ParolaNouaLabel.BackColor = System.Drawing.Color.Transparent;
            this.ParolaNouaLabel.Location = new System.Drawing.Point(53, 139);
            this.ParolaNouaLabel.Name = "ParolaNouaLabel";
            this.ParolaNouaLabel.Size = new System.Drawing.Size(85, 17);
            this.ParolaNouaLabel.TabIndex = 1;
            this.ParolaNouaLabel.Text = "Parola nouă";
            // 
            // ConfirmaParolaNouaLabel
            // 
            this.ConfirmaParolaNouaLabel.AutoSize = true;
            this.ConfirmaParolaNouaLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmaParolaNouaLabel.Location = new System.Drawing.Point(53, 176);
            this.ConfirmaParolaNouaLabel.Name = "ConfirmaParolaNouaLabel";
            this.ConfirmaParolaNouaLabel.Size = new System.Drawing.Size(144, 17);
            this.ConfirmaParolaNouaLabel.TabIndex = 2;
            this.ConfirmaParolaNouaLabel.Text = "Confirmă parola nouă";
            // 
            // ParolaCurenta
            // 
            this.ParolaCurenta.Location = new System.Drawing.Point(203, 99);
            this.ParolaCurenta.Name = "ParolaCurenta";
            this.ParolaCurenta.PasswordChar = '*';
            this.ParolaCurenta.Size = new System.Drawing.Size(139, 22);
            this.ParolaCurenta.TabIndex = 3;
            // 
            // ParolaNoua
            // 
            this.ParolaNoua.Location = new System.Drawing.Point(203, 136);
            this.ParolaNoua.Name = "ParolaNoua";
            this.ParolaNoua.PasswordChar = '*';
            this.ParolaNoua.Size = new System.Drawing.Size(139, 22);
            this.ParolaNoua.TabIndex = 4;
            // 
            // ConfirmaParolaNoua
            // 
            this.ConfirmaParolaNoua.Location = new System.Drawing.Point(203, 173);
            this.ConfirmaParolaNoua.Name = "ConfirmaParolaNoua";
            this.ConfirmaParolaNoua.PasswordChar = '*';
            this.ConfirmaParolaNoua.Size = new System.Drawing.Size(139, 22);
            this.ConfirmaParolaNoua.TabIndex = 5;
            // 
            // Modifica
            // 
            this.Modifica.Image = global::Licenta.Properties.Resources.Save;
            this.Modifica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modifica.Location = new System.Drawing.Point(160, 224);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(109, 48);
            this.Modifica.TabIndex = 6;
            this.Modifica.Text = "Modifică";
            this.Modifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Modifica.UseVisualStyleBackColor = true;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Schimbare parolă";
            // 
            // SchimbareParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG11;
            this.ClientSize = new System.Drawing.Size(409, 294);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Modifica);
            this.Controls.Add(this.ConfirmaParolaNoua);
            this.Controls.Add(this.ParolaNoua);
            this.Controls.Add(this.ParolaCurenta);
            this.Controls.Add(this.ConfirmaParolaNouaLabel);
            this.Controls.Add(this.ParolaNouaLabel);
            this.Controls.Add(this.ParolaCurentaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchimbareParola";
            this.Text = "SchimbareParola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ParolaCurentaLabel;
        private System.Windows.Forms.Label ParolaNouaLabel;
        private System.Windows.Forms.Label ConfirmaParolaNouaLabel;
        private System.Windows.Forms.TextBox ParolaCurenta;
        private System.Windows.Forms.TextBox ParolaNoua;
        private System.Windows.Forms.TextBox ConfirmaParolaNoua;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.Label label1;
    }
}