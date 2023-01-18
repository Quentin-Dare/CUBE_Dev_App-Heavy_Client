using Gestion_stock.Forms.FormLists;
using Gestion_stock.Forms.FormOthers;
using Gestion_stock.NegosudData.Interfaces;
using Gestion_stock.Utils;
using Gestion_stock.Utils.CustomControls;

namespace Gestion_stock
{
    public partial class NegoSUD : Form
    {
        public NegoSUD()
        {
            InitializeComponent();
            Initialize.Design(this);
            flpTabContainer.Controls.Clear();
            formList = new List<Form>();
            currentForm = -1;
        }

        #region Data

        private int currentForm;
        private List<Form> formList;

        #endregion

        #region Hover Events

        private void OnMouseEnterRed(object sender, EventArgs e)
        {
            CustomEvents.OnMouseEnterRed(sender);
        }

        private void OnMouseLeaveRed(object sender, EventArgs e)
        {
            CustomEvents.OnMouseLeaveRed(sender);
        }

        private void OnMouseEnterDarkRed(object sender, EventArgs e)
        {
            CustomEvents.OnMouseEnterDarkRed(sender);
        }

        private void OnMouseLeaveDarkRed(object sender, EventArgs e)
        {
            CustomEvents.OnMouseLeaveDarkRed(sender);
        }
        private void OnMouseEnterOpenMenuBtn(object sender, EventArgs e)
        {
            CustomEvents.OnMouseEnterGrayBackground(this.pnlOpenMenu);
        }
        private void OnMouseLeaveOpenMenuBtn(object sender, EventArgs e)
        {
            CustomEvents.OnMouseLeaveGrayBackground(this.pnlOpenMenu);
        }

        #endregion

        #region Menu Events

        private void lbArticles_Click(object sender, EventArgs e)
        {
            AddTabIfNotExists(new Articles());
        }

        private void lbCmdClients_Click(object sender, EventArgs e)
        {
            AddTabIfNotExists(new CommandesClient());
        }

        private void lbCmdFournisseurs_Click(object sender, EventArgs e)
        {
            AddTabIfNotExists(new CommandesFournisseur());
        }

        private void lbClients_Click(object sender, EventArgs e)
        {
            AddTabIfNotExists(new Clients());
        }

        private void lbFournisseurs_Click(object sender, EventArgs e)
        {
            AddTabIfNotExists(new Fournisseurs());
        }

        private void lbFamillesVin_Click(object sender, EventArgs e)
        {
            AddTabIfNotExists(new FamillesDeVin());
        }

        private void lbParametres_Click(object sender, EventArgs e)
        {
            AddTabIfNotExists(new Parametres());
        }

        #endregion

        #region Other Events

        private void lbHideMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlOpenMenu.Visible = true;
            UpdateTabZoneHeight();
        }

        private void pnlOpenMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = true;
            pnlOpenMenu.Visible = false;
            UpdateTabZoneHeight();
        }

        private void flpTabContainer_SizeChanged(object sender, EventArgs e)
        {
            UpdateTabZoneHeight();
        }

        private void NegoSUD_SizeChanged(object sender, EventArgs e)
        {
            UpdateTabZoneHeight();
        }

        #endregion

        #region Manage Tabs

        /// <summary>
        /// Ajoute un onglet o� s�lectionne celui-ci s'il existe d�j�
        /// </summary>
        /// <param name="tabName">Nom de l'onglet</param>
        /// <param name="form">Page correspondante</param>
        public void AddTabIfNotExists(Form form)
        {
            if (form is not IPageNegosud pageNegosud)
            {
                return;
            }
            // Recherche de l'existence d'un onglet
            int tabIndex = GetTabIndex(pageNegosud.TabID);

            // Si l'onglet n'existe pas, alors on le cr�e
            if (tabIndex == -1)
            {
                AddTab(form, pageNegosud.FormTitle);
            }

            // Sinon on change juste d'onglet
            else
            {
                OpenTab(tabIndex);
            }
        }

        public void AddTabForce(Form form)
        {
            if (form is not IPageNegosud pageNegosud)
            {
                return;
            }

            string tabName = pageNegosud.FormTitle;
            if (GetTabIndex(pageNegosud.TabID) != -1)
            {
                int tabNumber = 1;
                string newTabID = pageNegosud.TabID + tabNumber.ToString();

                while (GetTabIndex(newTabID) != -1)
                {
                    tabNumber++;
                    newTabID = pageNegosud.TabID + "_" + tabNumber;
                }

                pageNegosud.TabID = newTabID;
                tabName = tabName + "  (" + tabNumber + ")";
            }

            AddTab(form, tabName);
        }

        /// <summary>
        /// Ajoute un onglet
        /// </summary>
        /// <param name="tabName"></param>
        /// <param name="form"></param>
        public void AddTab(Form form, string tabName)
        {
            if (form is not IPageNegosud pageNegosud)
            {
                return;
            }

            flpTabContainer.Controls.Add(new CustomTab(pageNegosud.TabID, tabName));
            formList.Add(form);
            OpenTab(formList.Count - 1);
        }

        public void OpenTab(int newTabIndex)
        {
            // Si un onglet �tait d�j� ouvert, on le ferme
            if (currentForm != -1)
            {
                flpTabContainer.Controls[currentForm].BackColor = CustomColors.TabColor;
                pnlFormContainer.Controls.Remove(formList[currentForm]);
            }

            // Ouverture du nouvel onglet
            flpTabContainer.Controls[newTabIndex].BackColor = CustomColors.WhiteBackground;
            pnlFormContainer.Controls.Add(formList[newTabIndex]);
            formList[newTabIndex].Show();

            currentForm = newTabIndex;
        }

        public int GetTabIndex(string tabID)
        {
            // Retourne l'index de l'onglet, ou -1 si aucun onglet ne poss�de l'ID
            return flpTabContainer.Controls.IndexOfKey(tabID);
        }

        public void CloseTab(int tabIndex)
        {
            // Si l'onglet � fermer est sup�rieur au nombre d'onglets ou �gal � -1, on ne fait rien
            if (tabIndex == -1
                || tabIndex >= flpTabContainer.Controls.Count)
            {
                return;
            }

            if (tabIndex == currentForm)
            {
                // Fermeture de la page et currentForm = -1 pour dire qu'aucun onglet n'est ouvert
                flpTabContainer.Controls.RemoveAt(tabIndex);
                pnlFormContainer.Controls.Remove(formList[currentForm]);
                formList.RemoveAt(tabIndex);
                currentForm = -1;

                // Changement d'onglet s'il y en a d'autres
                if (flpTabContainer.Controls.Count > 0)
                {
                    // S�lection de l'onglet suivant l'onglet actuel
                    if (tabIndex == flpTabContainer.Controls.Count)
                    {
                        tabIndex--;
                    }

                    OpenTab(tabIndex);
                }
            }
            else
            {
                // Suppression de l'onglet
                flpTabContainer.Controls.RemoveAt(tabIndex);
                formList.RemoveAt(tabIndex);

                // Si l'onglet supprim� se trouvait avant l'onglet ouvert dans la liste
                if (currentForm > tabIndex)
                {
                    currentForm--;
                }
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Change la hauteur du menu des tabs lorsque la scrollbar appara�t
        /// </summary>
        private void UpdateTabZoneHeight()
        {
            if (flpTabContainer.Width > pnlFLPContainer.Width)
            {
                pnlFLPContainer.Height = flpTabContainer.Height + 17; // 17 = hauteur de la scrollbar
            }
            else
            {
                pnlFLPContainer.Height = flpTabContainer.Height;
            }
        }

        #endregion
    }
}