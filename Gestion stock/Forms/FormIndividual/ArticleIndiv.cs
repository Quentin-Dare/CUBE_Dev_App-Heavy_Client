using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using System.Data;

namespace Gestion_stock.Forms.FormIndividual
{
    public partial class ArticleIndiv : Form, IPageNegosud
    {
        #region Private Variables

        // Infos de base
        private string formTitle = string.Empty;
        private string tabID = string.Empty;

        // ID et données de l'article
        private string IDArticle;
        private PageInfo article;

        // Données parallèles
        private List<FournisseurInfo> listeNomFournisseurs;
        private List<FamilleDeVinInfo> listeFamillesDeVin;

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

        public ArticleIndiv(string IDArticle)
        {
            InitializeComponent();
            Initialize.Design(this);
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            this.IDArticle = IDArticle;
            article = new PageInfo();

            // Récupération des familles de vin
            listeFamillesDeVin = DataUtils.GetWineFamiliesName();

            // Récupération des fournisseurs
            listeNomFournisseurs = DataUtils.GetSuppliersName();

            // Remplissage des données des combobox
            FillComboBoxData();

            InitializeItemData();

            AddEvents();
        }

        #region Constructor Methods

        private void FillComboBoxData()
        {
            foreach (FamilleDeVinInfo famille in listeFamillesDeVin)
            {
                txtFamille.Items.Add(famille.Nom);
            }

            foreach (FournisseurInfo fournisseur in listeNomFournisseurs)
            {
                txtFournisseur.Items.Add(fournisseur.Nom);
            }
        }

        private void InitializeItemData()
        {
            GetPageInfo();

            if (article != null)
            {
                FormTitle = string.IsNullOrEmpty(article.Nom) ? "" : article.Nom;
                tabID = "Article" + IDArticle;
                WritePageInfo();
            }
            else
            {
                CustomMethods.DisplayError("Page inconnue !");
            }
        }

        private void GetPageInfo()
        {
            PageInfo? queryResult = GetItemData();

            if (queryResult is null)
            {
                CustomMethods.DisplayError("Erreur, aucun article trouvé.");
            }
            else
            {
                article = queryResult;
            }
        }

        private void WritePageInfo()
        {
            txtReference.Text = article.Reference;
            txtNom.Text = article.Nom;
            txtFournisseur.Text = GetFournisseurName();
            txtFamille.Text = GetFamilleDeVinName();
            txtAnnee.Text = article.Annee.ToString();
            txtDescription.Text = article.Description;
            txtPrixTTC.Text = article.PrixTTC.ToString();
            txtPrixAchat.Text = article.PrixAchat.ToString();
            txtTVA.Text = article.TVA.ToString();
            txtQuantite.Text = article.Quantite.ToString();
            txtQuantiteMin.Text = article.QuantiteMin.ToString();
        }

