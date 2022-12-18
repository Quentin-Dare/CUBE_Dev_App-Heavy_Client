using System.Data;

namespace Gestion_stock.NegosudData
{
    #region Static Methods

    public static class DataUtils
    {
        #region Unique Variables

        public static string UserName { get => userName; set => userName = value; }
        public static string Password { get => password; set => password = value; }

        private static string userName = "";
        private static string password = "";

        #endregion

        #region General Requests
        public static List<FamilleDeVinInfo> GetWineFamiliesName()
        {
            IEnumerable<FamilleDeVinInfo> listeFamilledeVin =
            from familledevin in Tables.FamillesDeVin.AsEnumerable()
            select new FamilleDeVinInfo
            {
                IDFamilleDeVin = Convert.ToString(familledevin["IDFamilleDeVin"]),
                Nom = Convert.ToString(familledevin["Nom"])
            };

            return listeFamilledeVin.ToList();
        }

        public static List<FournisseurInfo> GetSuppliersName()
        {
            IEnumerable<FournisseurInfo> listeFournisseurs =
            from fournisseur in Tables.Fournisseurs.AsEnumerable()
            select new FournisseurInfo
            {
                IDFournisseur = Convert.ToString(fournisseur["IDFournisseur"]),
                Nom = Convert.ToString(fournisseur["Nom"])
            };

            return listeFournisseurs.ToList();
        }

        #endregion
    }

    #endregion

    #region Data Classes

    public class FournisseurInfo
    {
        public string? IDFournisseur { get; set; }
        public string? Nom { get; set; }
    }

    public class FamilleDeVinInfo
    {
        public string? IDFamilleDeVin { get; set; }
        public string? Nom { get; set; }
    }

    #endregion
}
