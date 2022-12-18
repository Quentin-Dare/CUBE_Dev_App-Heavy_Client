using Gestion_stock.Forms.FormIndividual;
using Gestion_stock.Forms.FormLists.Model;
using Gestion_stock.Forms.FormNewItem;
using Gestion_stock.NegosudData;
using Gestion_stock.Utils.CustomControls;
using System.Data;

namespace Gestion_stock.Forms.FormLists
{
    public class FamillesDeVin : DefaultForm
    {
        #region Variables

        private string formTitle = "Familles de vin";
        private string tabID = "FamillesDeVin";
        private bool showAddButton = true;
        private string addButtonName = "Nouvelle famille de vin";
        private bool hideFirstColumn = false;

        private IEnumerable<object> query =
            from famillesDeVin in Tables.FamillesDeVin.AsEnumerable()
            select new
            {
                Nom = Convert.ToString(famillesDeVin["Nom"])
            };

        private ColumnGridDesign[] columnDesign =
        {
            new ("Nom", 200, 'L')
        };

        #endregion

        #region Override Methods

        protected override Form GetIndividualPage(string id)
        {
            return null;
        }

        protected override Form GetNewItemForm()
        {
            return new NewFamilleDeVin();
        }

        #endregion

        #region Constructeur

        public FamillesDeVin()
        {
            InitializePage(formTitle, tabID, showAddButton, addButtonName, hideFirstColumn, query.ToList(), columnDesign);
        }

        #endregion
    }
}