        /// <summary>
        /// Ajout des évènements custom de la page
        /// </summary>
        private void AddEvents()
        {
            // Evènements pour filter les textbox de chiffres
            this.txtAnnee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CustomEvents.FilterIntegers);
            this.txtPrixTTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CustomEvents.FilterDecimals);
            this.txtPrixAchat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CustomEvents.FilterDecimals);
            this.txtTVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CustomEvents.FilterDecimals);
            this.txtQuantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CustomEvents.FilterIntegers);
            this.txtQuantiteMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CustomEvents.FilterIntegers);
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

            if (IsDataValid())
            {
                UpdateValues();
                MessageBox.Show("Bon bah code fdp");
            }
        }

        private void ReloadPage(object sender, EventArgs e)
        {
            if (CustomMethods.ConfirmDataReload())
            {
                InitializeItemData();
                RemoveErrors();
            }
        }

        private void FournisseurLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int fournisseurIndex = txtFournisseur.SelectedIndex;
            if (fournisseurIndex < 0)
            {
                CustomMethods.DisplayError("Fournisseur non-défini");
                return;
            }
            string? idFournisseur = listeNomFournisseurs[fournisseurIndex].IDFournisseur;

            if (idFournisseur is null)
            {
                CustomMethods.DisplayError("Fournisseur non-défini");
                return;
            }

            if (this.TopLevelControl is not NegoSUD negoSUD)
            {
                CustomMethods.DisplayError("Page principale innaccessible.");
                return;
            }

            negoSUD.AddTabIfNotExists(new FournisseurIndiv(idFournisseur));
        }

        #endregion

        #region Requests

        private PageInfo? GetItemData()
        {
            IEnumerable<PageInfo> articleInfos =
            from articles in Tables.Articles.AsEnumerable()
            where IDArticle == (string)articles["IDArticle"]
            select new PageInfo
            {
                Reference = Convert.ToString(articles["Reference"]),
                Nom = Convert.ToString(articles["Nom"]),
                IDFournisseur = Convert.ToString(articles["IDFournisseur"]),
                IDFamilleDeVin = Convert.ToString(articles["IDFamilleDeVin"]),
                Annee = Convert.ToInt32(articles["Annee"]),
                Description = Convert.ToString(articles["Description"]),
                PrixTTC = Convert.ToDecimal(articles["PrixTTC"]),
                PrixAchat = Convert.ToDecimal(articles["PrixAchat"]),
                TVA = Convert.ToDecimal(articles["TVA"]),
                Quantite = Convert.ToInt32(articles["Quantite"]),
                QuantiteMin = Convert.ToInt32(articles["QuantiteMin"]),
            };

            return articleInfos.FirstOrDefault();
        }

        #endregion

        #region Save Data Methods

        private bool IsDataValid()
        {
            List<Control> controlsToCheck;
            bool isDataValid = true;

            // Suppression des erreurs affichées
            RemoveErrors();

            // Sélection des champs textbox et combobox de la partie gauche
            controlsToCheck = this.pnlLeftData.Controls.Cast<Control>().Where(c => c is TextBox or ComboBox).ToList();

            // Suppression de la liste des champs qu'on ne veut pas contrôler
            controlsToCheck.Remove(this.txtReference);

            // Contrôle des données
            if (!CheckControlsValue(controlsToCheck))
            {
                isDataValid = false;
            }

            // Sélection des champs de la partie droite
            controlsToCheck = this.pnlRightData.Controls.Cast<Control>().Where(c => c is TextBox).ToList();

            if (!CheckControlsValue(controlsToCheck))
            {
                isDataValid = false;
                // Changement de la largeur du panel pour pouvoir afficher le logo erreur
                this.pnlRightData.Width = 270;
            }
            else
            {
                this.pnlRightData.Width = 250;
            }

            return isDataValid;
        }

        private bool CheckControlsValue(List<Control> controlsToCheck)
        {
            bool dataValidity = true;
            foreach (Control control in controlsToCheck)
            {
                // Contrôle des textbox
                if (control is TextBox && string.IsNullOrEmpty(control.Text))
                {
                    this.errorProvider.SetError(control, "La valeur du champ n'est pas valide.");
                    dataValidity = false;
                }

                // Contrôle des combobox
                else if (control is ComboBox combobox && combobox.SelectedItem == null)
                {
                    this.errorProvider.SetError(control, "La valeur du champ n'est pas valide.");
                    dataValidity = false;
                }
            }

            return dataValidity;
        }

        /// <summary>
        /// Enregistre les valeurs dans l'objet
        /// </summary>
        private void UpdateValues()
        {
            article.Reference = txtReference.Text;
            article.Nom = txtNom.Text;
            article.IDFournisseur = GetFournisseurID();
            article.IDFamilleDeVin = GetFamilleDeVinID();
            article.Annee = Convert.ToInt32(txtAnnee.Text);
            article.Description = txtDescription.Text;
            article.PrixTTC = Convert.ToDecimal(txtPrixTTC.Text);
            article.PrixAchat = Convert.ToDecimal(txtPrixAchat.Text);
            article.TVA = Convert.ToDecimal(txtTVA.Text);
            article.Quantite = Convert.ToInt32(txtQuantite.Text);
        }

        #endregion

        #region Foreign Keys Methods

        private string? GetFournisseurName()
        {
            if (article == null
                || string.IsNullOrEmpty(article.IDFournisseur))
            {
                return null;
            }

            FournisseurInfo fournisseur = listeNomFournisseurs.Where(f => f.IDFournisseur == article.IDFournisseur).First();

            return fournisseur.Nom;
        }

        private string? GetFamilleDeVinName()
        {
            if (article == null
                || string.IsNullOrEmpty(article.IDFournisseur))
            {
                return null;
            }

            FamilleDeVinInfo familleDeVin = listeFamillesDeVin.Where(f => f.IDFamilleDeVin == article.IDFamilleDeVin).First();

            return familleDeVin.Nom;
        }

        private string GetFournisseurID()
        {
            // On trouve l'index du combobox sélectionné
            int comboBoxIndex = txtFournisseur.SelectedIndex;

            // Si l'index = -1, alors erreur
            if (comboBoxIndex < 0)
            {
                return Error();
            }

            // Sélection de l'id dans la liste des fournisseur. La liste des fournisseurs
            // est rangée dans le même ordre que la liste du combobox
            string? id = listeNomFournisseurs[comboBoxIndex].IDFournisseur;

            // Si l'id est nul, erreur
            if (id is null)
            {
                return Error();
            }
            else
            {
                return id;
            }

            static string Error()
            {
                CustomMethods.DisplayError("ID du fournisseur introuvable");
                return "";
            }
        }

        private string GetFamilleDeVinID()
        {
            int comboBoxIndex = txtFamille.SelectedIndex;

            if (comboBoxIndex < 0)
            {
                return Error();
            }

            string? id = listeFamillesDeVin[comboBoxIndex].IDFamilleDeVin;

            if (id is null)
            {
                return Error();
            }
            else
            {
                return id;
            }

            static string Error()
            {
                CustomMethods.DisplayError("ID de la famille de vin introuvable");
                return "";
            }
        }

        #endregion

        #region Other Methods

        private void RemoveErrors()
        {
            errorProvider.Clear();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        #endregion

        #region Private classes

        private class PageInfo
        {
            public string? IDArticle { get; set; }
            public string? Reference { get; set; }
            public string? Nom { get; set; }
            public string? IDFournisseur { get; set; }
            public string? IDFamilleDeVin { get; set; }
            public int Annee { get; set; }
            public string? Description { get; set; }
            public decimal PrixTTC { get; set; }
            public decimal PrixAchat { get; set; }
            public decimal TVA { get; set; }
            public int Quantite { get; set; }
            public int QuantiteMin { get; set; }
        }

        #endregion

    }
}
