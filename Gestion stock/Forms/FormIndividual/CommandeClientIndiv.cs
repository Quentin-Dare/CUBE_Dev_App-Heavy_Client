using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using Gestion_stock.Utils.CustomControls;
using System.Data;

namespace Gestion_stock.Forms.FormIndividual
{
    public partial class CommandeClientIndiv : Form, IPageNegosud
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

        public CommandeClientIndiv(string IDArticle)
        {
            InitializeComponent();
            Initialize.Design(this);
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            this.IDCommande = IDArticle;
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
            txtIDClient.Text = commande.IDClient;
            txtNomClient.Text = commande.NomClient;
            txtPrenomClient.Text = commande.PrenomClient;

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
                new ("Domaine", 200, 'L'),
                new ("Prix TTC unitaire (€)", 100, 'R'),
                new ("TVA (%)", 100, 'R'),
                new ("Quantité", 100, 'R'),
                new ("Total HT (€)", 100, 'R'),
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
            decimal totalHT = dgvPanier.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells["TotalHT"].Value));
            decimal totalTTC = dgvPanier.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells["TotalTTC"].Value));

            this.txtTotalHT.Text = totalHT.ToString();
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

        private void ClientLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.TopLevelControl is not NegoSUD negoSUD)
            {
                CustomMethods.DisplayError("Page principale inaccessible");
                return;
            }

            string? idClient = commande.IDClient;

            if (idClient is not null)
            {
                negoSUD.AddTabIfNotExists(new ClientIndiv(idClient));
            }
            else
            {
                CustomMethods.DisplayError("Identifiant du client vide");
                return;
            }
        }

        #endregion

        #region Requests

        private PageInfo? GetEnteteData()
        {
            IEnumerable<PageInfo> enteteData =
            from commandesClient in Tables.CommandesClient.AsEnumerable()
            join clients in Tables.Clients.AsEnumerable()
                on commandesClient["IDClient"] equals clients["IDClient"]
            where IDCommande == (string)commandesClient["IDCommandeClient"]
            select new PageInfo
            {
                IDCommande = Convert.ToString(commandesClient["IDCommandeClient"]),
                IDClient = Convert.ToString(commandesClient["IDClient"]),
                NomClient = Convert.ToString(clients["Nom"]),
                PrenomClient = Convert.ToString(clients["Prenom"]),
                DateCommande = Convert.ToDateTime(commandesClient["DateCommande"]).ToString("dd/MM/yyyy hh:mm"),
                Statut = Convert.ToString(commandesClient["Statut"]),
            };

            return enteteData.FirstOrDefault();
        }

        private List<GridViewInfo> GetGridViewDatasource()
        {
            IEnumerable<GridViewInfo> datasource =
            from commandesClientListe in Tables.CommandesClientListe.AsEnumerable()
            join articles in Tables.Articles.AsEnumerable()
                on commandesClientListe["IDArticle"] equals articles["IDArticle"]
            join fournisseurs in Tables.Fournisseurs.AsEnumerable()
                on articles["IDFournisseur"] equals fournisseurs["IDFournisseur"]
            where IDCommande == (string)commandesClientListe["IDCommandeClient"]
            select new GridViewInfo
            {
                IDArticle = Convert.ToString(commandesClientListe["IDArticle"]),
                Reference = Convert.ToString(articles["Reference"]),
                Nom = Convert.ToString(articles["Nom"]),
                Domaine = Convert.ToString(fournisseurs["Nom"]),
                PrixTTC = Convert.ToDecimal(articles["PrixTTC"]),
                TVA = Convert.ToDecimal(articles["TVA"]),
                Quantite = Convert.ToInt32(commandesClientListe["Quantite"]),
                TotalHT = Math.Round((Convert.ToDecimal(articles["PrixTTC"]) * 100 / (100 + Convert.ToDecimal(articles["TVA"]))) * Convert.ToInt32(commandesClientListe["Quantite"]), 2),
                TotalTTC = Math.Round(Convert.ToDecimal(articles["PrixTTC"]) * Convert.ToInt32(commandesClientListe["Quantite"]), 2)
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
            public string? IDClient { get; set; }
            public string? NomClient { get; set; }
            public string? PrenomClient { get; set; }
            public string? DateCommande { get; set; }
            public string? Statut { get; set; }
        }

        private class GridViewInfo
        {
            public string? IDArticle { get; set; }
            public string? Reference { get; set; }
            public string? Nom { get; set; }
            public string? Domaine { get; set; }
            public decimal? PrixTTC { get; set; }
            public decimal? TVA { get; set; }
            public int? Quantite { get; set; }
            public decimal? TotalHT { get; set; }
            public decimal? TotalTTC { get; set; }
        }

        #endregion
    }
}
