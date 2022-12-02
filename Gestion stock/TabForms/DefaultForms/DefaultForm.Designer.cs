using System.Security.Policy;

namespace Gestion_stock.Forms
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tlpFilterContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbContient = new System.Windows.Forms.Label();
            this.cbFieldFilter = new System.Windows.Forms.ComboBox();
            this.tlpContainerAll = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tlpFilterContainer.SuspendLayout();
            this.tlpContainerAll.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Margin = new System.Windows.Forms.Padding(0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 30;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(316, 150);
            this.dgvData.TabIndex = 0;
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
            this.lbFormTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
            this.lbFormTitle.Location = new System.Drawing.Point(50, 67);
            this.lbFormTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbFormTitle.Name = "lbFormTitle";
            this.lbFormTitle.Size = new System.Drawing.Size(847, 51);
            this.lbFormTitle.TabIndex = 0;
            this.lbFormTitle.Text = "Form par défaut";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.AutoSize = true;
            this.btnAddItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(728, 20);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.btnAddItem.Size = new System.Drawing.Size(169, 47);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.TabStop = false;
            this.btnAddItem.Text = "Ajouter un article";
            this.btnAddItem.UseVisualStyleBackColor = false;
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
            this.tlpFilterContainer.Location = new System.Drawing.Point(445, 138);
            this.tlpFilterContainer.Margin = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.tlpFilterContainer.Name = "tlpFilterContainer";
            this.tlpFilterContainer.RowCount = 1;
            this.tlpFilterContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilterContainer.Size = new System.Drawing.Size(452, 28);
            this.tlpFilterContainer.TabIndex = 2;
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFilter.Location = new System.Drawing.Point(252, 0);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(200, 27);
            this.tbFilter.TabIndex = 2;
            // 
            // lbContient
            // 
            this.lbContient.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbContient.AutoSize = true;
            this.lbContient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbContient.Location = new System.Drawing.Point(173, 3);
            this.lbContient.Name = "lbContient";
            this.lbContient.Size = new System.Drawing.Size(76, 21);
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
            // 
            // tlpContainerAll
            // 
            this.tlpContainerAll.AutoSize = true;
            this.tlpContainerAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpContainerAll.ColumnCount = 1;
            this.tlpContainerAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerAll.Controls.Add(this.pnlTableContainer, 0, 3);
            this.tlpContainerAll.Controls.Add(this.lbFormTitle, 0, 1);
            this.tlpContainerAll.Controls.Add(this.tlpFilterContainer, 0, 2);
            this.tlpContainerAll.Controls.Add(this.btnAddItem, 0, 0);
            this.tlpContainerAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainerAll.Location = new System.Drawing.Point(0, 0);
            this.tlpContainerAll.Margin = new System.Windows.Forms.Padding(0);
            this.tlpContainerAll.Name = "tlpContainerAll";
            this.tlpContainerAll.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.tlpContainerAll.RowCount = 4;
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainerAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainerAll.Size = new System.Drawing.Size(947, 647);
            this.tlpContainerAll.TabIndex = 4;
            // 
            // pnlTableContainer
            // 
            this.pnlTableContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableContainer.AutoScroll = true;
            this.pnlTableContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlTableContainer.Controls.Add(this.dgvData);
            this.pnlTableContainer.Location = new System.Drawing.Point(50, 176);
            this.pnlTableContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTableContainer.Name = "pnlTableContainer";
            this.pnlTableContainer.Size = new System.Drawing.Size(847, 451);
            this.pnlTableContainer.TabIndex = 5;
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(947, 647);
            this.Controls.Add(this.tlpContainerAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DefaultForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tlpFilterContainer.ResumeLayout(false);
            this.tlpFilterContainer.PerformLayout();
            this.tlpContainerAll.ResumeLayout(false);
            this.tlpContainerAll.PerformLayout();
            this.pnlTableContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbFormTitle;
        private Button btnAddItem;
        private TableLayoutPanel tlpFilterContainer;
        private TextBox tbFilter;
        private Label lbContient;
        private ComboBox cbFieldFilter;
        private TableLayoutPanel tlpContainerAll;
        private Panel pnlTableContainer;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn Column1;
    }
}