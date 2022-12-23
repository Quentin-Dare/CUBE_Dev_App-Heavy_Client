using Gestion_stock.Forms.FormIndividual;
using Gestion_stock.Forms.FormLists.Model;
using Gestion_stock.Forms.FormNewItem;
using Gestion_stock.NegosudData;
using Gestion_stock.Utils.CustomControls;
using System.Data;

namespace Gestion_stock.Forms.FormLists
{
    public class CommandesClient : DefaultForm
    {
        #region Variables

        private string formTitle = "Commandes clients";
        private string tabID = "CommandesClient";
        private bool showAddButton = false;
        private string addButtonName = "";
        private bool hideFirstColumn = false;

        private IEnumerable<object> query =
            from commandesClient in Tables.CommandesClient.AsEnumerable()
            join clients in Tables.Clients.AsEnumerable()
                on commandesClient["IDClient"] equals clients["IDClient"]
            select new
            {
                IDCommandeClient = Convert.ToString(commandesClient["IDCommandeClient"]),
                IDClient = Convert.ToString(commandesClient["IDClient"]),
                Nom = Convert.ToString(clients["Nom"]),
                Prenom = Convert.ToString(clients["Prenom"]),
                DateCommande = Convert.ToDateTime(commandesClient["DateCommande"]).ToString("dd/mm/yyyy HH:mm"),
                Statut = Convert.ToString(commandesClient["Statut"])
            };

        private ColumnGridDesign[] columnDesign =
        {
            new ("ID", 100, 'L'),
            new ("ID Client", 100, 'L'),
            new ("Nom", 200, 'L'),
            new ("Prénom", 200, 'L'),
            new ("Date de la commande", 150, 'L'),
            new ("Statut", 150, 'L')
        };

        #endregion

        #region Override Methods

        protected override Form GetIndividualPage(string id)
        {
            return new CommandeClientIndiv(id);
        }

        protected override Form GetNewItemForm()
        {
            return new Form();
        }

        #endregion

        #region Constructor

        public CommandesClient()
        {
            InitializePage(formTitle, tabID, showAddButton, addButtonName, hideFirstColumn, query.ToList(), columnDesign);
        }

        #endregion
    }
}
