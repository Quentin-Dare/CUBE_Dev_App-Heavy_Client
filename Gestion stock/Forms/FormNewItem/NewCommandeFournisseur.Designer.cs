namespace Gestion_stock.Forms.FormNewItem
{
    partial class NewCommandeFournisseur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.tlpContainerData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRightData = new System.Windows.Forms.Panel();
            this.txtCoutTransport = new System.Windows.Forms.TextBox();
            this.txtTotalTTC = new System.Windows.Forms.TextBox();
            this.lbCoutTransport = new System.Windows.Forms.Label();
            this.lbPrixTTC = new System.Windows.Forms.Label();
            this.pnlLeftData = new System.Windows.Forms.Panel();
            this.txtFournisseur = new System.Windows.Forms.ComboBox();
            this.lbNomFournisseur = new System.Windows.Forms.Label();
            this.txtIDFournisseur = new System.Windows.Forms.TextBox();
            this.lbIDClient = new System.Windows.Forms.Label();
            this.tlpContainerAll = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            this.dgvPanier = new System.Windows.Forms.DataGridView();
            this.IDArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContainerBtnRows = new System.Windows.Forms.Panel();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.flpButtons.SuspendLayout();
            this.tlpContainerData.SuspendLayout();
            this.pnlRightData.SuspendLayout();
            this.pnlLeftData.SuspendLayout();
            this.tlpContainerAll.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanier)).BeginInit();
            this.pnlContainerBtnRows.SuspendLayout();
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
            this.lbFormTitle.Size = new System.Drawing.Size(810, 51);
            this.lbFormTitle.TabIndex = 0;
            this.lbFormTitle.Text = "Nouvelle commande";
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
            this.flpButtons.Size = new System.Drawing.Size(810, 50);
            this.flpButtons.TabIndex = 6;
            this.flpButtons.WrapContents = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(209)))), ((int)(((byte)(79)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(640, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 50);
            this.btnSave.TabIndex = 3;
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
            this.btnReload.Location = new System.Drawing.Point(455, 0);
            this.btnReload.Margin = new System.Windows.Forms.Padding(0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(170, 50);
            this.btnReload.TabIndex = 4;
            this.btnReload.TabStop = false;
            this.btnReload.Text = "Rafraîchir";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.ReloadPage);
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
            this.tlpContainerData.Size = new System.Drawing.Size(810, 100);
            this.tlpContainerData.TabIndex = 13;
            // 
            // pnlRightData
            // 
            this.pnlRightData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRightData.AutoSize = true;
            this.pnlRightData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRightData.Controls.Add(this.txtCoutTransport);
            this.pnlRightData.Controls.Add(this.txtTotalTTC);
            this.pnlRightData.Controls.Add(this.lbCoutTransport);
            this.pnlRightData.Controls.Add(this.lbPrixTTC);
            this.pnlRightData.Location = new System.Drawing.Point(560, 0);
            this.pnlRightData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRightData.Name = "pnlRightData";
            this.pnlRightData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlRightData.Size = new System.Drawing.Size(250, 100);
            this.pnlRightData.TabIndex = 1;
            // 
            // txtCoutTransport
            // 
            this.txtCoutTransport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCoutTransport.Location = new System.Drawing.Point(154, 7);
            this.txtCoutTransport.Margin = new System.Windows.Forms.Padding(0);
            this.txtCoutTransport.Name = "txtCoutTransport";
            this.txtCoutTransport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCoutTransport.Size = new System.Drawing.Size(96, 24);
            this.txtCoutTransport.TabIndex = 2;
            this.txtCoutTransport.Text = "0";
            this.txtCoutTransport.TextChanged += new System.EventHandler(this.CoutTransportChanged);
            // 
            // txtTotalTTC
            // 
            this.txtTotalTTC.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalTTC.Location = new System.Drawing.Point(154, 52);
            this.txtTotalTTC.Margin = new System.Windows.Forms.Padding(0);
            this.txtTotalTTC.Name = "txtTotalTTC";
            this.txtTotalTTC.ReadOnly = true;
            this.txtTotalTTC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalTTC.Size = new System.Drawing.Size(96, 24);
            this.txtTotalTTC.TabIndex = 4;
            this.txtTotalTTC.TabStop = false;
            this.txtTotalTTC.Text = "0";
            // 
            // lbCoutTransport
            // 
            this.lbCoutTransport.AutoSize = true;
            this.lbCoutTransport.Location = new System.Drawing.Point(13, 10);
            this.lbCoutTransport.Name = "lbCoutTransport";
            this.lbCoutTransport.Size = new System.Drawing.Size(126, 19);
            this.lbCoutTransport.TabIndex = 15;
            this.lbCoutTransport.Text = "Coût de transport :";
            // 
            // lbPrixTTC
            // 
            this.lbPrixTTC.AutoSize = true;
            this.lbPrixTTC.Location = new System.Drawing.Point(14, 55);
            this.lbPrixTTC.Name = "lbPrixTTC";
            this.lbPrixTTC.Size = new System.Drawing.Size(116, 19);
            this.lbPrixTTC.TabIndex = 7;
            this.lbPrixTTC.Text = "Prix total TTC (€) :";
            // 
            // pnlLeftData
            // 
            this.pnlLeftData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLeftData.AutoScroll = true;
            this.pnlLeftData.AutoSize = true;
            this.pnlLeftData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLeftData.Controls.Add(this.txtFournisseur);
            this.pnlLeftData.Controls.Add(this.lbNomFournisseur);
            this.pnlLeftData.Controls.Add(this.txtIDFournisseur);
            this.pnlLeftData.Controls.Add(this.lbIDClient);
            this.pnlLeftData.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeftData.Name = "pnlLeftData";
            this.pnlLeftData.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.pnlLeftData.Size = new System.Drawing.Size(560, 100);
            this.pnlLeftData.TabIndex = 0;
            // 
            // txtFournisseur
            // 
            this.txtFournisseur.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFournisseur.FormattingEnabled = true;
            this.txtFournisseur.Location = new System.Drawing.Point(126, 52);
            this.txtFournisseur.Name = "txtFournisseur";
            this.txtFournisseur.Size = new System.Drawing.Size(282, 25);
            this.txtFournisseur.TabIndex = 1;
            this.txtFournisseur.SelectedIndexChanged += new System.EventHandler(this.FournisseurChanged);
            // 
            // lbNomFournisseur
            // 
            this.lbNomFournisseur.AutoSize = true;
            this.lbNomFournisseur.Location = new System.Drawing.Point(0, 55);
            this.lbNomFournisseur.Name = "lbNomFournisseur";
            this.lbNomFournisseur.Size = new System.Drawing.Size(46, 19);
            this.lbNomFournisseur.TabIndex = 24;
            this.lbNomFournisseur.Text = "Nom :";
            // 
            // txtIDFournisseur
            // 
            this.txtIDFournisseur.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDFournisseur.Location = new System.Drawing.Point(126, 7);
            this.txtIDFournisseur.Margin = new System.Windows.Forms.Padding(0);
            this.txtIDFournisseur.Name = "txtIDFournisseur";
            this.txtIDFournisseur.ReadOnly = true;
            this.txtIDFournisseur.Size = new System.Drawing.Size(140, 24);
            this.txtIDFournisseur.TabIndex = 1;
            this.txtIDFournisseur.TabStop = false;
            // 
            // lbIDClient
            // 
            this.lbIDClient.AutoSize = true;
            this.lbIDClient.Location = new System.Drawing.Point(0, 10);
            this.lbIDClient.Name = "lbIDClient";
            this.lbIDClient.Size = new System.Drawing.Size(105, 19);
            this.lbIDClient.TabIndex = 22;
            this.lbIDClient.Text = "ID Fournisseur :";
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
            this.tlpContainerAll.Controls.Add(this.pnlTableContainer, 0, 7);
            this.tlpContainerAll.Controls.Add(this.flpButtons, 0, 0);
            this.tlpContainerAll.Controls.Add(this.tlpContainerData, 0, 3);
            this.tlpContainerAll.Controls.Add(this.lbFormTitle, 0, 1);
            this.tlpContainerAll.Controls.Add(this.pnlContainerBtnRows, 0, 5);
            this.tlpContainerAll.Location = new System.Drawing.Point(0, 0);
            this.tlpContainerAll.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContainerAll.Name = "tlpContainerAll";
            this.tlpContainerAll.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.tlpContainerAll.RowCount = 8;
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerAll.Size = new System.Drawing.Size(910, 580);
            this.tlpContainerAll.TabIndex = 14;
            // 
            // pnlTableContainer
            // 
            this.pnlTableContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableContainer.AutoScroll = true;
            this.pnlTableContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlTableContainer.Controls.Add(this.dgvPanier);
            this.pnlTableContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlTableContainer.Location = new System.Drawing.Point(50, 309);
            this.pnlTableContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTableContainer.Name = "pnlTableContainer";
            this.pnlTableContainer.Size = new System.Drawing.Size(810, 251);
            this.pnlTableContainer.TabIndex = 16;
            // 
            // dgvPanier
            // 
            this.dgvPanier.AllowUserToAddRows = false;
            this.dgvPanier.AllowUserToDeleteRows = false;
            this.dgvPanier.AllowUserToOrderColumns = true;
            this.dgvPanier.AllowUserToResizeRows = false;
            this.dgvPanier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPanier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvPanier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPanier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPanier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDArticle,
            this.Reference,
            this.Nom,
            this.Annee,
            this.PrixAchat,
            this.Quantite,
            this.PrixTotal});
            this.dgvPanier.EnableHeadersVisualStyles = false;
            this.dgvPanier.Location = new System.Drawing.Point(0, 0);
            this.dgvPanier.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPanier.MinimumSize = new System.Drawing.Size(0, 50);
            this.dgvPanier.Name = "dgvPanier";
            this.dgvPanier.RowHeadersVisible = false;
            this.dgvPanier.RowTemplate.Height = 30;
            this.dgvPanier.Size = new System.Drawing.Size(810, 251);
            this.dgvPanier.TabIndex = 5;
            this.dgvPanier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArticlesCellClicked);
            this.dgvPanier.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArticleValide);
            this.dgvPanier.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.EnterEditingFirstTime);
            // 
            // IDArticle
            // 
            this.IDArticle.HeaderText = "IDArticle";
            this.IDArticle.Name = "IDArticle";
            this.IDArticle.Visible = false;
            // 
            // Reference
            // 
            this.Reference.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Reference.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reference.HeaderText = "Référence";
            this.Reference.Name = "Reference";
            this.Reference.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reference.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Nom
            // 
            this.Nom.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Nom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Nom.Width = 200;
            // 
            // Annee
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Annee.DefaultCellStyle = dataGridViewCellStyle2;
            this.Annee.HeaderText = "Année";
            this.Annee.Name = "Annee";
            this.Annee.ReadOnly = true;
            // 
            // PrixAchat
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrixAchat.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrixAchat.HeaderText = "Prix d\'achat (€)";
            this.PrixAchat.Name = "PrixAchat";
            this.PrixAchat.ReadOnly = true;
            // 
            // Quantite
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Quantite.DefaultCellStyle = dataGridViewCellStyle4;
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            // 
            // PrixTotal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrixTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.PrixTotal.HeaderText = "Prix total (€)";
            this.PrixTotal.Name = "PrixTotal";
            this.PrixTotal.ReadOnly = true;
            // 
            // pnlContainerBtnRows
            // 
            this.pnlContainerBtnRows.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlContainerBtnRows.AutoSize = true;
            this.pnlContainerBtnRows.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContainerBtnRows.Controls.Add(this.btnDeleteLine);
            this.pnlContainerBtnRows.Controls.Add(this.btnAddLine);
            this.pnlContainerBtnRows.Location = new System.Drawing.Point(50, 261);
            this.pnlContainerBtnRows.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContainerBtnRows.Name = "pnlContainerBtnRows";
            this.pnlContainerBtnRows.Size = new System.Drawing.Size(90, 40);
            this.pnlContainerBtnRows.TabIndex = 0;
            this.pnlContainerBtnRows.Visible = false;
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteLine.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteLine.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLine.Location = new System.Drawing.Point(50, 0);
            this.btnDeleteLine.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnDeleteLine.Size = new System.Drawing.Size(40, 40);
            this.btnDeleteLine.TabIndex = 4;
            this.btnDeleteLine.Text = "✖";
            this.btnDeleteLine.UseVisualStyleBackColor = false;
            this.btnDeleteLine.Click += new System.EventHandler(this.RemoveArticleLine);
            // 
            // btnAddLine
            // 
            this.btnAddLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(209)))), ((int)(((byte)(79)))));
            this.btnAddLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLine.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddLine.ForeColor = System.Drawing.Color.White;
            this.btnAddLine.Location = new System.Drawing.Point(0, 0);
            this.btnAddLine.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(40, 40);
            this.btnAddLine.TabIndex = 3;
            this.btnAddLine.Text = "➕";
            this.btnAddLine.UseVisualStyleBackColor = false;
            this.btnAddLine.Click += new System.EventHandler(this.AddArticleLine);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // NewCommandeFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(910, 580);
            this.Controls.Add(this.tlpContainerAll);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewCommandeFournisseur";
            this.flpButtons.ResumeLayout(false);
            this.tlpContainerData.ResumeLayout(false);
            this.tlpContainerData.PerformLayout();
            this.pnlRightData.ResumeLayout(false);
            this.pnlRightData.PerformLayout();
            this.pnlLeftData.ResumeLayout(false);
            this.pnlLeftData.PerformLayout();
            this.tlpContainerAll.ResumeLayout(false);
            this.tlpContainerAll.PerformLayout();
            this.pnlTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanier)).EndInit();
            this.pnlContainerBtnRows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbFormTitle;
        private FlowLayoutPanel flpButtons;
        private TableLayoutPanel tlpContainerData;
        private Panel pnlRightData;
        private Panel pnlLeftData;
        private TableLayoutPanel tlpContainerAll;
        private TextBox txtCoutTransport;
        private TextBox txtTotalTTC;
        private ErrorProvider errorProvider;
        private Panel pnlTableContainer;
        private DataGridView dgvPanier;
        private Label lbIDClient;
        private TextBox txtIDFournisseur;
        private Label lbNomFournisseur;
        private ComboBox txtFournisseur;
        private Button btnSave;
        private Button btnReload;
        private Label lbCoutTransport;
        private Label lbPrixTTC;
        private Panel pnlContainerBtnRows;
        private Button btnAddLine;
        private Button btnDeleteLine;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn IDArticle;
        private DataGridViewComboBoxColumn Reference;
        private DataGridViewComboBoxColumn Nom;
        private DataGridViewTextBoxColumn Annee;
        private DataGridViewTextBoxColumn PrixAchat;
        private DataGridViewTextBoxColumn Quantite;
        private DataGridViewTextBoxColumn PrixTotal;
    }
}