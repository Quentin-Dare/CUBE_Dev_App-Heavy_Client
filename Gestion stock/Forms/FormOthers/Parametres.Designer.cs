namespace Gestion_stock.Forms.FormOthers
{
    partial class Parametres
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
            this.components = new System.ComponentModel.Container();
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.lbAncienMdp = new System.Windows.Forms.Label();
            this.tlpContainerData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMainData = new System.Windows.Forms.Panel();
            this.btnSaveMdp = new System.Windows.Forms.Button();
            this.txtConfirmMdp = new System.Windows.Forms.TextBox();
            this.lbConfirmMdp = new System.Windows.Forms.Label();
            this.txtNouveauMdp = new System.Windows.Forms.TextBox();
            this.lbNouveauMdp = new System.Windows.Forms.Label();
            this.txtAncienMdp = new System.Windows.Forms.TextBox();
            this.tlpContainerAll = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpContainerData.SuspendLayout();
            this.pnlMainData.SuspendLayout();
            this.tlpContainerAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFormTitle
            // 
            this.lbFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFormTitle.AutoEllipsis = true;
            this.lbFormTitle.AutoSize = true;
            this.lbFormTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            this.lbFormTitle.Location = new System.Drawing.Point(50, 70);
            this.lbFormTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbFormTitle.Name = "lbFormTitle";
            this.lbFormTitle.Size = new System.Drawing.Size(900, 51);
            this.lbFormTitle.TabIndex = 0;
            this.lbFormTitle.Text = "Paramètres";
            // 
            // lbAncienMdp
            // 
            this.lbAncienMdp.AutoSize = true;
            this.lbAncienMdp.Location = new System.Drawing.Point(0, 10);
            this.lbAncienMdp.Name = "lbAncienMdp";
            this.lbAncienMdp.Size = new System.Drawing.Size(143, 19);
            this.lbAncienMdp.TabIndex = 6;
            this.lbAncienMdp.Text = "Ancien mot de passe :";
            // 
            // tlpContainerData
            // 
            this.tlpContainerData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpContainerData.AutoSize = true;
            this.tlpContainerData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpContainerData.ColumnCount = 2;
            this.tlpContainerData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContainerData.Controls.Add(this.pnlMainData, 0, 0);
            this.tlpContainerData.Location = new System.Drawing.Point(50, 141);
            this.tlpContainerData.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContainerData.Name = "tlpContainerData";
            this.tlpContainerData.RowCount = 1;
            this.tlpContainerData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerData.Size = new System.Drawing.Size(900, 235);
            this.tlpContainerData.TabIndex = 13;
            // 
            // pnlMainData
            // 
            this.pnlMainData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainData.AutoScroll = true;
            this.pnlMainData.Controls.Add(this.btnSaveMdp);
            this.pnlMainData.Controls.Add(this.txtConfirmMdp);
            this.pnlMainData.Controls.Add(this.lbConfirmMdp);
            this.pnlMainData.Controls.Add(this.txtNouveauMdp);
            this.pnlMainData.Controls.Add(this.lbNouveauMdp);
            this.pnlMainData.Controls.Add(this.lbAncienMdp);
            this.pnlMainData.Controls.Add(this.txtAncienMdp);
            this.pnlMainData.Location = new System.Drawing.Point(0, 0);
            this.pnlMainData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainData.Name = "pnlMainData";
            this.pnlMainData.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.pnlMainData.Size = new System.Drawing.Size(900, 235);
            this.pnlMainData.TabIndex = 0;
            // 
            // btnSaveMdp
            // 
            this.btnSaveMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveMdp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveMdp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveMdp.ForeColor = System.Drawing.Color.White;
            this.btnSaveMdp.Location = new System.Drawing.Point(185, 140);
            this.btnSaveMdp.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveMdp.Name = "btnSaveMdp";
            this.btnSaveMdp.Size = new System.Drawing.Size(116, 34);
            this.btnSaveMdp.TabIndex = 12;
            this.btnSaveMdp.TabStop = false;
            this.btnSaveMdp.Text = "Enregistrer";
            this.btnSaveMdp.UseVisualStyleBackColor = false;
            this.btnSaveMdp.Click += new System.EventHandler(this.SaveMdp);
            // 
            // txtConfirmMdp
            // 
            this.txtConfirmMdp.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmMdp.Location = new System.Drawing.Point(185, 97);
            this.txtConfirmMdp.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmMdp.Name = "txtConfirmMdp";
            this.txtConfirmMdp.PasswordChar = '●';
            this.txtConfirmMdp.Size = new System.Drawing.Size(182, 24);
            this.txtConfirmMdp.TabIndex = 11;
            // 
            // lbConfirmMdp
            // 
            this.lbConfirmMdp.Location = new System.Drawing.Point(3, 91);
            this.lbConfirmMdp.Name = "lbConfirmMdp";
            this.lbConfirmMdp.Size = new System.Drawing.Size(157, 45);
            this.lbConfirmMdp.TabIndex = 10;
            this.lbConfirmMdp.Text = "Confirmez votre mot de passe :";
            // 
            // txtNouveauMdp
            // 
            this.txtNouveauMdp.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNouveauMdp.Location = new System.Drawing.Point(185, 52);
            this.txtNouveauMdp.Margin = new System.Windows.Forms.Padding(0);
            this.txtNouveauMdp.Name = "txtNouveauMdp";
            this.txtNouveauMdp.PasswordChar = '●';
            this.txtNouveauMdp.Size = new System.Drawing.Size(182, 24);
            this.txtNouveauMdp.TabIndex = 9;
            // 
            // lbNouveauMdp
            // 
            this.lbNouveauMdp.AutoSize = true;
            this.lbNouveauMdp.Location = new System.Drawing.Point(0, 55);
            this.lbNouveauMdp.Name = "lbNouveauMdp";
            this.lbNouveauMdp.Size = new System.Drawing.Size(157, 19);
            this.lbNouveauMdp.TabIndex = 8;
            this.lbNouveauMdp.Text = "Nouveau mot de passe :";
            // 
            // txtAncienMdp
            // 
            this.txtAncienMdp.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAncienMdp.Location = new System.Drawing.Point(185, 7);
            this.txtAncienMdp.Margin = new System.Windows.Forms.Padding(0);
            this.txtAncienMdp.Name = "txtAncienMdp";
            this.txtAncienMdp.PasswordChar = '●';
            this.txtAncienMdp.Size = new System.Drawing.Size(182, 24);
            this.txtAncienMdp.TabIndex = 7;
            // 
            // tlpContainerAll
            // 
            this.tlpContainerAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpContainerAll.AutoSize = true;
            this.tlpContainerAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpContainerAll.ColumnCount = 1;
            this.tlpContainerAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerAll.Controls.Add(this.tlpContainerData, 0, 3);
            this.tlpContainerAll.Controls.Add(this.lbFormTitle, 0, 1);
            this.tlpContainerAll.Location = new System.Drawing.Point(0, 0);
            this.tlpContainerAll.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContainerAll.Name = "tlpContainerAll";
            this.tlpContainerAll.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.tlpContainerAll.RowCount = 4;
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.Size = new System.Drawing.Size(1000, 396);
            this.tlpContainerAll.TabIndex = 14;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1000, 609);
            this.Controls.Add(this.tlpContainerAll);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Parametres";
            this.tlpContainerData.ResumeLayout(false);
            this.pnlMainData.ResumeLayout(false);
            this.pnlMainData.PerformLayout();
            this.tlpContainerAll.ResumeLayout(false);
            this.tlpContainerAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbFormTitle;
        private Label lbAncienMdp;
        private TableLayoutPanel tlpContainerData;
        private Panel pnlMainData;
        private TableLayoutPanel tlpContainerAll;
        private ErrorProvider errorProvider;
        private TextBox txtAncienMdp;
        private Label lbNouveauMdp;
        private TextBox txtNouveauMdp;
        private TextBox txtConfirmMdp;
        private Label lbConfirmMdp;
        private Button btnSaveMdp;
    }
}