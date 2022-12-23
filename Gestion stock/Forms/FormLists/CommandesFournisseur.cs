using Gestion_stock.Forms.FormIndividual;
using Gestion_stock.Forms.FormLists.Model;
using Gestion_stock.Forms.FormNewItem;
using Gestion_stock.NegosudData;
using Gestion_stock.Utils.CustomControls;
using System.Data;

namespace Gestion_stock.Forms.FormLists
{
    public class CommandesFournisseur : DefaultForm
    {
        #region Variables

        private string formTitle = "Commandes fournisseurs";
        private string tabID = "CommandesFournisseur";
        private bool showAddButton = true;
        private string addButtonName = "Nouvelle commande";
        private bool hideFirstColumn = false;

        private IEnumerable<object> query =
            from commandesFournisseur in Tables.CommandesFournisseur.AsEnumerable()
            join fournisseurs in Tables.Fournisseurs.AsEnumerable()
                on commandesFournisseur["IDFournisseur"] equals fournisseurs["IDFournisseur"]
            select new
            {
                IDCommandeFournisseur = Convert.ToString(commandesFournisseur["IDCommandeFournisseur"]),
                IDFournisseur = Convert.ToString(commandesFournisseur["IDFournisseur"]),
                Domaine = Convert.ToString(fournisseurs["Nom"]),
                DateCommande = Convert.ToDateTime(commandesFournisseur["DateCommande"]).ToString("dd/mm/yyyy HH:mm"),
                TypeCommande = Convert.ToString(commandesFournisseur["TypeCommande"]),
                Statut = Convert.ToString(commandesFournisseur["Statut"])
            };

        private ColumnGridDesign[] columnDesign =
        {
            new ("ID", 100, 'L'),
            new ("ID Fournisseur", 100, 'L'),
            new ("Nom", 200, 'L'),
            new ("Date de la commande", 150, 'L'),
            new ("Type de commande", 150, 'L'),
            new ("Statut", 150, 'L')
        };

        #endregion

        #region Override Methods

        protected override Form GetIndividualPage(string id)
        {
            return new CommandeFournisseurIndiv(id);
        }

        protected override Form GetNewItemForm()
        {
            return new NewCommandeFournisseur();
        }

        #endregion

        #region Constructor

        public CommandesFournisseur()
        {
            InitializePage(formTitle, tabID, showAddButton, addButtonName, hideFirstColumn, query.ToList(), columnDesign);
        }

        #endregion
    }
}
