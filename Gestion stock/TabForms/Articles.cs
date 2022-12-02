using Gestion_stock.Forms;
using Gestion_stock.NegosudData;
using Gestion_stock.Utils.CustomControls;
using System.Data;

namespace Gestion_stock.TabForms
{
    public class Articles : DefaultForm
    {
        #region Variables

        private string formTitle = "Articles";
        private string tabID = "articles";
        private bool showAddButton = true;
        private bool hideFirstColumn = false;

        IEnumerable<object> query =
            from articles in Tables.Articles.AsEnumerable()
            join fournisseur in Tables.Fournisseur.AsEnumerable()
                on (string)articles["IDFournisseur"] equals (string)fournisseur["IDFournisseur"]
            join familleDeVin in Tables.FamilleDeVin.AsEnumerable()
                on (string)articles["IDFamilleDeVin"] equals (string)familleDeVin["IDFamilleDeVin"]
            select new
            {
                Reference = Convert.ToString(articles["IDArticle"]),
                Nom = Convert.ToString(articles["Nom"]),
                Domaine = Convert.ToString(fournisseur["Nom"]),
                FamilleDeVin = Convert.ToString(familleDeVin["Nom"]),
                Annee = Convert.ToInt32(articles["Annee"]),
                PrixTTC = Convert.ToDecimal(articles["PrixTTC"]),
            };

        private CustomGridView.ColumnDesign[] columnNames =
        {
            new ("Référence" , 100, 'L'),
            new ("Nom" , 300, 'L'),
            new ("Domaine" , 300, 'L'),
            new ("Famille de vin" , 100, 'L'),
            new ("Année" , 100, 'R'),
            new ("Prix TTC" , 100, 'R')
        };

        #endregion

        #region Methods

        #endregion

        #region Constructeur

        public Articles()
        {
            base.InitializeChild(formTitle, tabID, showAddButton, hideFirstColumn, query, columnNames);
        }

        #endregion
    }
}
