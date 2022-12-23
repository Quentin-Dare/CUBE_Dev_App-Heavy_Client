using Gestion_stock.Forms.FormIndividual;
using Gestion_stock.Forms.FormLists.Model;
using Gestion_stock.Forms.FormNewItem;
using Gestion_stock.NegosudData;
using Gestion_stock.Utils.CustomControls;
using System.Data;

namespace Gestion_stock.Forms.FormLists
{
    public class Clients : DefaultForm
    {
        #region Variables

        private string formTitle = "Clients";
        private string tabID = "Clients";
        private bool showAddButton = false;
        private string addButtonName = "";
        private bool hideFirstColumn = false;

        private IEnumerable<object> query =
            from clients in Tables.Clients.AsEnumerable()
            select new
            {
                IDClient = Convert.ToString(clients["IDClient"]),
                Nom = Convert.ToString(clients["Nom"]),
                Prenom = Convert.ToString(clients["Prenom"]),
                Adresse = Convert.ToString(clients["Adresse"]),
                CodePostal = Convert.ToString(clients["CodePostal"]),
                Ville = Convert.ToString(clients["Ville"]),
                Email = Convert.ToString(clients["Email"]),
            };

        private ColumnGridDesign[] columnDesign =
        {
            new ("ID Client", 150, 'L'),
            new ("Nom", 300, 'L'),
            new ("Prénom", 300, 'L'),
            new ("Adresse" , 500, 'L'),
            new ("Code postal" , 100, 'L'),
            new ("Ville" , 200, 'L'),
            new ("Adresse mail", 300, 'L'),
        };

        #endregion

        #region Override Methods

        protected override Form GetIndividualPage(string id)
        {
            return new ClientIndiv(id);
        }

        protected override Form GetNewItemForm()
        {
            return new NewArticle();
        }

        #endregion

        #region Constructor

        public Clients()
        {
            InitializePage(formTitle, tabID, showAddButton, addButtonName, hideFirstColumn, query.ToList(), columnDesign);
        }

        #endregion
    }
}
