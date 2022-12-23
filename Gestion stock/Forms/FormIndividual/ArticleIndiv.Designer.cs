namespace Gestion_stock.Forms.FormIndividual
{
    partial class ArticleIndiv
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lbDomaine = new System.Windows.Forms.Label();
            this.lbFamilleVin = new System.Windows.Forms.Label();
            this.lbAnnee = new System.Windows.Forms.Label();
            this.tlpContainerData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRightData = new System.Windows.Forms.Panel();
            this.txtQuantiteMin = new System.Windows.Forms.TextBox();
            this.lbQuantiteMin = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtTVA = new System.Windows.Forms.TextBox();
            this.txtPrixAchat = new System.Windows.Forms.TextBox();
            this.txtPrixTTC = new System.Windows.Forms.TextBox();
            this.lbQuantite = new System.Windows.Forms.Label();
            this.lbTVA = new System.Windows.Forms.Label();
            this.lbPrixAchat = new System.Windows.Forms.Label();
            this.lbPrixTTC = new System.Windows.Forms.Label();
            this.pnlLeftData = new System.Windows.Forms.Panel();
            this.lkFournisseur = new System.Windows.Forms.LinkLabel();
            this.txtFournisseur = new System.Windows.Forms.ComboBox();
            this.txtFamille = new System.Windows.Forms.ComboBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.lbReference = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.tlpContainerAll = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.flpButtons.SuspendLayout();
            this.tlpContainerData.SuspendLayout();
            this.pnlRightData.SuspendLayout();
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
            this.lbFormTitle.Text = "Montazac Rouge";
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
            this.btnReload.Text = "Rafraîchir";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.ReloadPage);
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(0, 55);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(46, 19);
            this.lbNom.TabIndex = 6;
            this.lbNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNom.Location = new System.Drawing.Point(126, 52);
            this.txtNom.Margin = new System.Windows.Forms.Padding(0);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(282, 24);
            this.txtNom.TabIndex = 7;
            // 
            // lbDomaine
            // 
            this.lbDomaine.AutoSize = true;
            this.lbDomaine.Location = new System.Drawing.Point(0, 100);
            this.lbDomaine.Margin = new System.Windows.Forms.Padding(0);
            this.lbDomaine.Name = "lbDomaine";
            this.lbDomaine.Size = new System.Drawing.Size(71, 19);
            this.lbDomaine.TabIndex = 8;
            this.lbDomaine.Text = "Domaine :";
            // 
            // lbFamilleVin
            // 
            this.lbFamilleVin.AutoSize = true;
            this.lbFamilleVin.Location = new System.Drawing.Point(0, 145);
            this.lbFamilleVin.Name = "lbFamilleVin";
            this.lbFamilleVin.Size = new System.Drawing.Size(99, 19);
            this.lbFamilleVin.TabIndex = 9;
            this.lbFamilleVin.Text = "Famille de vin :";
            // 
            // lbAnnee
            // 
            this.lbAnnee.AutoSize = true;
            this.lbAnnee.Location = new System.Drawing.Point(0, 190);
            this.lbAnnee.Name = "lbAnnee";
            this.lbAnnee.Size = new System.Drawing.Size(55, 19);
            this.lbAnnee.TabIndex = 12;
            this.lbAnnee.Text = "Année :";
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
            this.pnlRightData.Controls.Add(this.txtQuantiteMin);
            this.pnlRightData.Controls.Add(this.lbQuantiteMin);
            this.pnlRightData.Controls.Add(this.txtQuantite);
            this.pnlRightData.Controls.Add(this.txtTVA);
            this.pnlRightData.Controls.Add(this.txtPrixAchat);
            this.pnlRightData.Controls.Add(this.txtPrixTTC);
            this.pnlRightData.Controls.Add(this.lbQuantite);
            this.pnlRightData.Controls.Add(this.lbTVA);
            this.pnlRightData.Controls.Add(this.lbPrixAchat);
            this.pnlRightData.Controls.Add(this.lbPrixTTC);
            this.pnlRightData.Location = new System.Drawing.Point(650, 0);
            this.pnlRightData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRightData.Name = "pnlRightData";
            this.pnlRightData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlRightData.Size = new System.Drawing.Size(250, 448);
            this.pnlRightData.TabIndex = 1;
            // 
            // txtQuantiteMin
            // 
            this.txtQuantiteMin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantiteMin.Location = new System.Drawing.Point(154, 52);
            this.txtQuantiteMin.Margin = new System.Windows.Forms.Padding(0);
            this.txtQuantiteMin.Name = "txtQuantiteMin";
            this.txtQuantiteMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQuantiteMin.Size = new System.Drawing.Size(96, 24);
            this.txtQuantiteMin.TabIndex = 18;
            // 
            // lbQuantiteMin
            // 
            this.lbQuantiteMin.AutoSize = true;
            this.lbQuantiteMin.Location = new System.Drawing.Point(13, 55);
            this.lbQuantiteMin.Name = "lbQuantiteMin";
            this.lbQuantiteMin.Size = new System.Drawing.Size(118, 19);
            this.lbQuantiteMin.TabIndex = 19;
            this.lbQuantiteMin.Text = "Quantité requise :";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantite.Location = new System.Drawing.Point(154, 7);
            this.txtQuantite.Margin = new System.Windows.Forms.Padding(0);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQuantite.Size = new System.Drawing.Size(96, 24);
            this.txtQuantite.TabIndex = 3;
            // 
            // txtTVA
            // 
            this.txtTVA.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTVA.Location = new System.Drawing.Point(154, 97);
            this.txtTVA.Margin = new System.Windows.Forms.Padding(0);
            this.txtTVA.Name = "txtTVA";
            this.txtTVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTVA.Size = new System.Drawing.Size(96, 24);
            this.txtTVA.TabIndex = 2;
            // 
            // txtPrixAchat
            // 
            this.txtPrixAchat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrixAchat.Location = new System.Drawing.Point(154, 142);
            this.txtPrixAchat.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrixAchat.Name = "txtPrixAchat";
            this.txtPrixAchat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrixAchat.Size = new System.Drawing.Size(96, 24);
            this.txtPrixAchat.TabIndex = 1;
            // 
            // txtPrixTTC
            // 
            this.txtPrixTTC.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrixTTC.Location = new System.Drawing.Point(154, 187);
            this.txtPrixTTC.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrixTTC.Name = "txtPrixTTC";
            this.txtPrixTTC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrixTTC.Size = new System.Drawing.Size(96, 24);
            this.txtPrixTTC.TabIndex = 4;
            // 
            // lbQuantite
            // 
            this.lbQuantite.AutoSize = true;
            this.lbQuantite.Location = new System.Drawing.Point(13, 10);
            this.lbQuantite.Name = "lbQuantite";
            this.lbQuantite.Size = new System.Drawing.Size(124, 19);
            this.lbQuantite.TabIndex = 17;
            this.lbQuantite.Text = "Quantité restante :";
            // 
            // lbTVA
            // 
            this.lbTVA.AutoSize = true;
            this.lbTVA.Location = new System.Drawing.Point(14, 100);
            this.lbTVA.Name = "lbTVA";
            this.lbTVA.Size = new System.Drawing.Size(63, 19);
            this.lbTVA.TabIndex = 16;
            this.lbTVA.Text = "TVA (%) :";
            // 
            // lbPrixAchat
            // 
            this.lbPrixAchat.AutoSize = true;
            this.lbPrixAchat.Location = new System.Drawing.Point(13, 145);
            this.lbPrixAchat.Name = "lbPrixAchat";
            this.lbPrixAchat.Size = new System.Drawing.Size(106, 19);
            this.lbPrixAchat.TabIndex = 15;
            this.lbPrixAchat.Text = "Prix d\'achat (€) :";
            // 
            // lbPrixTTC
            // 
            this.lbPrixTTC.AutoSize = true;
            this.lbPrixTTC.Location = new System.Drawing.Point(14, 189);
            this.lbPrixTTC.Name = "lbPrixTTC";
            this.lbPrixTTC.Size = new System.Drawing.Size(84, 19);
            this.lbPrixTTC.TabIndex = 7;
            this.lbPrixTTC.Text = "Prix TTC (€) :";
            // 
            // pnlLeftData
            // 
            this.pnlLeftData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLeftData.AutoScroll = true;
            this.pnlLeftData.AutoSize = true;
            this.pnlLeftData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLeftData.Controls.Add(this.lkFournisseur);
            this.pnlLeftData.Controls.Add(this.txtFournisseur);
            this.pnlLeftData.Controls.Add(this.txtFamille);
            this.pnlLeftData.Controls.Add(this.txtReference);
            this.pnlLeftData.Controls.Add(this.lbReference);
            this.pnlLeftData.Controls.Add(this.txtDescription);
            this.pnlLeftData.Controls.Add(this.lbDescription);
            this.pnlLeftData.Controls.Add(this.txtAnnee);
            this.pnlLeftData.Controls.Add(this.lbNom);
            this.pnlLeftData.Controls.Add(this.lbAnnee);
            this.pnlLeftData.Controls.Add(this.txtNom);
            this.pnlLeftData.Controls.Add(this.lbDomaine);
            this.pnlLeftData.Controls.Add(this.lbFamilleVin);
            this.pnlLeftData.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftData.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeftData.Name = "pnlLeftData";
            this.pnlLeftData.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.pnlLeftData.Size = new System.Drawing.Size(650, 448);
            this.pnlLeftData.TabIndex = 0;
            // 
            // lkFournisseur
            // 
            this.lkFournisseur.AutoSize = true;
            this.lkFournisseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkFournisseur.LinkColor = System.Drawing.Color.Gray;
            this.lkFournisseur.Location = new System.Drawing.Point(414, 100);
            this.lkFournisseur.Name = "lkFournisseur";
            this.lkFournisseur.Size = new System.Drawing.Size(157, 19);
            this.lkFournisseur.TabIndex = 17;
            this.lkFournisseur.Text = "Accéder au fournisseur...";
            this.lkFournisseur.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lkFournisseur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FournisseurLinkClicked);
            // 
            // txtFournisseur
            // 
            this.txtFournisseur.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFournisseur.FormattingEnabled = true;
            this.txtFournisseur.Location = new System.Drawing.Point(126, 97);
            this.txtFournisseur.Name = "txtFournisseur";
            this.txtFournisseur.Size = new System.Drawing.Size(282, 25);
            this.txtFournisseur.TabIndex = 10;
            // 
            // txtFamille
            // 
            this.txtFamille.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFamille.FormattingEnabled = true;
            this.txtFamille.Location = new System.Drawing.Point(126, 141);
            this.txtFamille.Name = "txtFamille";
            this.txtFamille.Size = new System.Drawing.Size(282, 25);
            this.txtFamille.TabIndex = 13;
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReference.Location = new System.Drawing.Point(126, 7);
            this.txtReference.Margin = new System.Windows.Forms.Padding(0);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(182, 24);
            this.txtReference.TabIndex = 5;
            // 
            // lbReference
            // 
            this.lbReference.AutoSize = true;
            this.lbReference.Location = new System.Drawing.Point(0, 10);
            this.lbReference.Name = "lbReference";
            this.lbReference.Size = new System.Drawing.Size(75, 19);
            this.lbReference.TabIndex = 16;
            this.lbReference.Text = "Référence :";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(0, 271);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDescription.Size = new System.Drawing.Size(405, 154);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.Text = "";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(0, 235);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(85, 19);
            this.lbDescription.TabIndex = 14;
            this.lbDescription.Text = "Description :";
            // 
            // txtAnnee
            // 
            this.txtAnnee.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAnnee.Location = new System.Drawing.Point(126, 187);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAnnee.Size = new System.Drawing.Size(83, 24);
            this.txtAnnee.TabIndex = 13;
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
            // ArticleIndiv
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
            this.Name = "ArticleIndiv";
            this.flpButtons.ResumeLayout(false);
            this.tlpContainerData.ResumeLayout(false);
            this.tlpContainerData.PerformLayout();
            this.pnlRightData.ResumeLayout(false);
            this.pnlRightData.PerformLayout();
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
        private TextBox txtNom;
        private Label lbDomaine;
        private Label lbFamilleVin;
        private Label lbAnnee;
        private TableLayoutPanel tlpContainerData;
        private Panel pnlRightData;
        private Panel pnlLeftData;
        private TextBox txtAnnee;
        private RichTextBox txtDescription;
        private Label lbDescription;
        private TableLayoutPanel tlpContainerAll;
        private Label lbPrixTTC;
        private Label lbPrixAchat;
        private Label lbTVA;
        private Label lbQuantite;
        private TextBox txtQuantite;
        private TextBox txtTVA;
        private TextBox txtPrixAchat;
        private TextBox txtPrixTTC;
        private TextBox txtReference;
        private Label lbReference;
        private ComboBox txtFamille;
        private ComboBox txtFournisseur;
        private ErrorProvider errorProvider;
        private LinkLabel lkFournisseur;
        private TextBox txtQuantiteMin;
        private Label lbQuantiteMin;
    }
}