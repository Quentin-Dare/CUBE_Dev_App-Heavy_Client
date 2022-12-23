using System.Data;

namespace Gestion_stock.NegosudData
{
    public static class DataUtils
    {
        #region Unique Variables

        public static string UserName { get => userName; set => userName = value; }
        public static string Password { get => password; set => password = value; }
        public static string ClosStatus { get => closStatus; set => closStatus = value; }
        public static string EnCoursStatus { get => enCoursStatus; set => enCoursStatus = value; }

        private static string userName = "";
        private static string password = "";
        private static string closStatus = "CLOS";
        private static string enCoursStatus = "EN COURS";

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
