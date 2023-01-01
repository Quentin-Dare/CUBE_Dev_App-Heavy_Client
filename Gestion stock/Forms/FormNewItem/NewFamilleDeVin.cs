using Gestion_stock.Forms.FormLists;
using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using System.Data;
using System.Windows.Forms;

namespace Gestion_stock.Forms.FormNewItem
{
    public partial class NewFamilleDeVin : Form, IPageNegosud
    {
        #region Private Variables

        // Infos de base
        private string formTitle = "Nouvelle famille de vin";
        private string tabID = "NewFamilleDeVin";

        // Données de l'item
        private PageInfo newFamilleDeVin;

        // Données parallèles
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

        public NewFamilleDeVin()
        {
            InitializeComponent();
            Initialize.Design(this);
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            newFamilleDeVin = new PageInfo();

            // Récupération des familles de vin
            listeFamillesDeVin = DataUtils.GetWineFamiliesName();

            ResetPageInfo();
        }

        #region Constructor Methods

        private void ResetPageInfo()
        {
            txtNom.Text = null;
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

        /// <summary>
        /// Contrôle les données de la page et met en erreur les champs non-valides
        /// </summary>
        /// <returns></returns>
        private bool IsDataValid()
        {
            RemoveErrors();

            // Contrôle des textbox
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                this.errorProvider.SetError(txtNom, "La valeur du champ n'est pas valide.");
                return false;
            }

            if (FamilleDeVinNameExists())
            {
                this.errorProvider.SetError(txtNom, "Ce nom est déjà utilisé.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Enregistre les valeurs dans l'objet
        /// </summary>
        private void UpdateValues()
        {
            newFamilleDeVin.Nom = txtNom.Text;
        }

        /// <summary>
        /// Détecte si le nom rentré existe déjà
        /// </summary>
        /// <returns></returns>
        private bool FamilleDeVinNameExists()
        {
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                return false;
            }

            int namesCount = listeFamillesDeVin.Where(f => f.Nom == txtNom.Text).Count();

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
            public string? IDFamilleDeVin { get; set; }
            public string? Nom { get; set; }
        }

        #endregion
    }
}
