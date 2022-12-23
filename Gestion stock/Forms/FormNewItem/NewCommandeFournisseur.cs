using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using System.Data;

namespace Gestion_stock.Forms.FormNewItem
{
    public partial class NewCommandeFournisseur : Form, IPageNegosud
    {
        #region Private Variables

        // Infos de base
        private string formTitle = "Nouvelle commande";
        private string tabID = "NouvelleCommande";

        // ID et données de la commande
        private PageInfo commande;
        private List<GridViewInfo> articlesList = new List<GridViewInfo>();

        // Autres données
        List<string> idArticles = new List<string>();

        List<FournisseurInfo> listeNomFournisseurs = DataUtils.GetSuppliersName();

        #endregion

        #region Public Variables

        public string FormTitle
        {
            get { return formTitle; }
            set
            {
                formTitle = value;
                lbFormTitle.Text = value;
            }
        }
        public string TabID { get => tabID; set => tabID = value; }

        #endregion

        #region Constructor

        public NewCommandeFournisseur()
        {
            InitializeComponent();
            Initialize.Design(this);
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            commande = new PageInfo();

            FillComboBoxData();
        }

        #region Constructor Methods

        private void FillComboBoxData()
        {
            foreach (FournisseurInfo fournisseur in listeNomFournisseurs)
            {
                txtFournisseur.Items.Add(fournisseur.Nom);
            }
        }

        #endregion

        #endregion

        #region Events

        private void ClosePage(object sender, EventArgs e)
        {
            if (!CustomMethods.ConfirmCloseCommand())
            {
                return;
            }

            MessageBox.Show("Bon bah code fdp");
        }

        private void ReloadPage(object sender, EventArgs e)
        {
            if (!CustomMethods.ConfirmCancelCommand())
            {
                return;
            }

            MessageBox.Show("Bon bah code fdp");
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
            // Pas de filtre si les 2 champs pour filtrer ne sont pas remplis
            if (this.cbFieldFilter.SelectedIndex == -1
                || string.IsNullOrEmpty(this.tbFilter.Text))
            {
                dgvPanier.DataSource = articlesList;
                dgvPanier.Refresh();
                return;
            }

            string columnToFilter = GetPropertyName();
            string filter = this.tbFilter.Text;

            // Filtre des données
            List<GridViewInfo> filteredRows = articlesList.Where(r => r.GetType().GetProperty(columnToFilter).GetValue(r).ToString().Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList();

            dgvPanier.DataSource = filteredRows;
            dgvPanier.Refresh();

        }

        /// <summary>
        /// Retourne la propriété de l'objet à filtrer
        /// </summary>
        /// <param name="defaultForm"></param>
        /// <returns></returns>
        private string GetPropertyName()
        {
            int columnIndex = this.cbFieldFilter.SelectedIndex + 1;

            string columnName = dgvPanier.Columns[columnIndex].Name;

            return columnName;
        }

        #endregion

        #region Other Methods

        #endregion

        #region Private classes

        private class PageInfo
        {
            public string? IDCommande { get; set; }
            public string? IDFournisseur { get; set; }
            public string? DateCommande { get; set; }
            public string? TypeCommande { get; set; }
            public string? Statut { get; set; }
            public decimal? CoutTransport { get; set; }
        }

        private class GridViewInfo
        {
            public string? IDArticle { get; set; }
            public string? Reference { get; set; }
            public string? Nom { get; set; }
            public string? Annee { get; set; }
            public decimal? PrixAchat { get; set; }
            public int? Quantite { get; set; }
            public decimal? TotalTTC { get; set; }
        }

        #endregion
    }
}
