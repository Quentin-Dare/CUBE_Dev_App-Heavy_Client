using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using Gestion_stock.Utils.CustomControls;
using System.Data;

namespace Gestion_stock.Forms.FormLists.Model
{
    public abstract partial class DefaultForm : Form, IPageNegosud
    {
        #region Private Variables

        private string formTitle = string.Empty;
        private string tabID = string.Empty;
        private bool showAddButton;
        private bool hideFirstColumn;

        private int selectedRow;
        private List<object> rowsList = new List<object>();

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
                btnAddItem.Visible = value;
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
                if (dgvMainTable.Columns.Count > 0)
                {
                    dgvMainTable.Columns[0].Visible = !value;
                }
            }
        }

        #endregion

        #region Abstract Properties

        protected abstract Form GetIndividualPage(string id);

        protected abstract Form GetNewItemForm();

        #endregion

        #region Constructor

        public DefaultForm()
        {
            InitializeComponent();
            Initialize.Design(this);
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        #region Constructor Methods

        protected void InitializePage(string formTitle, string tabID, bool showAddButton, string addButtonName,
            bool hideFirstColumn, List<object> rows, ColumnGridDesign[] columnDesign)
        {
            this.FormTitle = formTitle;
            this.TabID = tabID;
            this.ShowAddButton = showAddButton;
            this.btnAddItem.Text = addButtonName;
            this.rowsList = rows;

            InitializeGridView();

            // Si le nombre d'objets dans columnDesign est différent du nombre de colonnes, alors erreur
            if ((!hideFirstColumn && columnDesign.Length != dgvMainTable.ColumnCount)
                || (hideFirstColumn && columnDesign.Length != dgvMainTable.ColumnCount - 1))
            {
                CustomMethods.DisplayError("Erreur dans le design des colonnes.");
            }
            else
            {
                SetGridViewDesign(hideFirstColumn, columnDesign);
            }

            // La ligne sélectionnée par défaut est la ligne 0
            selectedRow = 0;
        }

        private void InitializeGridView()
        {
            dgvMainTable.Columns.Clear();
            dgvMainTable.AutoGenerateColumns = true;
            dgvMainTable.DataSource = rowsList;
            dgvMainTable.AutoSize = true;
            dgvMainTable.AutoGenerateColumns = false;
        }

        private void SetGridViewDesign(bool hideFirstColumn, ColumnGridDesign[] columnDesign)
        {
            HideFirstColumn = hideFirstColumn;

            // Suppression des items contenu dans le combobox de filtre
            this.cbFieldFilter.Items.Clear();

            // Si hideFirstColumn = true, la première colonne visible est la colonne 1, sinon c'est la colonne 0
            int indexToAdd = hideFirstColumn ? 1 : 0;

            // Ajout de chaque propriété de design à chaque colonne
            for (int i = 0; i < columnDesign.Length; i++)
            {
                int columnIndex = i + indexToAdd;

                dgvMainTable.Columns[columnIndex].HeaderText = columnDesign[i].Name;
                dgvMainTable.Columns[columnIndex].Width = columnDesign[i].ColumnWidth;
                if (columnDesign[i].TextAlignement == 'R')
                {
                    dgvMainTable.Columns[columnIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                // Ajout des noms des colonnes dans le combobox pour filtrer
                cbFieldFilter.Items.Add(columnDesign[i].Name);
            }
        }

        #endregion

        #endregion

        #region Events

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            // Si l'utilisateur a cliqué sur le header
            if (rowIndex == -1)
            {
                return;
            }

            // Si la cellule cliquée n'est pas la cellule déjà sélectionnée
            if (rowIndex != selectedRow)
            {
                selectedRow = rowIndex;
            }
            else
            {
                // Ouverture de la page individuelle
                // On sélectionne l'id de la ligne sélectionnée (toujours la première colonne du tableau)
                string? rowID = dgvMainTable.Rows[rowIndex].Cells[0].Value.ToString();

                if (rowID == null)
                {
                    CustomMethods.DisplayError("Erreur, pas d'ID");
                    return;
                }

                Form individualForm = GetIndividualPage(rowID);

                // Ouverture de la page
                if (this.TopLevelControl is NegoSUD topLevel)
                {
                    topLevel.AddTabIfNotExists(individualForm);
                }
            }
        }

        private void BtnAddClicked(object sender, EventArgs e)
        {
            // Il ne se passe rien si le bouton est censé être caché
            if (!showAddButton)
            {
                return;
            }

            Form newItemForm = GetNewItemForm();

            // Ouverture de la page
            if (this.TopLevelControl is NegoSUD topLevel)
            {
                topLevel.AddTabForce(newItemForm);
            }
            else
            {
                CustomMethods.DisplayError("Impossible de trouver la page parente Negosud.");
            }
        }

        #endregion

        #region Filtering

        /// <summary>
        /// Tentative de filtrage des données (pas opérationnel)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterData(object sender, EventArgs e)
        {
            // Check pour sélectionner si l'évènement a bien été fait par un control présent dans un Form DefaultForm
            if (sender is not Control control
                || control.FindForm() is not DefaultForm defaultForm)
            {
                CustomMethods.DisplayError("Erreur pour trouver DefaultForm");
                return;
            }

            // Pas de filtre si les 2 champs pour filtrer ne sont pas remplis
            if (defaultForm.cbFieldFilter.SelectedIndex == -1
                || string.IsNullOrEmpty(defaultForm.tbFilter.Text))
            {
                defaultForm.dgvMainTable.DataSource = rowsList;
                defaultForm.dgvMainTable.Refresh();
                return;
            }

            string columnToFilter = GetPropertyName(defaultForm);
            string filter = defaultForm.tbFilter.Text;

            // Filtre des données
            List<object> filteredRows = rowsList.Where(r => r.GetType().GetProperty(columnToFilter).GetValue(r).ToString().Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList();

            defaultForm.dgvMainTable.DataSource = filteredRows;
            defaultForm.dgvMainTable.Refresh();

            if (defaultForm.dgvMainTable.CurrentCell != null)
            {
                selectedRow = defaultForm.dgvMainTable.CurrentCell.RowIndex;
            }
            else
            {
                selectedRow = -1;
            }

        }

        /// <summary>
        /// Retourne la propriété de l'objet à filtrer
        /// </summary>
        /// <param name="defaultForm"></param>
        /// <returns></returns>
        private string GetPropertyName(DefaultForm defaultForm)
        {
            int columnIndex = defaultForm.cbFieldFilter.SelectedIndex;

            if (hideFirstColumn)
            {
                columnIndex++;
            }

            string columnName = defaultForm.dgvMainTable.Columns[columnIndex].Name;

            return columnName;
        }

        #endregion
    }
}
