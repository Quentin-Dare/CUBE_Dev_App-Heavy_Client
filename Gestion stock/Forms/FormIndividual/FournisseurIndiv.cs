using Gestion_stock.Forms.FormLists;
using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using System.Data;

namespace Gestion_stock.Forms.FormIndividual
{
    public partial class FournisseurIndiv : Form, IPageNegosud
    {
        #region Private Variables

        // Infos de base
        private string formTitle = string.Empty;
        private string tabID = string.Empty;

        // ID et données de l'article
        private string IDFournisseur;
        private PageInfo fournisseur;

        // Données parallèles
        private List<FournisseurInfo> listeNomFournisseurs;

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

        public FournisseurIndiv(string IDFournisseur)
        {
            InitializeComponent();
            Initialize.Design(this);
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            this.IDFournisseur = IDFournisseur;
            fournisseur = new PageInfo();

            // Récupération des fournisseurs
            listeNomFournisseurs = DataUtils.GetSuppliersName();

            InitializeItemData();
        }

        #region Constructor Methods

        private void GetPageInfo()
        {
            PageInfo? queryResult = GetItemData();

            if (queryResult is null)
            {
                CustomMethods.DisplayError("Erreur, aucun fournisseur trouvé.");
            }
            else
            {
                fournisseur = queryResult;
            }
        }

        private void InitializeItemData()
        {
            GetPageInfo();

            if (fournisseur != null)
            {
                FormTitle = string.Format("Fournisseur {0}", fournisseur.Nom);
                tabID = "Fournisseur" + IDFournisseur;
                WritePageInfo();
            }
            else
            {
                CustomMethods.DisplayError("Page inconnue !");
            }
        }

        private void WritePageInfo()
        {
            txtID.Text = fournisseur.IDFournisseur;
            txtNom.Text = fournisseur.Nom;
            txtEmail.Text = fournisseur.Email;
            txtAdresse.Text = fournisseur.Adresse;
            txtCodePostal.Text = fournisseur.CodePostal;
            txtVille.Text = fournisseur.Ville;
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

        private void ListeArticlesLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string? idFournisseur = IDFournisseur;
            string? fournisseurName = fournisseur.Nom;

            if (idFournisseur is null
                || fournisseurName is null)
            {
                CustomMethods.DisplayError("Fournisseur non-défini");
                return;
            }

            if (this.TopLevelControl is not NegoSUD negoSUD)
            {
                CustomMethods.DisplayError("Page principale innaccessible.");
                return;
            }

            negoSUD.AddTabIfNotExists(new Articles(idFournisseur, fournisseurName));
        }

        #endregion

        #region Requests

        private PageInfo? GetItemData()
        {
            IEnumerable<PageInfo> pageInfos =
            from fournisseurs in Tables.Fournisseurs.AsEnumerable()
            where IDFournisseur == (string)fournisseurs["IDFournisseur"]
            select new PageInfo
            {
                IDFournisseur = Convert.ToString(fournisseurs["IDFournisseur"]),
                Nom = Convert.ToString(fournisseurs["Nom"]),
                Email = Convert.ToString(fournisseurs["Email"]),
                Adresse = Convert.ToString(fournisseurs["Adresse"]),
                CodePostal = Convert.ToString(fournisseurs["CodePostal"]),
                Ville = Convert.ToString(fournisseurs["Ville"]),
            };

            return pageInfos.FirstOrDefault();
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
            controlsToCheck = this.pnlLeftData.Controls.Cast<Control>().Where(c => c is TextBox).ToList();

            // Contrôle des données
            if (!CheckControlsValue(controlsToCheck))
            {
                isDataValid = false;
            }

            if (FournisseurNameExists())
            {
                this.errorProvider.SetError(txtNom, "Ce nom est déjà utilisé.");
                isDataValid = false;
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
            }

            return dataValidity;
        }

        /// <summary>
        /// Enregistre les valeurs dans l'objet
        /// </summary>
        private void UpdateValues()
        {
            fournisseur.Nom = txtNom.Text;
            fournisseur.Email = txtEmail.Text;
            fournisseur.Adresse = txtAdresse.Text;
            fournisseur.CodePostal = txtCodePostal.Text;
            fournisseur.Ville = txtVille.Text;
        }

        /// <summary>
        /// Détecte si le nom rentré existe déjà
        /// </summary>
        /// <returns></returns>
        private bool FournisseurNameExists()
        {
            if (string.IsNullOrEmpty(txtNom.Text)
                || txtNom.Text == fournisseur.Nom)
            {
                return false;
            }

            int namesCount = listeNomFournisseurs.Where(f => f.Nom == txtNom.Text).Count();

            // Si il existe déjà un nom similaire, return true;
            if (namesCount > 0)
            {
                return true;
            }

            return false;
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
            public string? IDFournisseur { get; set; }
            public string? Nom { get; set; }
            public string? Email { get; set; }
            public string? Adresse { get; set; }
            public string? CodePostal { get; set; }
            public string? Ville { get; set; }
        }

        #endregion
    }
}
