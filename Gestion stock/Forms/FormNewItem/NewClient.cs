using Gestion_stock.Forms.FormLists;
using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using System.Data;

namespace Gestion_stock.Forms.FormNewItem
{
    public partial class NewClient : Form, IPageNegosud
    {
        #region Private Variables

        // Infos de base
        private string formTitle = string.Empty;
        private string tabID = string.Empty;

        // ID et données de l'article
        private string IDClient;
        private PageInfo client;

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

        public NewClient(string IDArticle)
        {
            InitializeComponent();
            Initialize.Design(this);
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            this.IDClient = IDArticle;
            client = new PageInfo();

            InitializeItemData();
        }

        #region Constructor Methods

        private void GetPageInfo()
        {
            PageInfo? queryResult = GetItemData();

            if (queryResult is null)
            {
                CustomMethods.DisplayError("Erreur, aucun client trouvé.");
            }
            else
            {
                client = queryResult;
            }
        }

        private void InitializeItemData()
        {
            GetPageInfo();

            if (client != null)
            {
                FormTitle = String.Format("Client {0} {1}", client.Nom, client.Prenom);
                tabID = "Client" + IDClient;
                WritePageInfo();
            }
            else
            {
                CustomMethods.DisplayError("Page inconnue !");
            }
        }

        private void WritePageInfo()
        {
            txtID.Text = client.IDClient;
            txtNom.Text = client.Nom;
            txtPrenom.Text = client.Nom;
            txtEmail.Text = client.Email;
            txtAdresse.Text = client.Adresse;
            txtCodePostal.Text = client.CodePostal;
            txtVille.Text = client.Ville;
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

        #endregion

        #region Requests

        private PageInfo? GetItemData()
        {
            IEnumerable<PageInfo> pageInfos =
            from clients in Tables.Clients.AsEnumerable()
            where IDClient == (string)clients["IDFournisseur"]
            select new PageInfo
            {
                Nom = Convert.ToString(clients["Nom"]),
                Prenom = Convert.ToString(clients["Prenom"]),
                Email = Convert.ToString(clients["Email"]),
                Adresse = Convert.ToString(clients["Adresse"]),
                CodePostal = Convert.ToString(clients["CodePostal"]),
                Ville = Convert.ToString(clients["Ville"]),
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
            client.Prenom = txtNom.Text;
            client.Nom = txtNom.Text;
            client.Email = txtEmail.Text;
            client.Adresse = txtAdresse.Text;
            client.CodePostal = txtCodePostal.Text;
            client.Ville = txtVille.Text;
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
            public string? IDClient { get; set; }
            public string? Nom { get; set; }
            public string? Prenom { get; set; }
            public string? Email { get; set; }
            public string? Adresse { get; set; }
            public string? CodePostal { get; set; }
            public string? Ville { get; set; }
        }

        #endregion
    }
}
