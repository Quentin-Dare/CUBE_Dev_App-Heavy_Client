namespace Gestion_stock.Forms.FormIndividual
{
    partial class CommandeClientIndiv
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
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpContainerData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRightData = new System.Windows.Forms.Panel();
            this.txtTotalHT = new System.Windows.Forms.TextBox();
            this.txtTotalTTC = new System.Windows.Forms.TextBox();
            this.lbPrixAchat = new System.Windows.Forms.Label();
            this.lbPrixTTC = new System.Windows.Forms.Label();
            this.pnlLeftData = new System.Windows.Forms.Panel();
            this.txtPrenomClient = new System.Windows.Forms.TextBox();
            this.lbPrenomClient = new System.Windows.Forms.Label();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.lbNomClient = new System.Windows.Forms.Label();
            this.txtIDClient = new System.Windows.Forms.TextBox();
            this.lbIDClient = new System.Windows.Forms.Label();
            this.txtStatut = new System.Windows.Forms.TextBox();
            this.lbDateCommande = new System.Windows.Forms.Label();
            this.txtDateCommande = new System.Windows.Forms.TextBox();
            this.lbStatut = new System.Windows.Forms.Label();
            this.lkClient = new System.Windows.Forms.LinkLabel();
            this.txtIDCommande = new System.Windows.Forms.TextBox();
            this.lbIDCommande = new System.Windows.Forms.Label();
            this.tlpContainerAll = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            this.dgvPanier = new System.Windows.Forms.DataGridView();
            this.IDArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domaine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpFilterContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbContient = new System.Windows.Forms.Label();
            this.cbFieldFilter = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.tlpContainerData.Size = new System.Drawing.Size(1168, 186);
            this.tlpContainerData.TabIndex = 13;
            // 
            // pnlRightData
            // 
            this.pnlRightData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRightData.AutoSize = true;
            this.pnlRightData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRightData.Controls.Add(this.txtTotalHT);
            this.pnlRightData.Controls.Add(this.txtTotalTTC);
            this.pnlRightData.Controls.Add(this.lbPrixAchat);
            this.pnlRightData.Controls.Add(this.lbPrixTTC);
            this.pnlRightData.Location = new System.Drawing.Point(918, 0);
            this.pnlRightData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRightData.Name = "pnlRightData";
            this.pnlRightData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlRightData.Size = new System.Drawing.Size(250, 186);
            this.pnlRightData.TabIndex = 1;
            // 
            // txtTotalHT
            // 
            this.txtTotalHT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalHT.Location = new System.Drawing.Point(154, 7);
            this.txtTotalHT.Margin = new System.Windows.Forms.Padding(0);
            this.txtTotalHT.Name = "txtTotalHT";
            this.txtTotalHT.ReadOnly = true;
            this.txtTotalHT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalHT.Size = new System.Drawing.Size(96, 24);
            this.txtTotalHT.TabIndex = 1;
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
            // lbPrixAchat
            // 
            this.lbPrixAchat.AutoSize = true;
            this.lbPrixAchat.Location = new System.Drawing.Point(13, 10);
            this.lbPrixAchat.Name = "lbPrixAchat";
            this.lbPrixAchat.Size = new System.Drawing.Size(111, 19);
            this.lbPrixAchat.TabIndex = 15;
            this.lbPrixAchat.Text = "Prix total HT (€) :";
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
            this.pnlLeftData.Controls.Add(this.txtPrenomClient);
            this.pnlLeftData.Controls.Add(this.lbPrenomClient);
            this.pnlLeftData.Controls.Add(this.txtNomClient);
            this.pnlLeftData.Controls.Add(this.lbNomClient);
            this.pnlLeftData.Controls.Add(this.txtIDClient);
            this.pnlLeftData.Controls.Add(this.lbIDClient);
            this.pnlLeftData.Controls.Add(this.txtStatut);
            this.pnlLeftData.Controls.Add(this.lbDateCommande);
            this.pnlLeftData.Controls.Add(this.txtDateCommande);
            this.pnlLeftData.Controls.Add(this.lbStatut);
            this.pnlLeftData.Controls.Add(this.lkClient);
            this.pnlLeftData.Controls.Add(this.txtIDCommande);
            this.pnlLeftData.Controls.Add(this.lbIDCommande);
            this.pnlLeftData.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeftData.Name = "pnlLeftData";
            this.pnlLeftData.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.pnlLeftData.Size = new System.Drawing.Size(918, 186);
            this.pnlLeftData.TabIndex = 0;
            // 
            // txtPrenomClient
            // 
            this.txtPrenomClient.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrenomClient.Location = new System.Drawing.Point(562, 97);
            this.txtPrenomClient.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrenomClient.Name = "txtPrenomClient";
            this.txtPrenomClient.ReadOnly = true;
            this.txtPrenomClient.Size = new System.Drawing.Size(282, 24);
            this.txtPrenomClient.TabIndex = 27;
            // 
            // lbPrenomClient
            // 
            this.lbPrenomClient.AutoSize = true;
            this.lbPrenomClient.Location = new System.Drawing.Point(436, 100);
            this.lbPrenomClient.Name = "lbPrenomClient";
            this.lbPrenomClient.Size = new System.Drawing.Size(64, 19);
            this.lbPrenomClient.TabIndex = 26;
            this.lbPrenomClient.Text = "Prénom :";
            // 
            // txtNomClient
            // 
            this.txtNomClient.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomClient.Location = new System.Drawing.Point(562, 52);
            this.txtNomClient.Margin = new System.Windows.Forms.Padding(0);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.ReadOnly = true;
            this.txtNomClient.Size = new System.Drawing.Size(282, 24);
            this.txtNomClient.TabIndex = 25;
            // 
            // lbNomClient
            // 
            this.lbNomClient.AutoSize = true;
            this.lbNomClient.Location = new System.Drawing.Point(436, 55);
            this.lbNomClient.Name = "lbNomClient";
            this.lbNomClient.Size = new System.Drawing.Size(46, 19);
            this.lbNomClient.TabIndex = 24;
            this.lbNomClient.Text = "Nom :";
            // 
            // txtIDClient
            // 
            this.txtIDClient.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDClient.Location = new System.Drawing.Point(562, 7);
            this.txtIDClient.Margin = new System.Windows.Forms.Padding(0);
            this.txtIDClient.Name = "txtIDClient";
            this.txtIDClient.ReadOnly = true;
            this.txtIDClient.Size = new System.Drawing.Size(140, 24);
            this.txtIDClient.TabIndex = 15;
            // 
            // lbIDClient
            // 
            this.lbIDClient.AutoSize = true;
            this.lbIDClient.Location = new System.Drawing.Point(436, 10);
            this.lbIDClient.Name = "lbIDClient";
            this.lbIDClient.Size = new System.Drawing.Size(69, 19);
            this.lbIDClient.TabIndex = 22;
            this.lbIDClient.Text = "ID Client :";
            // 
            // txtStatut
            // 
            this.txtStatut.BackColor = System.Drawing.Color.Gold;
            this.txtStatut.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStatut.Location = new System.Drawing.Point(126, 142);
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
            this.lbStatut.Location = new System.Drawing.Point(0, 145);
            this.lbStatut.Name = "lbStatut";
            this.lbStatut.Size = new System.Drawing.Size(53, 19);
            this.lbStatut.TabIndex = 18;
            this.lbStatut.Text = "Statut :";
            // 
            // lkClient
            // 
            this.lkClient.AutoSize = true;
            this.lkClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkClient.LinkColor = System.Drawing.Color.Gray;
            this.lkClient.Location = new System.Drawing.Point(710, 10);
            this.lkClient.Name = "lkClient";
            this.lkClient.Size = new System.Drawing.Size(121, 19);
            this.lkClient.TabIndex = 17;
            this.lkClient.TabStop = true;
            this.lkClient.Text = "Accéder au client...";
            this.lkClient.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lkClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClientLinkClicked);
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
            this.tlpContainerAll.Size = new System.Drawing.Size(1268, 455);
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
            this.pnlTableContainer.Location = new System.Drawing.Point(50, 385);
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
            this.Domaine,
            this.PrixTTC,
            this.TVA,
            this.Quantite,
            this.TotalHT,
            this.TotalTTC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPanier.DefaultCellStyle = dataGridViewCellStyle2;
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
            // IDArticle
            // 
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
            // Domaine
            // 
            this.Domaine.HeaderText = "Domaine";
            this.Domaine.Name = "Domaine";
            this.Domaine.ReadOnly = true;
            this.Domaine.Width = 200;
            // 
            // PrixTTC
            // 
            this.PrixTTC.HeaderText = "Prix TTC unitaire (€)";
            this.PrixTTC.Name = "PrixTTC";
            this.PrixTTC.ReadOnly = true;
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
            // TotalHT
            // 
            this.TotalHT.HeaderText = "Total HT (€)";
            this.TotalHT.Name = "TotalHT";
            this.TotalHT.ReadOnly = true;
            // 
            // TotalTTC
            // 
            this.TotalTTC.HeaderText = "Total TTC (€)";
            this.TotalTTC.Name = "TotalTTC";
            this.TotalTTC.ReadOnly = true;
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
            this.tlpFilterContainer.Location = new System.Drawing.Point(770, 347);
            this.tlpFilterContainer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
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
            // CommandeClientIndiv
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
            this.Name = "CommandeClientIndiv";
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
        private Label lbPrixAchat;
        private TextBox txtTotalHT;
        private TextBox txtTotalTTC;
        private TextBox txtIDCommande;
        private Label lbIDCommande;
        private ErrorProvider errorProvider;
        private LinkLabel lkClient;
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
        private TextBox txtIDClient;
        private Label lbNomClient;
        private TextBox txtNomClient;
        private Label lbPrenomClient;
        private TextBox txtPrenomClient;
        private DataGridViewTextBoxColumn IDArticle;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Domaine;
        private DataGridViewTextBoxColumn PrixTTC;
        private DataGridViewTextBoxColumn TVA;
        private DataGridViewTextBoxColumn Quantite;
        private DataGridViewTextBoxColumn TotalHT;
        private DataGridViewTextBoxColumn TotalTTC;
    }
}