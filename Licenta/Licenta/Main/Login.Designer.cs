namespace Licenta
{
    partial class LoginPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.Utilizator = new System.Windows.Forms.TextBox();
            this.Parola = new System.Windows.Forms.TextBox();
            this.UtilizatorLabel = new System.Windows.Forms.Label();
            this.ParolaLabel = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Forgot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Utilizator
            // 
            this.Utilizator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Utilizator.Location = new System.Drawing.Point(404, 197);
            this.Utilizator.Name = "Utilizator";
            this.Utilizator.Size = new System.Drawing.Size(176, 22);
            this.Utilizator.TabIndex = 0;
            // 
            // Parola
            // 
            this.Parola.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Parola.Location = new System.Drawing.Point(404, 248);
            this.Parola.Name = "Parola";
            this.Parola.PasswordChar = '*';
            this.Parola.Size = new System.Drawing.Size(176, 22);
            this.Parola.TabIndex = 1;
            // 
            // UtilizatorLabel
            // 
            this.UtilizatorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UtilizatorLabel.AutoSize = true;
            this.UtilizatorLabel.BackColor = System.Drawing.Color.Transparent;
            this.UtilizatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UtilizatorLabel.ForeColor = System.Drawing.Color.White;
            this.UtilizatorLabel.Location = new System.Drawing.Point(322, 197);
            this.UtilizatorLabel.Name = "UtilizatorLabel";
            this.UtilizatorLabel.Size = new System.Drawing.Size(76, 20);
            this.UtilizatorLabel.TabIndex = 2;
            this.UtilizatorLabel.Text = "Utilizator";
            this.UtilizatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ParolaLabel
            // 
            this.ParolaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParolaLabel.AutoSize = true;
            this.ParolaLabel.BackColor = System.Drawing.Color.Transparent;
            this.ParolaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParolaLabel.ForeColor = System.Drawing.Color.White;
            this.ParolaLabel.Location = new System.Drawing.Point(322, 250);
            this.ParolaLabel.Name = "ParolaLabel";
            this.ParolaLabel.Size = new System.Drawing.Size(57, 20);
            this.ParolaLabel.TabIndex = 3;
            this.ParolaLabel.Text = "Parolă";
            this.ParolaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Login.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Image = global::Licenta.Properties.Resources.Login;
            this.Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.Location = new System.Drawing.Point(296, 296);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(284, 35);
            this.Login.TabIndex = 4;
            this.Login.Text = "Autentificare";
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Panou de control";
            // 
            // Forgot
            // 
            this.Forgot.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Forgot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forgot.ForeColor = System.Drawing.Color.White;
            this.Forgot.Image = global::Licenta.Properties.Resources.Forgot;
            this.Forgot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Forgot.Location = new System.Drawing.Point(296, 345);
            this.Forgot.Name = "Forgot";
            this.Forgot.Size = new System.Drawing.Size(284, 35);
            this.Forgot.TabIndex = 6;
            this.Forgot.Text = "Ți-ai uitat parola?";
            this.Forgot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Forgot.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Forgot.UseVisualStyleBackColor = false;
            this.Forgot.Click += new System.EventHandler(this.Forgot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Licenta.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(296, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 22);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Licenta.Properties.Resources.Pass;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(296, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 22);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Licenta.Properties.Resources.BG2;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Forgot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.ParolaLabel);
            this.Controls.Add(this.UtilizatorLabel);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.Utilizator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panou de Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginPanel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Utilizator;
        private System.Windows.Forms.TextBox Parola;
        private System.Windows.Forms.Label UtilizatorLabel;
        private System.Windows.Forms.Label ParolaLabel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Forgot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

