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

        private string formTitle = "Commandes fournisseur";
        private string tabID = "CommandesFournisseur";
        private bool showAddButton = true;
        private string addButtonName = "Nouvelle commande";
        private bool hideFirstColumn = false;

        private IEnumerable<object> query = new List<object>();

        private ColumnGridDesign[] columnDesign = new ColumnGridDesign[0];

        #endregion

        #region Override Methods

        protected override Form GetIndividualPage(string id)
        {
            return new ArticleIndiv(id);
        }

        protected override Form GetNewItemForm()
        {
            return new NewArticle();
        }

        #endregion

        #region Constructeur

        public CommandesFournisseur()
        {
            InitializePage(formTitle, tabID, showAddButton, addButtonName, hideFirstColumn, query.ToList(), columnDesign);
        }

        #endregion
    }
}
