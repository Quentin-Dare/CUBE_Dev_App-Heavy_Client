using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using System.Data;

namespace Gestion_stock.Forms.FormNewItem
{
    public partial class NewArticle : Form, IPageNegosud
    {
        #region Private Variables

        // Infos de base
        private string formTitle = "Nouvel article";
        private string tabID = "NewArticle";

        // Données de l'item
        private PageInfo newArticle;

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

        public NewArticle()
        {
            InitializeComponent();
            Initialize.Design(this);
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            newArticle = new PageInfo();

            // Récupération des familles de vin
            listeFamillesDeVin = DataUtils.GetWineFamiliesName();

            // Récupération des fournisseurs
            listeNomFournisseurs = DataUtils.GetSuppliersName();

            // Remplissage des données des combobox
            FillComboBoxData();

            AddEvents();
            ResetPageInfo();
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

        private void ResetPageInfo()
        {
            txtReference.Text = null;
            txtNom.Text = null;
            txtFournisseur.Text = null;
            txtFamille.Text = null;
            txtAnnee.Text = null;
            txtDescription.Text = null;
            txtPrixTTC.Text = null;
            txtPrixAchat.Text = null;
            txtTVA.Text = null;
            txtQuantite.Text = null;
            txtQuantiteMin.Text = null;
            txtImageLink.Text = null;
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
                ResetPageInfo();
                RemoveErrors();
            }
        }

        #endregion

        #region Requests

        #endregion

        #region Save Data Methods

        /// <summary>
        /// Contrôle les données de la page et met en erreur les champs non-valides
        /// </summary>
        /// <returns></returns>
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
            controlsToCheck.Remove(this.txtImageLink);

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

        /// <summary>
        /// Contrôle les données d'une liste de contrôles
        /// </summary>
        /// <param name="controlsToCheck"></param>
        /// <returns></returns>
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
            newArticle.Reference = txtReference.Text;
            newArticle.Nom = txtNom.Text;
            newArticle.IDFournisseur = GetFournisseurID();
            newArticle.IDFamilleDeVin = GetFamilleDeVinID();
            newArticle.Annee = Convert.ToInt32(txtAnnee.Text);
            newArticle.Description = txtDescription.Text;
            newArticle.PrixTTC = Convert.ToDecimal(txtPrixTTC.Text);
            newArticle.PrixAchat = Convert.ToDecimal(txtPrixAchat.Text);
            newArticle.TVA = Convert.ToDecimal(txtTVA.Text);
            newArticle.Quantite = Convert.ToInt32(txtQuantite.Text);
            newArticle.QuantiteMin = Convert.ToInt32(txtQuantiteMin.Text);
        }

        #endregion

        #region Foreign Keys Methods

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
            public string? ImageLink { get; set; }
        }

        #endregion
    }
}
