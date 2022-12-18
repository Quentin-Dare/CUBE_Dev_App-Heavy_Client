using Gestion_stock.Forms.FormIndividual;
using Gestion_stock.Forms.FormLists.Model;
using Gestion_stock.Forms.FormNewItem;
using Gestion_stock.NegosudData;
using Gestion_stock.Utils.CustomControls;
using System.Data;

namespace Gestion_stock.Forms.FormLists
{
    public class Fournisseurs : DefaultForm
    {
        #region Variables

        private string formTitle = "Fournisseurs";
        private string tabID = "fournisseurs";
        private bool showAddButton = true;
        private string addButtonName = "Nouveau fournisseur";
        private bool hideFirstColumn = false;

        private IEnumerable<object> query =
            from fournisseurs in Tables.Fournisseurs.AsEnumerable()
            select new
            {
                IDFournisseur = Convert.ToString(fournisseurs["IDFournisseur"]),
                Nom = Convert.ToString(fournisseurs["Nom"]),
                Adresse = Convert.ToString(fournisseurs["Adresse"]),
                CodePostal = Convert.ToString(fournisseurs["CodePostal"]),
                Ville = Convert.ToString(fournisseurs["Ville"]),
                Email = Convert.ToString(fournisseurs["Email"])
            };

        private ColumnGridDesign[] columnDesign =
        {
            new ("ID" , 100, 'L'),
            new ("Nom" , 300, 'L'),
            new ("Adresse" , 500, 'L'),
            new ("Code postal" , 100, 'L'),
            new ("Ville" , 200, 'L'),
            new ("Adresse mail" , 300, 'L')
        };

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

        public Fournisseurs()
        {
            InitializePage(formTitle, tabID, showAddButton, addButtonName, hideFirstColumn, query.ToList(), columnDesign);
        }

        #endregion
    }
}
