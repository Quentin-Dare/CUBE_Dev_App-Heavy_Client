using Gestion_stock.Forms.FormIndividual;
using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using System.Data;
using System.Windows.Forms;

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
        private string? idFournisseur;
        List<GridViewInfo> gridArticlesListe = new List<GridViewInfo>();
        List<string> idArticles = new List<string>();

        // Autres données
        int selectedArticle = -1;

        List<FournisseurInfo> listeNomFournisseurs = DataUtils.GetSuppliersName();
        List<object> listeArticles = new List<object>();

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
            AddEvents();
        }

        #region Constructor Methods

        private void FillComboBoxData()
        {
            foreach (FournisseurInfo fournisseur in listeNomFournisseurs)
            {
                txtFournisseur.Items.Add(fournisseur.Nom);
            }
        }

        /// <summary>
        /// Ajout des évènements custom de la page
        /// </summary>
        private void AddEvents()
        {
            // Evènements pour filter les textbox de chiffres
            this.txtCoutTransport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CustomEvents.FilterDecimals);
        }

        #endregion

        #endregion

        #region Events

        private void SavePage(object sender, EventArgs e)
        {
            if (!CustomMethods.ConfirmDataSave())
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

        /// <summary>
        /// Evenement quand le nom du fournisseur a été changé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FournisseurChanged(object sender, EventArgs e)
        {
            if (txtFournisseur.SelectedIndex < 0)
            {
                idFournisseur = null;
                this.pnlContainerBtnRows.Visible = false;
            }
            else
            {
                idFournisseur = listeNomFournisseurs[txtFournisseur.SelectedIndex].IDFournisseur;
                this.pnlContainerBtnRows.Visible = true;
            }

            txtIDFournisseur.Text = idFournisseur;
        }

        private void ArticlesCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            selectedArticle = e.RowIndex;
        }

        /// <summary>
        /// Méthode qui se lance la première fois qu'on édite les valeurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterEditingFirstTime(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvPanier.CurrentCell.ColumnIndex == dgvPanier.Columns["Quantite"].Index
                && e.Control is TextBox tb)
            {
                string quantiteValue = tb.Text;
                tb.KeyPress -= new KeyPressEventHandler(CustomEvents.FilterIntegers);

                tb.KeyPress += new KeyPressEventHandler(CustomEvents.FilterIntegers);

                if (quantiteValue == tb.Text)
                {
                    CalculTotal(dgvPanier.CurrentCell.RowIndex);
                }
            }
        }

        public static void FilterIntegers(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddArticleLine(object sender, EventArgs e)
        {
            this.dgvPanier.Rows.Add();
            int lastRowIndex = dgvPanier.Rows.Count - 1;
            this.dgvPanier.CurrentCell = dgvPanier.Rows[lastRowIndex].Cells[1];
            selectedArticle = lastRowIndex;
        }

        private void RemoveArticleLine(object sender, EventArgs e)
        {
            if (selectedArticle == -1)
            {
                return;
            }

            this.dgvPanier.Rows.RemoveAt(selectedArticle);
            selectedArticle = -1;
        }

        #endregion

        #region Requests

        #endregion

        #region Manage Data

        private void CalculTotal(int rowIndex)
        {
            if (dgvPanier.Rows[rowIndex].Cells["PrixAchat"].Value == null
                || dgvPanier.Rows[rowIndex].Cells["Quantite"].Value == null)
            {
                return;
            }

            try
            {
                decimal quantite = Convert.ToInt32(dgvPanier.Rows[rowIndex].Cells["Quantite"].Value);
                decimal prixAchat = Convert.ToDecimal(dgvPanier.Rows[rowIndex].Cells["PrixAchat"].Value);

                dgvPanier.Rows[rowIndex].Cells["PrixTotal"].Value = quantite * prixAchat;
            }
            catch (Exception)
            {
                return;
            }
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
