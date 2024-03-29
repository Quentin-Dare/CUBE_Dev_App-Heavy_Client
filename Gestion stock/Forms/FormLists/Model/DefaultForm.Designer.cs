﻿namespace Gestion_stock.Forms.FormLists.Model
{
    partial class DefaultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMainTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbContient = new System.Windows.Forms.Label();
            this.cbFieldFilter = new System.Windows.Forms.ComboBox();
            this.tlpContainerAll = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFilterContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainTable)).BeginInit();
            this.tlpContainerAll.SuspendLayout();
            this.tlpFilterContainer.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMainTable
            // 
            this.dgvMainTable.AllowUserToOrderColumns = true;
            this.dgvMainTable.AllowUserToResizeRows = false;
            this.dgvMainTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvMainTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMainTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMainTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMainTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMainTable.EnableHeadersVisualStyles = false;
            this.dgvMainTable.Location = new System.Drawing.Point(0, 0);
            this.dgvMainTable.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMainTable.Name = "dgvMainTable";
            this.dgvMainTable.RowHeadersVisible = false;
            this.dgvMainTable.RowTemplate.Height = 30;
            this.dgvMainTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainTable.Size = new System.Drawing.Size(250, 150);
            this.dgvMainTable.TabIndex = 0;
            this.dgvMainTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClicked);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 239;
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
            this.lbFormTitle.Text = "Form par défaut";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(780, 20);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(170, 50);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.TabStop = false;
            this.btnAddItem.Text = "Ajouter un article";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddClicked);
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
            // tlpContainerAll
            // 
            this.tlpContainerAll.AutoSize = true;
            this.tlpContainerAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpContainerAll.ColumnCount = 1;
            this.tlpContainerAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerAll.Controls.Add(this.lbFormTitle, 0, 1);
            this.tlpContainerAll.Controls.Add(this.btnAddItem, 0, 0);
            this.tlpContainerAll.Controls.Add(this.tlpFilterContainer, 0, 2);
            this.tlpContainerAll.Controls.Add(this.pnlTableContainer, 0, 3);
            this.tlpContainerAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainerAll.Location = new System.Drawing.Point(0, 0);
            this.tlpContainerAll.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContainerAll.Name = "tlpContainerAll";
            this.tlpContainerAll.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.tlpContainerAll.RowCount = 4;
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerAll.Size = new System.Drawing.Size(1000, 647);
            this.tlpContainerAll.TabIndex = 4;
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
            this.tlpFilterContainer.Location = new System.Drawing.Point(502, 141);
            this.tlpFilterContainer.Margin = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.tlpFilterContainer.Name = "tlpFilterContainer";
            this.tlpFilterContainer.RowCount = 1;
            this.tlpFilterContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilterContainer.Size = new System.Drawing.Size(448, 28);
            this.tlpFilterContainer.TabIndex = 2;
            // 
            // pnlTableContainer
            // 
            this.pnlTableContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableContainer.AutoScroll = true;
            this.pnlTableContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlTableContainer.Controls.Add(this.dgvMainTable);
            this.pnlTableContainer.Location = new System.Drawing.Point(50, 179);
            this.pnlTableContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTableContainer.Name = "pnlTableContainer";
            this.pnlTableContainer.Size = new System.Drawing.Size(900, 448);
            this.pnlTableContainer.TabIndex = 5;
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1000, 647);
            this.Controls.Add(this.tlpContainerAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DefaultForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainTable)).EndInit();
            this.tlpContainerAll.ResumeLayout(false);
            this.tlpContainerAll.PerformLayout();
            this.tlpFilterContainer.ResumeLayout(false);
            this.tlpFilterContainer.PerformLayout();
            this.pnlTableContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbFormTitle;
        private Button btnAddItem;
        private TextBox tbFilter;
        private Label lbContient;
        private ComboBox cbFieldFilter;
        private TableLayoutPanel tlpContainerAll;
        private Panel pnlTableContainer;
        private DataGridView dgvMainTable;
        private DataGridViewTextBoxColumn Column1;
        private TableLayoutPanel tlpFilterContainer;
    }
}