using Gestion_stock.Forms.FormIndividual;
using Gestion_stock.Forms.FormLists.Model;
using Gestion_stock.Forms.FormNewItem;
using Gestion_stock.NegosudData;
using Gestion_stock.Utils.CustomControls;
using System.Data;

namespace Gestion_stock.Forms.FormLists
{
    public class Articles : DefaultForm
    {
        #region Variables

        private string formTitle = "Articles";
        private string tabID = "articles";
        private bool showAddButton = true;
        private string addButtonName = "Nouvel article";
        private bool hideFirstColumn = true;

        private IEnumerable<object> query =
            from articles in Tables.Articles.AsEnumerable()
            join fournisseur in Tables.Fournisseurs.AsEnumerable()
                on (string)articles["IDFournisseur"] equals (string)fournisseur["IDFournisseur"]
            join familleDeVin in Tables.FamillesDeVin.AsEnumerable()
                on (string)articles["IDFamilleDeVin"] equals (string)familleDeVin["IDFamilleDeVin"]
            select new
            {
                IDArticle = Convert.ToString(articles["IDArticle"]),
                Reference = Convert.ToString(articles["Reference"]),
                Nom = Convert.ToString(articles["Nom"]),
                Domaine = Convert.ToString(fournisseur["Nom"]),
                FamilleDeVin = Convert.ToString(familleDeVin["Nom"]),
                Annee = Convert.ToInt32(articles["Annee"]),
                Quantite = Convert.ToInt32(articles["Quantite"]),
                QuantiteMin = Convert.ToInt32(articles["QuantiteMin"]),
                PrixTTC = Convert.ToDecimal(articles["PrixTTC"]),
                PrixAchat = Convert.ToDecimal(articles["PrixAchat"]),
                TVA = Convert.ToDecimal(articles["TVA"]),
                Description = Convert.ToString(articles["Description"])
            };

        private ColumnGridDesign[] columnDesign =
        {
            new ("Référence" , 100, 'L'),
            new ("Nom" , 300, 'L'),
            new ("Domaine" , 300, 'L'),
            new ("Famille de vin" , 150, 'L'),
            new ("Année" , 100, 'R'),
            new ("Quantité restante" , 100, 'R'),
            new ("Quantité requise" , 100, 'R'),
            new ("Prix TTC (€)" , 100, 'R'),
            new ("Prix d'achat (€)" , 100, 'R'),
            new ("TVA (%)" , 100, 'R'),
            new ("Description" , 500, 'L')
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

        public Articles()
        {
            InitializePage(formTitle, tabID, showAddButton, addButtonName, hideFirstColumn, query.ToList(), columnDesign);
        }

        #endregion
    }
}
