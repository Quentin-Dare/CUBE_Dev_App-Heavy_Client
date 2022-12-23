using Gestion_stock.Forms.FormLists.Model;
using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using Gestion_stock.Utils.CustomControls;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Gestion_stock.Forms.FormIndividual
{
    public partial class CommandeFournisseurIndiv : Form, IPageNegosud
    {
        #region Private Variables

        // Infos de base
        private string formTitle = string.Empty;
        private string tabID = string.Empty;

        // ID et données de la commande
        private string IDCommande;
        private PageInfo commande;
        private List<GridViewInfo> articlesList = new List<GridViewInfo>();

        // Autres données
        private int selectedArticle;

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

        public CommandeFournisseurIndiv(string IDCommande)
        {
            InitializeComponent();
            Initialize.Design(this);
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            this.IDCommande = IDCommande;
            commande = new PageInfo();

            InitializeItemData();
        }

        #region Constructor Methods

        private void InitializeItemData()
        {
            GetPageInfo();

            if (commande != null)
            {
                FormTitle = "Commande " + IDCommande;
                tabID = "Commande" + IDCommande;
                WritePageInfo();
            }
            else
            {
                CustomMethods.DisplayError("Page inconnue !");
            }

            InitializeGridView();

            AddExtraCalculs();

            AddDesignDetails();
        }

        private void GetPageInfo()
        {
            PageInfo? queryResult = GetEnteteData();

            if (queryResult is null)
            {
                CustomMethods.DisplayError("Erreur, aucune commande trouvée.");
            }
            else
            {
                commande = queryResult;
            }
        }

        private void WritePageInfo()
        {
            txtIDCommande.Text = commande.IDCommande;
            txtDateCommande.Text = commande.DateCommande;
            txtIDFournisseur.Text = commande.IDFournisseur;
            txtNomFournisseur.Text = commande.NomFournisseur;
            txtTypeCommande.Text = commande.TypeCommande;
            txtCoutTransport.Text = commande.CoutTransport.ToString();

            if (commande.Statut == DataUtils.EnCoursStatus)
            {
                SetStatusEncours();
            }
            else
            {
                SetStatusClos();
            }
        }

        private void InitializeGridView()
        {
            articlesList = GetGridViewDatasource();
            selectedArticle = 0;

            this.dgvPanier.Columns.Clear();
            this.dgvPanier.AutoGenerateColumns = true;
            this.dgvPanier.AutoSize = true;

            this.dgvPanier.DataSource = articlesList;

            this.dgvPanier.Columns[0].Visible = false;

            this.cbFieldFilter.Items.Clear();

            // Initialisation du design des colonnes
            ColumnGridDesign[] columnDesign =
            {
                new ("Référence", 100, 'L'),
                new ("Nom", 200, 'L'),
                new ("Année", 100, 'R'),
                new ("Prix d'achat (€)", 100, 'R'),
                new ("Quantité", 100, 'R'),
                new ("Total TTC (€)", 100, 'R'),
            };

            // Ajout de chaque propriété de design à chaque colonne
            for (int i = 0; i < columnDesign.Length; i++)
            {
                int columnIndex = i + 1;

                dgvPanier.Columns[columnIndex].HeaderText = columnDesign[i].Name;
                dgvPanier.Columns[columnIndex].Width = columnDesign[i].ColumnWidth;
                if (columnDesign[i].TextAlignement == 'R')
                {
                    dgvPanier.Columns[columnIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                this.cbFieldFilter.Items.Add(columnDesign[i].Name);
            }
        }

        private void AddExtraCalculs()
        {
            decimal totalTTC = dgvPanier.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells["TotalTTC"].Value));

            if (commande.CoutTransport is decimal coutTransport)
            {
                totalTTC += coutTransport;
            }

            this.txtTotalTTC.Text = totalTTC.ToString();
        }

        private void AddDesignDetails()
        {
            pnlTableContainer.AutoScroll = false;
            pnlTableContainer.VerticalScroll.Enabled = false;
            pnlTableContainer.VerticalScroll.Visible = false;
            pnlTableContainer.VerticalScroll.Maximum = 0;
            pnlTableContainer.AutoScroll = true;
        }


        #endregion

        #endregion

        #region Events

        private void ArticleCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            // Si l'utilisateur a cliqué sur le header
            if (rowIndex == -1)
            {
                return;
            }

            // Si la cellule cliquée n'est pas la cellule déjà sélectionnée
            if (rowIndex != selectedArticle)
            {
                selectedArticle = rowIndex;
            }
            else
            {
                // Ouverture de la page individuelle
                // On sélectionne l'id de la ligne sélectionnée (toujours la première colonne du tableau)
                string? rowID = dgvPanier.Rows[rowIndex].Cells[0].Value.ToString();

                if (rowID == null)
                {
                    CustomMethods.DisplayError("Erreur, pas d'ID");
                    return;
                }

                Form article = new ArticleIndiv(rowID);

                // Ouverture de la page
                if (this.TopLevelControl is NegoSUD topLevel)
                {
                    topLevel.AddTabIfNotExists(article);
                }
            }
        }

        private void ClosePage(object sender, EventArgs e)
        {
            if (!CustomMethods.ConfirmCloseCommand())
            {
                return;
            }
            SetStatusClos();

            MessageBox.Show("Bon bah code fdp");
        }

        private void ReloadPage(object sender, EventArgs e)
        {
            if (!CustomMethods.ConfirmCancelCommand())
            {
                return;
            }

            SetStatusClos();

            MessageBox.Show("Bon bah code fdp");
        }

        private void FournisseurLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.TopLevelControl is not NegoSUD negoSUD)
            {
                CustomMethods.DisplayError("Page principale inaccessible");
                return;
            }

            string? idFournisseur = commande.IDFournisseur;

            if (idFournisseur is not null)
            {
                negoSUD.AddTabIfNotExists(new FournisseurIndiv(idFournisseur));
            }
            else
            {
                CustomMethods.DisplayError("Identifiant du fournisseur vide");
                return;
            }
        }

        #endregion

        #region Requests

        private PageInfo? GetEnteteData()
        {
            IEnumerable<PageInfo> enteteData =
            from commandesFournisseur in Tables.CommandesFournisseur.AsEnumerable()
            join fournisseurs in Tables.Fournisseurs.AsEnumerable()
                on commandesFournisseur["IDFournisseur"] equals fournisseurs["IDFournisseur"]
            where IDCommande == (string)commandesFournisseur["IDCommandeFournisseur"]
            select new PageInfo
            {
                IDCommande = Convert.ToString(commandesFournisseur["IDCommandeFournisseur"]),
                IDFournisseur = Convert.ToString(commandesFournisseur["IDFournisseur"]),
                NomFournisseur = Convert.ToString(fournisseurs["Nom"]),
                DateCommande = Convert.ToDateTime(commandesFournisseur["DateCommande"]).ToString("dd/MM/yyyy hh:mm"),
                Statut = Convert.ToString(commandesFournisseur["Statut"]),
                TypeCommande = Convert.ToString(commandesFournisseur["TypeCommande"]),
                CoutTransport = Convert.ToDecimal(commandesFournisseur["CoutTransport"]),
            };

            return enteteData.FirstOrDefault();
        }

        private List<GridViewInfo> GetGridViewDatasource()
        {
            IEnumerable<GridViewInfo> datasource =
            from commandesFournisseurListe in Tables.CommandesFournisseurListe.AsEnumerable()
            join articles in Tables.Articles.AsEnumerable()
                on commandesFournisseurListe["IDArticle"] equals articles["IDArticle"]
            where IDCommande == (string)commandesFournisseurListe["IDCommandeFournisseur"]
            select new GridViewInfo
            {
                IDArticle = Convert.ToString(commandesFournisseurListe["IDArticle"]),
                Reference = Convert.ToString(articles["Reference"]),
                Nom = Convert.ToString(articles["Nom"]),
                Annee = Convert.ToString(articles["Annee"]),
                PrixAchat = Convert.ToDecimal(articles["PrixAchat"]),
                Quantite = Convert.ToInt32(commandesFournisseurListe["Quantite"]),
                TotalTTC = Math.Round(Convert.ToDecimal(articles["PrixAchat"]) * Convert.ToInt32(commandesFournisseurListe["Quantite"]), 2)
            };

            return datasource.ToList();
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

            if (dgvPanier.CurrentCell != null)
            {
                selectedArticle = dgvPanier.CurrentCell.RowIndex;
            }
            else
            {
                selectedArticle = -1;
            }

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

        private void SetStatusEncours()
        {
            txtStatut.Text = DataUtils.EnCoursStatus;
            txtStatut.BackColor = Color.Gold;
            txtStatut.ForeColor = Color.Black;
        }

        private void SetStatusClos()
        {
            txtStatut.Text = DataUtils.ClosStatus;
            txtStatut.BackColor = Color.RoyalBlue;
            txtStatut.ForeColor = Color.White;
            btnCancel.Visible = false;
            btnClose.Visible = false;
        }

        #endregion

        #region Private classes

        private class PageInfo
        {
            public string? IDCommande { get; set; }
            public string? IDFournisseur { get; set; }
            public string? NomFournisseur { get; set; }
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
