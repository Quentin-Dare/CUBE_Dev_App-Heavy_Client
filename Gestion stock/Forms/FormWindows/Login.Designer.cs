namespace Gestion_stock.MainForm
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.pnlPhoto = new System.Windows.Forms.Panel();
            this.lbNegosud = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbErreurLogin = new System.Windows.Forms.Label();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.lblCloseIcon = new System.Windows.Forms.Label();
            this.pnlMinimize = new System.Windows.Forms.Panel();
            this.pnlMinimizeIcon = new System.Windows.Forms.Panel();
            this.pnlBottom.SuspendLayout();
            this.pnlClose.SuspendLayout();
            this.pnlMinimize.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnLogin);
            this.pnlBottom.Controls.Add(this.lbCopyright);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 289);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(534, 67);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(405, 15);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(281, 15);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Connexion";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.TryLogin);
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCopyright.ForeColor = System.Drawing.Color.White;
            this.lbCopyright.Location = new System.Drawing.Point(3, 20);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(178, 23);
            this.lbCopyright.TabIndex = 2;
            this.lbCopyright.Text = "© Tous droits réservés";
            // 
            // pnlPhoto
            // 
            this.pnlPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            this.pnlPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPhoto.BackgroundImage")));
            this.pnlPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPhoto.Location = new System.Drawing.Point(0, 0);
            this.pnlPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPhoto.Name = "pnlPhoto";
            this.pnlPhoto.Size = new System.Drawing.Size(103, 289);
            this.pnlPhoto.TabIndex = 2;
            // 
            // lbNegosud
            // 
            this.lbNegosud.AutoSize = true;
            this.lbNegosud.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNegosud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            this.lbNegosud.Location = new System.Drawing.Point(114, 40);
            this.lbNegosud.Margin = new System.Windows.Forms.Padding(0);
            this.lbNegosud.Name = "lbNegosud";
            this.lbNegosud.Size = new System.Drawing.Size(232, 51);
            this.lbNegosud.TabIndex = 3;
            this.lbNegosud.Text = "NEGOSUD";
            // 
            // tbUsername
            // 
            this.tbUsername.AcceptsReturn = true;
            this.tbUsername.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(281, 127);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(237, 30);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckEnterKeyPress);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(281, 200);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(237, 30);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckEnterKeyPress);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.Location = new System.Drawing.Point(114, 132);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.lbUsername.Size = new System.Drawing.Size(158, 23);
            this.lbUsername.TabIndex = 6;
            this.lbUsername.Text = "Nom d\'utilisateur :";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(114, 205);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.lbPassword.Size = new System.Drawing.Size(128, 23);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Mot de passe :";
            // 
            // lbErreurLogin
            // 
            this.lbErreurLogin.AutoSize = true;
            this.lbErreurLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbErreurLogin.ForeColor = System.Drawing.Color.Red;
            this.lbErreurLogin.Location = new System.Drawing.Point(114, 249);
            this.lbErreurLogin.Margin = new System.Windows.Forms.Padding(0);
            this.lbErreurLogin.Name = "lbErreurLogin";
            this.lbErreurLogin.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.lbErreurLogin.Size = new System.Drawing.Size(324, 21);
            this.lbErreurLogin.TabIndex = 8;
            this.lbErreurLogin.Text = "Nom d\'utilisateur ou mot de passe incorrect.";
            this.lbErreurLogin.Visible = false;
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.Red;
            this.pnlClose.Controls.Add(this.lblCloseIcon);
            this.pnlClose.Location = new System.Drawing.Point(477, 0);
            this.pnlClose.Margin = new System.Windows.Forms.Padding(0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(57, 40);
            this.pnlClose.TabIndex = 9;
            // 
            // lblCloseIcon
            // 
            this.lblCloseIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCloseIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCloseIcon.ForeColor = System.Drawing.Color.White;
            this.lblCloseIcon.Location = new System.Drawing.Point(0, 0);
            this.lblCloseIcon.Name = "lblCloseIcon";
            this.lblCloseIcon.Size = new System.Drawing.Size(57, 40);
            this.lblCloseIcon.TabIndex = 0;
            this.lblCloseIcon.Text = "✖";
            this.lblCloseIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCloseIcon.Click += new System.EventHandler(this.Cancel_Click);
            this.lblCloseIcon.MouseEnter += new System.EventHandler(this.lblCloseIcon_MouseEnter);
            this.lblCloseIcon.MouseLeave += new System.EventHandler(this.lblCloseIcon_MouseLeave);
            // 
            // pnlMinimize
            // 
            this.pnlMinimize.Controls.Add(this.pnlMinimizeIcon);
            this.pnlMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMinimize.Location = new System.Drawing.Point(419, 0);
            this.pnlMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMinimize.Name = "pnlMinimize";
            this.pnlMinimize.Size = new System.Drawing.Size(57, 40);
            this.pnlMinimize.TabIndex = 10;
            this.pnlMinimize.Click += new System.EventHandler(this.pnlMinimize_Click);
            this.pnlMinimize.MouseEnter += new System.EventHandler(this.pnlMinimize_MouseEnter);
            this.pnlMinimize.MouseLeave += new System.EventHandler(this.pnlMinimize_MouseLeave);
            // 
            // pnlMinimizeIcon
            // 
            this.pnlMinimizeIcon.BackColor = System.Drawing.Color.Gray;
            this.pnlMinimizeIcon.Location = new System.Drawing.Point(19, 27);
            this.pnlMinimizeIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 8);
            this.pnlMinimizeIcon.Name = "pnlMinimizeIcon";
            this.pnlMinimizeIcon.Size = new System.Drawing.Size(18, 4);
            this.pnlMinimizeIcon.TabIndex = 0;
            this.pnlMinimizeIcon.Click += new System.EventHandler(this.pnlMinimize_Click);
            this.pnlMinimizeIcon.MouseEnter += new System.EventHandler(this.pnlMinimize_MouseEnter);
            this.pnlMinimizeIcon.MouseLeave += new System.EventHandler(this.pnlMinimize_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(534, 356);
            this.Controls.Add(this.pnlMinimize);
            this.Controls.Add(this.pnlClose);
            this.Controls.Add(this.lbErreurLogin);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbNegosud);
            this.Controls.Add(this.pnlPhoto);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlClose.ResumeLayout(false);
            this.pnlMinimize.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel pnlBottom;
        private Label lbCopyright;
        private Panel pnlPhoto;
        private Label lbNegosud;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lbUsername;
        private Label lbPassword;
        private Label lbErreurLogin;
        private Button btnCancel;
        private Button btnLogin;
        private Panel pnlClose;
        private Panel pnlMinimize;
        private Panel pnlMinimizeIcon;
        private Label lblCloseIcon;
    }
}