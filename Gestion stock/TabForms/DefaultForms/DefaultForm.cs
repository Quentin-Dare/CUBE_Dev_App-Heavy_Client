using Gestion_stock.TabForms.DefaultForms;
using Gestion_stock.Utils;
using Gestion_stock.Utils.CustomControls;

namespace Gestion_stock.Forms
{
    public abstract partial class DefaultForm : Form, IPageNegosud
    {
        #region Private Variables

        private string formTitle = string.Empty;
        private string tabID = string.Empty;
        private bool showAddButton;
        private bool hideFirstColumn;

        private int clickedRowIndex;

        #endregion

        #region Protected Variables

        protected DataGridView MainData
        {
            get
            {
                return dgvData;
            }
            set { dgvData = value; }
        }

        #endregion

        #region Public Variables

        public string FormTitle
        {
            get
            {
                return formTitle;
            }
            set
            {
                formTitle = value;
                lbFormTitle.Text = value;
            }
        }

        public string TabID
        {
            get
            {
                return tabID;
            }
            set
            {
                tabID = value;
            }
        }

        protected bool ShowAddButton
        {
            get
            {
                return showAddButton;
            }
            set
            {
                showAddButton = value;
            }
        }

        protected bool HideFirstColumn
        {
            get
            {
                return hideFirstColumn;
            }
            set
            {
                hideFirstColumn = value;
                if (dgvData.Columns.Count > 0)
                {
                    dgvData.Columns[0].Visible = !value;
                }
            }
        }

        #endregion

        #region Constructeur

        public DefaultForm()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            clickedRowIndex = -1;
            dgvData.AutoSize = true;
        }

        #endregion

        #region Methods

        protected void InitializeChild(string formTitle, string tabID, bool showAddButton, bool hideFirstColumn, IEnumerable<object> query, CustomGridView.ColumnDesign[] columnDesign)
        {
            this.FormTitle = formTitle;
            this.TabID = tabID;
            this.ShowAddButton = showAddButton;

            BindingSource bindingSource = new BindingSource();
            foreach (var row in query)
            {
                bindingSource.Add(row);
            }

            dgvData.AutoGenerateColumns = true;
            dgvData.Columns.Clear();
            dgvData.DataSource = bindingSource;

            // Si le nombre d'objets de design est différent du nombre de colonnes, alors erreur
            if ((columnDesign.Length != dgvData.ColumnCount)
                || (hideFirstColumn && columnDesign.Length != dgvData.ColumnCount - 1))
            {
                CustomMethods.DisplayError("Erreur dans le nom des colonnes.");
            }
            else
            {
                // Si hideFirstColumn = true, la variable i doit commencer à la colonne 1, sinon elle doit commencer à la colonne 0
                for (int i = hideFirstColumn ? 1 : 0; i < dgvData.Columns.Count; i++)
                {
                    dgvData.Columns[i].HeaderText = columnDesign[i].Name;
                    dgvData.Columns[i].Width = columnDesign[i].ColumnWidth;
                    if (columnDesign[i].TextAlignement == 'R')
                    {
                        dgvData.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
        }

        #endregion


        /*



// Event quand on clique sur une cellule
private void dgvDataDisplay_CellClicked(object sender, EventArgs e)
{
   // Si la ligne cliquée est la même que celle qu'on a cliqué avant
   if (e.RowHandle == clickedRowIndex
       && e.GetMainForm is Negosud mainForm)
   {
       string rowID = dgvDataDisplay.GetRowCellValue(e.RowHandle, dgvDataDisplay.Columns[0]).ToString();
       OpenIndividualTab(rowID);
   }
   else
   {
       // Changer la couleur de la ligne
       clickedRowIndex = e.RowHandle;
   }
}

private void btnAddItem_Clicked(object sender, EventArgs e)
{
   OpenAddItemTab();
}

protected virtual void OpenIndividualTab(string rowID);
protected virtual void OpenAddItemTab();
*/
    }
}
