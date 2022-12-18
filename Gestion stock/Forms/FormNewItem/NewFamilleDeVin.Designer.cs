namespace Gestion_stock.Forms.FormNewItem
{
    partial class NewFamilleDeVin
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
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.lbNom = new System.Windows.Forms.Label();
            this.tlpContainerData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRightData = new System.Windows.Forms.Panel();
            this.pnlLeftData = new System.Windows.Forms.Panel();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.tlpContainerAll = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.flpButtons.SuspendLayout();
            this.tlpContainerData.SuspendLayout();
            this.pnlLeftData.SuspendLayout();
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
            this.lbFormTitle.Text = "Nouvelle famille de vin";
            // 
            // flpButtons
            // 
            this.flpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpButtons.AutoSize = true;
            this.flpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpButtons.Controls.Add(this.btnSave);
            this.flpButtons.Controls.Add(this.btnReload);
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButtons.Location = new System.Drawing.Point(50, 20);
            this.flpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(900, 50);
            this.flpButtons.TabIndex = 6;
            this.flpButtons.WrapContents = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(209)))), ((int)(((byte)(79)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(730, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.SavePage);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Location = new System.Drawing.Point(545, 0);
            this.btnReload.Margin = new System.Windows.Forms.Padding(0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(170, 50);
            this.btnReload.TabIndex = 1;
            this.btnReload.TabStop = false;
            this.btnReload.Text = "Réinitialiser";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.ReloadPage);
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(0, 10);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(46, 19);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nom :";
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
            this.tlpContainerData.Controls.Add(this.pnlRightData, 1, 0);
            this.tlpContainerData.Controls.Add(this.pnlLeftData, 0, 0);
            this.tlpContainerData.Location = new System.Drawing.Point(50, 141);
            this.tlpContainerData.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContainerData.Name = "tlpContainerData";
            this.tlpContainerData.RowCount = 1;
            this.tlpContainerData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerData.Size = new System.Drawing.Size(900, 448);
            this.tlpContainerData.TabIndex = 13;
            // 
            // pnlRightData
            // 
            this.pnlRightData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRightData.Location = new System.Drawing.Point(650, 0);
            this.pnlRightData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRightData.Name = "pnlRightData";
            this.pnlRightData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlRightData.Size = new System.Drawing.Size(250, 448);
            this.pnlRightData.TabIndex = 1;
            // 
            // pnlLeftData
            // 
            this.pnlLeftData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLeftData.AutoScroll = true;
            this.pnlLeftData.AutoSize = true;
            this.pnlLeftData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLeftData.Controls.Add(this.lbNom);
            this.pnlLeftData.Controls.Add(this.txtNom);
            this.pnlLeftData.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeftData.Name = "pnlLeftData";
            this.pnlLeftData.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.pnlLeftData.Size = new System.Drawing.Size(650, 448);
            this.pnlLeftData.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNom.Location = new System.Drawing.Point(124, 7);
            this.txtNom.Margin = new System.Windows.Forms.Padding(0);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(182, 24);
            this.txtNom.TabIndex = 7;
            // 
            // tlpContainerAll
            // 
            this.tlpContainerAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpContainerAll.AutoSize = true;
            this.tlpContainerAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpContainerAll.ColumnCount = 1;
            this.tlpContainerAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerAll.Controls.Add(this.flpButtons, 0, 0);
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
            this.tlpContainerAll.Size = new System.Drawing.Size(1000, 609);
            this.tlpContainerAll.TabIndex = 14;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // NewFamilleDeVin
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
            this.Name = "NewFamilleDeVin";
            this.flpButtons.ResumeLayout(false);
            this.tlpContainerData.ResumeLayout(false);
            this.tlpContainerData.PerformLayout();
            this.pnlLeftData.ResumeLayout(false);
            this.pnlLeftData.PerformLayout();
            this.tlpContainerAll.ResumeLayout(false);
            this.tlpContainerAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbFormTitle;
        private Button btnSave;
        private FlowLayoutPanel flpButtons;
        private Button btnReload;
        private Label lbNom;
        private TableLayoutPanel tlpContainerData;
        private Panel pnlRightData;
        private Panel pnlLeftData;
        private TableLayoutPanel tlpContainerAll;
        private ErrorProvider errorProvider;
        private TextBox txtNom;
    }
}