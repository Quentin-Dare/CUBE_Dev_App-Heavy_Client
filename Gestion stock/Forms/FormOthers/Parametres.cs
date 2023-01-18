using Gestion_stock.NegosudData;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;

namespace Gestion_stock.Forms.FormOthers
{
    public partial class Parametres : Form, IPageNegosud
    {
        #region Private Variables

        // Infos de base
        private string formTitle = "Paramètres";
        private string tabID = "parametres";

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

        public Parametres()
        {
            InitializeComponent();
            Initialize.Design(this);
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            if (string.IsNullOrEmpty(DataUtils.Password))
            {
                txtAncienMdp.Enabled = false;
            }

            ResetPageInfo();
        }

        #region Constructor Methods

        private void ResetPageInfo()
        {
            txtAncienMdp.Text = null;
            txtNouveauMdp.Text = null;
            txtConfirmMdp.Text = null;
        }

        #endregion

        #endregion

        #region Events

        private void SaveMdp(object sender, EventArgs e)
        {
            if (!CustomMethods.ConfirmDataSave())
            {
                return;
            }

            if (IsDataValid())
            {
                MessageBox.Show("Bon bah code fdp");
            }
        }

        #endregion

        #region Save Data Methods

        private bool IsDataValid()
        {
            RemoveErrors();

            if (txtAncienMdp.Enabled
                && txtAncienMdp.Text != DataUtils.Password)
            {
                errorProvider.SetError(txtAncienMdp, "Mot de passe incorrect");
                return false;
            }

            if (txtNouveauMdp.Text != txtConfirmMdp.Text)
            {
                errorProvider.SetError(txtConfirmMdp, "Mot de passe différent du premier.");
                return false;
            }

            if (txtNouveauMdp.Text == txtAncienMdp.Text)
            {
                errorProvider.SetError(txtNouveauMdp, "Vous ne pouvez pas mettre un mot de passe identique à l'ancien.");
                return false;
            }

            return true;
        }

        #endregion

        #region Other Methods

        private void RemoveErrors()
        {
            errorProvider.Clear();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        #endregion
    }
}
