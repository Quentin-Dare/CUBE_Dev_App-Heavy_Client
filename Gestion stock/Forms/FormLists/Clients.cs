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

        public Clients()
        {
            InitializePage(formTitle, tabID, showAddButton, addButtonName, hideFirstColumn, query.ToList(), columnDesign);
        }

        #endregion
    }
}
