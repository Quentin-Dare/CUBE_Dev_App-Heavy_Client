using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using System.Data;

namespace Gestion_stock.Forms.FormNewItem
{
    public partial class NewFournisseur : Form, IPageNegosud
    {
        #region Private Variables

        // Infos de base
        private string formTitle = "Nouveau fournisseur";
        private string tabID = "Fournisseur";

        // ID et données de l'article
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

        public NewFournisseur()
        {
            InitializeComponent();
            Initialize.Design(this);
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            fournisseur = new PageInfo();

            // Récupération des fournisseurs
            listeNomFournisseurs = DataUtils.GetSuppliersName();

            ResetPageInfo();
        }

        #region Constructor Methods

        private void ResetPageInfo()
        {
            txtNom.Text = null;
            txtEmail.Text = null;
            txtAdresse.Text = null;
            txtCodePostal.Text = null;
            txtVille.Text = null;
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
                ResetPageInfo();
                RemoveErrors();
            }
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
            if (string.IsNullOrEmpty(txtNom.Text))
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
