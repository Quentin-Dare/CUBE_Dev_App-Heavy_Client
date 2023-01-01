using Gestion_stock.Forms.FormIndividual;
using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using System.Collections.Generic;
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
        List<string?[]> listeArticles = new List<string?[]>();

        // Autres données
        int selectedFournisseur = -1;
        int selectedArticle = -1;

        List<FournisseurInfo> listeNomFournisseurs = DataUtils.GetSuppliersName();
        List<ArticleInfo> everyArticleList = new List<ArticleInfo>();
        List<ArticleInfo> fournisseurArticlesList = new List<ArticleInfo>();

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
            GetAllArticlesList();
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

        private void GetAllArticlesList()
        {
            everyArticleList = GetArticles().ToList();
        }

        private void AddEvents()
        {
            // Evènements pour filter les textbox de chiffres
            this.txtCoutTransport.KeyPress += new KeyPressEventHandler(CustomEvents.FilterDecimals);
        }

        #endregion

        #endregion

        #region Events

        #region Save / Reload

        private void SavePage(object sender, EventArgs e)
        {
            if (!CustomMethods.ConfirmCommandCreation())
            {
                return;
            }

            if (!ControlData())
            {
                return;
            }

            // Ecriture des données
            commande = new PageInfo()
            {
                IDFournisseur = idFournisseur,
                DateCommande = DateTime.UtcNow.ToString("HH:mm dd/MM/yyyy"),
                TypeCommande = "MANUELLE",
                Statut = "EN COURS",
                CoutTransport = Convert.ToDecimal(txtCoutTransport.Text)
            };

            // Liste des articles commandés
            for (int i = 0; i < dgvPanier.Rows.Count; i++)
            {
                string? idArticle = dgvPanier.Rows[i].Cells["IDArticle"].Value.ToString();
                string? quantite = dgvPanier.Rows[i].Cells["Quantite"].Value.ToString();

                string?[] article = {idArticle, quantite};

                listeArticles.Add(article);
            }

            MessageBox.Show("Bon bah code fdp");
        }

        private void ReloadPage(object sender, EventArgs e)
        {
            if (!CustomMethods.ConfirmDataReload())
            {
                return;
            }

            txtCoutTransport.Text = "0";
            txtFournisseur.SelectedIndex = -1;
            txtIDFournisseur.Text = null;
            dgvPanier.Rows.Clear();
            txtTotalTTC.Text = "0";
        }

        #endregion

        #region Changement fournisseur

        /// <summary>
        /// Evenement quand le nom du fournisseur a été changé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FournisseurChanged(object sender, EventArgs e)
        {
            if (dgvPanier.Rows.Count > 0 && txtFournisseur.SelectedIndex >= 0)
            {
                DialogResult alert = MessageBox.Show("Vous allez perdre toutes les données. Continuer ?", "Avertissement",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (alert == DialogResult.No)
                {
                    txtFournisseur.SelectedIndex = selectedFournisseur;
                    return;
                }
            }

            this.dgvPanier.Rows.Clear();
            selectedFournisseur = txtFournisseur.SelectedIndex;

            if (txtFournisseur.SelectedIndex < 0)
            {
                idFournisseur = null;
                this.pnlContainerBtnRows.Visible = false;
            }
            else
            {
                idFournisseur = listeNomFournisseurs[selectedFournisseur].IDFournisseur;
                this.pnlContainerBtnRows.Visible = true;

                // Sélection des articles du fournisseur
                fournisseurArticlesList = everyArticleList.Where(r => r.IDFournisseur == idFournisseur).ToList();

                // Remplissage des combobox du tableau
                if (dgvPanier.Columns["Reference"] is DataGridViewComboBoxColumn referenceColumn
                    && dgvPanier.Columns["Nom"] is DataGridViewComboBoxColumn nomColumn)
                {
                    referenceColumn.Items.Clear();
                    nomColumn.Items.Clear();
                    for (int i = 0; i < fournisseurArticlesList.Count; i++)
                    {
                        referenceColumn.Items.Add(fournisseurArticlesList[i].Reference);
                        nomColumn.Items.Add(fournisseurArticlesList[i].Nom);
                    }
                }
            }

            txtIDFournisseur.Text = idFournisseur;
        }

        #endregion

        #region Grid Events

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
            }
            else if ((dgvPanier.CurrentCell.ColumnIndex == dgvPanier.Columns["Reference"].Index
                || dgvPanier.CurrentCell.ColumnIndex == dgvPanier.Columns["Nom"].Index)
                && e.Control is ComboBox cb)
            {
                cb.SelectedIndexChanged -= new EventHandler(ArticleChanged);
                cb.SelectedIndexChanged += new EventHandler(ArticleChanged);
            }
        }

        private void ArticleChanged(object? sender, EventArgs e)
        {
            if (sender is not ComboBox cb)
            {
                return;
            }

            int selectedReference = cb.SelectedIndex;

            DataGridViewCellCollection articleRow = dgvPanier.Rows[selectedArticle].Cells;

            articleRow["IDArticle"].Value = fournisseurArticlesList[selectedReference].IDArticle;
            articleRow["Reference"].Value = fournisseurArticlesList[selectedReference].Reference;
            articleRow["Nom"].Value = fournisseurArticlesList[selectedReference].Nom;
            articleRow["Annee"].Value = fournisseurArticlesList[selectedReference].Annee;
            articleRow["PrixAchat"].Value = fournisseurArticlesList[selectedReference].PrixAchat;

            articleRow["Quantite"].Value = 0;

            CalculArticleTotal(selectedArticle);

            dgvPanier.CurrentCell = articleRow["Quantite"];
        }

        private void dgvPanier_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPanier.Columns["Quantite"].Index)
            {
                CalculArticleTotal(selectedArticle);
            }
        }

        #endregion

        #region Add / Remove Grid lines

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

        #endregion

        #region Requests

        private IEnumerable<ArticleInfo> GetArticles()
        {
            IEnumerable<ArticleInfo> query =
                from articles in Tables.Articles.AsEnumerable()
                select new ArticleInfo
                {
                    IDFournisseur = Convert.ToString(articles["IDFournisseur"]),
                    IDArticle = Convert.ToString(articles["IDArticle"]),
                    Reference = Convert.ToString(articles["Reference"]),
                    Nom = Convert.ToString(articles["Nom"]),
                    Annee = Convert.ToString(articles["Annee"]),
                    PrixAchat = Convert.ToDecimal(articles["PrixAchat"]),
                };
            return query;
        }

        #endregion

        #region Manage Data

        private void CoutTransportChanged(object sender, EventArgs e)
        {
            CalculCommandeTotal();
        }

        private void CalculArticleTotal(int rowIndex)
        {
            if (rowIndex < 0)
            {
                return;
            }

            if (dgvPanier.Rows[rowIndex].Cells["PrixAchat"].Value == null
                || dgvPanier.Rows[rowIndex].Cells["Quantite"].Value == null)
            {
                dgvPanier.Rows[rowIndex].Cells["PrixTotal"].Value = 0;
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

            CalculCommandeTotal();
        }

        private void CalculCommandeTotal()
        {
            try
            {
                decimal.TryParse(txtCoutTransport.Text, out decimal coutTransport);

                decimal totalArticles = dgvPanier.Rows.Cast<DataGridViewRow>().Select(r => Convert.ToDecimal(r.Cells["PrixTotal"].Value)).Sum();

                txtTotalTTC.Text = (coutTransport + totalArticles).ToString();
            }
            catch(Exception)
            {
                return;
            }

        }

        private bool ControlData()
        {
            if (txtFournisseur.SelectedIndex < 0)
            {
                CustomMethods.DisplayError("Veuillez attribuer la commande à un fournisseur.");
                return false;
            }

            if (dgvPanier.Rows.Count < 1)
            {
                CustomMethods.DisplayError("Veuillez ajouter des articles à la commande.");
                return false;
            }

            return true;
        }

        #endregion

        #region Other Methods

        #endregion

        #region Private classes

        private class PageInfo
        {
            public string? IDFournisseur { get; set; }
            public string? DateCommande { get; set; }
            public string? TypeCommande { get; set; }
            public string? Statut { get; set; }
            public decimal? CoutTransport { get; set; }
        }

        private class ArticleInfo
        {
            public string? IDFournisseur { get; set; }
            public string? IDArticle { get; set; }
            public string? Reference { get; set; }
            public string? Nom { get; set; }
            public string? Annee { get; set; }
            public decimal? PrixAchat { get; set; }
        }

        #endregion
    }
}
