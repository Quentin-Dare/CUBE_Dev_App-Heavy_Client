namespace Gestion_stock.Forms.FormIndividual
{
    partial class CommandeFournisseurIndiv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpContainerData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRightData = new System.Windows.Forms.Panel();
            this.txtCoutTransport = new System.Windows.Forms.TextBox();
            this.txtTotalTTC = new System.Windows.Forms.TextBox();
            this.lbCoutTransport = new System.Windows.Forms.Label();
            this.lbPrixTTC = new System.Windows.Forms.Label();
            this.pnlLeftData = new System.Windows.Forms.Panel();
            this.txtNomFournisseur = new System.Windows.Forms.TextBox();
            this.lbNomFournisseur = new System.Windows.Forms.Label();
            this.txtIDFournisseur = new System.Windows.Forms.TextBox();
            this.lbIDClient = new System.Windows.Forms.Label();
            this.txtStatut = new System.Windows.Forms.TextBox();
            this.lbDateCommande = new System.Windows.Forms.Label();
            this.txtDateCommande = new System.Windows.Forms.TextBox();
            this.lbStatut = new System.Windows.Forms.Label();
            this.lkFournisseur = new System.Windows.Forms.LinkLabel();
            this.txtIDCommande = new System.Windows.Forms.TextBox();
            this.lbIDCommande = new System.Windows.Forms.Label();
            this.tlpContainerAll = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            this.dgvPanier = new System.Windows.Forms.DataGridView();
            this.tlpFilterContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbContient = new System.Windows.Forms.Label();
            this.cbFieldFilter = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbTypeCommande = new System.Windows.Forms.Label();
            this.txtTypeCommande = new System.Windows.Forms.TextBox();
            this.IDArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Année = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixAchat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpButtons.SuspendLayout();
            this.tlpContainerData.SuspendLayout();
            this.pnlRightData.SuspendLayout();
            this.pnlLeftData.SuspendLayout();
            this.tlpContainerAll.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanier)).BeginInit();
            this.tlpFilterContainer.SuspendLayout();
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
            this.lbFormTitle.Size = new System.Drawing.Size(1168, 51);
            this.lbFormTitle.TabIndex = 0;
            this.lbFormTitle.Text = "Commande";
            // 
            // flpButtons
            // 
            this.flpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpButtons.AutoSize = true;
            this.flpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpButtons.Controls.Add(this.btnClose);
            this.flpButtons.Controls.Add(this.btnCancel);
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButtons.Location = new System.Drawing.Point(50, 20);
            this.flpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(1168, 50);
            this.flpButtons.TabIndex = 6;
            this.flpButtons.WrapContents = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(998, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Clore la commande";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.ClosePage);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(813, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 50);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Annuler la commande";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.ReloadPage);
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
            this.tlpContainerData.Size = new System.Drawing.Size(1168, 231);
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
            this.pnlRightData.Location = new System.Drawing.Point(918, 0);
            this.pnlRightData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRightData.Name = "pnlRightData";
            this.pnlRightData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlRightData.Size = new System.Drawing.Size(250, 231);
            this.pnlRightData.TabIndex = 1;
            // 
            // txtCoutTransport
            // 
            this.txtCoutTransport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCoutTransport.Location = new System.Drawing.Point(154, 7);
            this.txtCoutTransport.Margin = new System.Windows.Forms.Padding(0);
            this.txtCoutTransport.Name = "txtCoutTransport";
            this.txtCoutTransport.ReadOnly = true;
            this.txtCoutTransport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCoutTransport.Size = new System.Drawing.Size(96, 24);
            this.txtCoutTransport.TabIndex = 1;
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
            this.lbPrixTTC.Location = new System.Drawing.Point(14, 54);
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
            this.pnlLeftData.Controls.Add(this.txtTypeCommande);
            this.pnlLeftData.Controls.Add(this.lbTypeCommande);
            this.pnlLeftData.Controls.Add(this.txtNomFournisseur);
            this.pnlLeftData.Controls.Add(this.lbNomFournisseur);
            this.pnlLeftData.Controls.Add(this.txtIDFournisseur);
            this.pnlLeftData.Controls.Add(this.lbIDClient);
            this.pnlLeftData.Controls.Add(this.txtStatut);
            this.pnlLeftData.Controls.Add(this.lbDateCommande);
            this.pnlLeftData.Controls.Add(this.txtDateCommande);
            this.pnlLeftData.Controls.Add(this.lbStatut);
            this.pnlLeftData.Controls.Add(this.lkFournisseur);
            this.pnlLeftData.Controls.Add(this.txtIDCommande);
            this.pnlLeftData.Controls.Add(this.lbIDCommande);
            this.pnlLeftData.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeftData.Name = "pnlLeftData";
            this.pnlLeftData.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.pnlLeftData.Size = new System.Drawing.Size(918, 231);
            this.pnlLeftData.TabIndex = 0;
            // 
            // txtNomFournisseur
            // 
            this.txtNomFournisseur.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomFournisseur.Location = new System.Drawing.Point(562, 52);
            this.txtNomFournisseur.Margin = new System.Windows.Forms.Padding(0);
            this.txtNomFournisseur.Name = "txtNomFournisseur";
            this.txtNomFournisseur.ReadOnly = true;
            this.txtNomFournisseur.Size = new System.Drawing.Size(282, 24);
            this.txtNomFournisseur.TabIndex = 25;
            // 
            // lbNomFournisseur
            // 
            this.lbNomFournisseur.AutoSize = true;
            this.lbNomFournisseur.Location = new System.Drawing.Point(436, 55);
            this.lbNomFournisseur.Name = "lbNomFournisseur";
            this.lbNomFournisseur.Size = new System.Drawing.Size(46, 19);
            this.lbNomFournisseur.TabIndex = 24;
            this.lbNomFournisseur.Text = "Nom :";
            // 
            // txtIDFournisseur
            // 
            this.txtIDFournisseur.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDFournisseur.Location = new System.Drawing.Point(562, 7);
            this.txtIDFournisseur.Margin = new System.Windows.Forms.Padding(0);
            this.txtIDFournisseur.Name = "txtIDFournisseur";
            this.txtIDFournisseur.ReadOnly = true;
            this.txtIDFournisseur.Size = new System.Drawing.Size(140, 24);
            this.txtIDFournisseur.TabIndex = 15;
            // 
            // lbIDClient
            // 
            this.lbIDClient.AutoSize = true;
            this.lbIDClient.Location = new System.Drawing.Point(436, 10);
            this.lbIDClient.Name = "lbIDClient";
            this.lbIDClient.Size = new System.Drawing.Size(105, 19);
            this.lbIDClient.TabIndex = 22;
            this.lbIDClient.Text = "ID Fournisseur :";
            // 
            // txtStatut
            // 
            this.txtStatut.BackColor = System.Drawing.Color.Gold;
            this.txtStatut.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatut.Location = new System.Drawing.Point(126, 187);
            this.txtStatut.Margin = new System.Windows.Forms.Padding(0);
            this.txtStatut.Name = "txtStatut";
            this.txtStatut.Size = new System.Drawing.Size(140, 24);
            this.txtStatut.TabIndex = 10;
            // 
            // lbDateCommande
            // 
            this.lbDateCommande.Location = new System.Drawing.Point(0, 55);
            this.lbDateCommande.Name = "lbDateCommande";
            this.lbDateCommande.Size = new System.Drawing.Size(99, 44);
            this.lbDateCommande.TabIndex = 20;
            this.lbDateCommande.Text = "Date de la commande :";
            // 
            // txtDateCommande
            // 
            this.txtDateCommande.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateCommande.Location = new System.Drawing.Point(126, 52);
            this.txtDateCommande.Margin = new System.Windows.Forms.Padding(0);
            this.txtDateCommande.Name = "txtDateCommande";
            this.txtDateCommande.ReadOnly = true;
            this.txtDateCommande.Size = new System.Drawing.Size(140, 24);
            this.txtDateCommande.TabIndex = 7;
            this.txtDateCommande.Text = "12/03/2022 13:45";
            // 
            // lbStatut
            // 
            this.lbStatut.AutoSize = true;
            this.lbStatut.Location = new System.Drawing.Point(0, 190);
            this.lbStatut.Name = "lbStatut";
            this.lbStatut.Size = new System.Drawing.Size(53, 19);
            this.lbStatut.TabIndex = 18;
            this.lbStatut.Text = "Statut :";
            // 
            // lkFournisseur
            // 
            this.lkFournisseur.AutoSize = true;
            this.lkFournisseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkFournisseur.LinkColor = System.Drawing.Color.Gray;
            this.lkFournisseur.Location = new System.Drawing.Point(710, 10);
            this.lkFournisseur.Name = "lkFournisseur";
            this.lkFournisseur.Size = new System.Drawing.Size(157, 19);
            this.lkFournisseur.TabIndex = 17;
            this.lkFournisseur.TabStop = true;
            this.lkFournisseur.Text = "Accéder au fournisseur...";
            this.lkFournisseur.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lkFournisseur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FournisseurLinkClicked);
            // 
            // txtIDCommande
            // 
            this.txtIDCommande.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDCommande.Location = new System.Drawing.Point(126, 7);
            this.txtIDCommande.Margin = new System.Windows.Forms.Padding(0);
            this.txtIDCommande.Name = "txtIDCommande";
            this.txtIDCommande.ReadOnly = true;
            this.txtIDCommande.Size = new System.Drawing.Size(140, 24);
            this.txtIDCommande.TabIndex = 5;
            // 
            // lbIDCommande
            // 
            this.lbIDCommande.AutoSize = true;
            this.lbIDCommande.Location = new System.Drawing.Point(0, 10);
            this.lbIDCommande.Name = "lbIDCommande";
            this.lbIDCommande.Size = new System.Drawing.Size(30, 19);
            this.lbIDCommande.TabIndex = 16;
            this.lbIDCommande.Text = "ID :";
            // 
            // tlpContainerAll
            // 
            this.tlpContainerAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpContainerAll.AutoSize = true;
            this.tlpContainerAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpContainerAll.ColumnCount = 1;
            this.tlpContainerAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerAll.Controls.Add(this.pnlTableContainer, 0, 7);
            this.tlpContainerAll.Controls.Add(this.flpButtons, 0, 0);
            this.tlpContainerAll.Controls.Add(this.tlpContainerData, 0, 3);
            this.tlpContainerAll.Controls.Add(this.lbFormTitle, 0, 1);
            this.tlpContainerAll.Controls.Add(this.tlpFilterContainer, 0, 6);
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
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.Size = new System.Drawing.Size(1268, 520);
            this.tlpContainerAll.TabIndex = 14;
            // 
            // pnlTableContainer
            // 
            this.pnlTableContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableContainer.AutoSize = true;
            this.pnlTableContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTableContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlTableContainer.Controls.Add(this.dgvPanier);
            this.pnlTableContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlTableContainer.Location = new System.Drawing.Point(50, 450);
            this.pnlTableContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTableContainer.MinimumSize = new System.Drawing.Size(50, 0);
            this.pnlTableContainer.Name = "pnlTableContainer";
            this.pnlTableContainer.Size = new System.Drawing.Size(1168, 50);
            this.pnlTableContainer.TabIndex = 16;
            // 
            // dgvPanier
            // 
            this.dgvPanier.AllowUserToAddRows = false;
            this.dgvPanier.AllowUserToDeleteRows = false;
            this.dgvPanier.AllowUserToOrderColumns = true;
            this.dgvPanier.AllowUserToResizeRows = false;
            this.dgvPanier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvPanier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPanier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPanier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDArticle,
            this.Reference,
            this.Nom,
            this.Année,
            this.PrixAchat,
            this.TVA,
            this.Quantite,
            this.TotalTTC});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPanier.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPanier.EnableHeadersVisualStyles = false;
            this.dgvPanier.Location = new System.Drawing.Point(0, 0);
            this.dgvPanier.Margin = new System.Windows.Forms.Padding(0);
            this.dgvPanier.MinimumSize = new System.Drawing.Size(1168, 50);
            this.dgvPanier.Name = "dgvPanier";
            this.dgvPanier.ReadOnly = true;
            this.dgvPanier.RowHeadersVisible = false;
            this.dgvPanier.RowTemplate.Height = 30;
            this.dgvPanier.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvPanier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPanier.Size = new System.Drawing.Size(1168, 50);
            this.dgvPanier.TabIndex = 0;
            this.dgvPanier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArticleCellClicked);
            // 
            // tlpFilterContainer
            // 
            this.tlpFilterContainer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tlpFilterContainer.AutoSize = true;
            this.tlpFilterContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpFilterContainer.ColumnCount = 3;
            this.tlpFilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpFilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFilterContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpFilterContainer.Controls.Add(this.tbFilter, 2, 0);
            this.tlpFilterContainer.Controls.Add(this.lbContient, 1, 0);
            this.tlpFilterContainer.Controls.Add(this.cbFieldFilter, 0, 0);
            this.tlpFilterContainer.Location = new System.Drawing.Point(770, 412);
            this.tlpFilterContainer.Margin = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.tlpFilterContainer.Name = "tlpFilterContainer";
            this.tlpFilterContainer.RowCount = 1;
            this.tlpFilterContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilterContainer.Size = new System.Drawing.Size(448, 28);
            this.tlpFilterContainer.TabIndex = 15;
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFilter.Location = new System.Drawing.Point(248, 0);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(200, 27);
            this.tbFilter.TabIndex = 2;
            this.tbFilter.TextChanged += new System.EventHandler(this.FilterData);
            // 
            // lbContient
            // 
            this.lbContient.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbContient.AutoSize = true;
            this.lbContient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbContient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbContient.Location = new System.Drawing.Point(173, 4);
            this.lbContient.Name = "lbContient";
            this.lbContient.Size = new System.Drawing.Size(72, 20);
            this.lbContient.TabIndex = 1;
            this.lbContient.Text = "Contient :";
            // 
            // cbFieldFilter
            // 
            this.cbFieldFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFieldFilter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFieldFilter.FormattingEnabled = true;
            this.cbFieldFilter.Items.AddRange(new object[] {
            "ID",
            "Nom",
            "Domaine",
            "Famille de vin",
            "Cassoulet"});
            this.cbFieldFilter.Location = new System.Drawing.Point(0, 0);
            this.cbFieldFilter.Margin = new System.Windows.Forms.Padding(0);
            this.cbFieldFilter.Name = "cbFieldFilter";
            this.cbFieldFilter.Size = new System.Drawing.Size(170, 28);
            this.cbFieldFilter.TabIndex = 1;
            this.cbFieldFilter.SelectedIndexChanged += new System.EventHandler(this.FilterData);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // lbTypeCommande
            // 
            this.lbTypeCommande.Location = new System.Drawing.Point(0, 100);
            this.lbTypeCommande.Name = "lbTypeCommande";
            this.lbTypeCommande.Size = new System.Drawing.Size(110, 44);
            this.lbTypeCommande.TabIndex = 26;
            this.lbTypeCommande.Text = "Type de commande :";
            // 
            // txtTypeCommande
            // 
            this.txtTypeCommande.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTypeCommande.Location = new System.Drawing.Point(126, 97);
            this.txtTypeCommande.Margin = new System.Windows.Forms.Padding(0);
            this.txtTypeCommande.Name = "txtTypeCommande";
            this.txtTypeCommande.ReadOnly = true;
            this.txtTypeCommande.Size = new System.Drawing.Size(140, 24);
            this.txtTypeCommande.TabIndex = 27;
            // 
            // IDArticle
            // 
            this.IDArticle.HeaderText = "IDArticle";
            this.IDArticle.Name = "IDArticle";
            this.IDArticle.ReadOnly = true;
            this.IDArticle.Visible = false;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Référence";
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 200;
            // 
            // Année
            // 
            this.Année.HeaderText = "Annee";
            this.Année.Name = "Année";
            this.Année.ReadOnly = true;
            // 
            // PrixAchat
            // 
            this.PrixAchat.HeaderText = "Prix d\'achat (€)";
            this.PrixAchat.Name = "PrixAchat";
            this.PrixAchat.ReadOnly = true;
            // 
            // TVA
            // 
            this.TVA.HeaderText = "TVA (%)";
            this.TVA.Name = "TVA";
            this.TVA.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // TotalTTC
            // 
            this.TotalTTC.HeaderText = "Total TTC (€)";
            this.TotalTTC.Name = "TotalTTC";
            this.TotalTTC.ReadOnly = true;
            // 
            // CommandeFournisseurIndiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1268, 718);
            this.Controls.Add(this.tlpContainerAll);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CommandeFournisseurIndiv";
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
            this.tlpFilterContainer.ResumeLayout(false);
            this.tlpFilterContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbFormTitle;
        private Button btnClose;
        private FlowLayoutPanel flpButtons;
        private Button btnCancel;
        private TableLayoutPanel tlpContainerData;
        private Panel pnlRightData;
        private Panel pnlLeftData;
        private TableLayoutPanel tlpContainerAll;
        private Label lbPrixTTC;
        private Label lbCoutTransport;
        private TextBox txtCoutTransport;
        private TextBox txtTotalTTC;
        private TextBox txtIDCommande;
        private Label lbIDCommande;
        private ErrorProvider errorProvider;
        private LinkLabel lkFournisseur;
        private TableLayoutPanel tlpFilterContainer;
        private TextBox tbFilter;
        private Label lbContient;
        private ComboBox cbFieldFilter;
        private Panel pnlTableContainer;
        private DataGridView dgvPanier;
        private Label lbStatut;
        private TextBox txtDateCommande;
        private TextBox txtStatut;
        private Label lbDateCommande;
        private Label lbIDClient;
        private TextBox txtIDFournisseur;
        private Label lbNomFournisseur;
        private TextBox txtNomFournisseur;
        private TextBox txtTypeCommande;
        private Label lbTypeCommande;
        private DataGridViewTextBoxColumn IDArticle;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Année;
        private DataGridViewTextBoxColumn PrixAchat;
        private DataGridViewTextBoxColumn TVA;
        private DataGridViewTextBoxColumn Quantite;
        private DataGridViewTextBoxColumn TotalTTC;
    }
}