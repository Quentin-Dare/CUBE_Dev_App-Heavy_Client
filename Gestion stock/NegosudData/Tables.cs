using Gestion_stock.TabForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock.NegosudData
{
    public static class Tables
    {
        public static readonly DataTable Articles = LoadArticlesTable();
        public static readonly DataTable Fournisseur = LoadFournisseurTable();
        public static readonly DataTable FamilleDeVin = LoadFamilleDeVinTable();

        private static DataTable LoadArticlesTable()
        {
            DataTable articles = new DataTable();
            articles.Columns.Add("IDArticle", typeof(string));
            articles.Columns.Add("Nom", typeof(string));
            articles.Columns.Add("Annee", typeof(int));
            articles.Columns.Add("Quantite", typeof(int));
            articles.Columns.Add("PrixTTC", typeof(decimal));
            articles.Columns.Add("PrixAchat", typeof(decimal));
            articles.Columns.Add("Description", typeof(string));
            articles.Columns.Add("IDFournisseur", typeof(string));
            articles.Columns.Add("IDFamilleDeVin", typeof(string));

            articles.Rows.Add("V00001", "Montazac Rouge 2020", 2020, "30", 34.89, 20.00, null, "F00001", "FV00001");
            articles.Rows.Add("V00002", "Montazac Rouge 2020", 2020, "30", 34.89, 20.00, null, "F00001", "FV00002");
            articles.Rows.Add("V00003", "Montazac Rouge 2020", 2020, "30", 34.89, 20.00, null, "F00001", "FV00003");

            return articles;
        }

        private static DataTable LoadFournisseurTable()
        {
            DataTable fournisseur = new DataTable();
            fournisseur.Columns.Add("IDFournisseur", typeof(string));
            fournisseur.Columns.Add("Nom", typeof(string));
            fournisseur.Columns.Add("Email", typeof(string));
            fournisseur.Columns.Add("Adresse", typeof(string));
            fournisseur.Columns.Add("CodePostal", typeof(string));
            fournisseur.Columns.Add("Ville", typeof(string));

            fournisseur.Rows.Add("F00001", "Fab & Co", "jojo@gmail.com", "23 Rue Salvador Dali", "34900", "Poirret");

            return fournisseur;
        }

        private static DataTable LoadFamilleDeVinTable()
        {
            DataTable familleDeVin = new DataTable();
            familleDeVin.Columns.Add("IDFamilleDeVin", typeof(string));
            familleDeVin.Columns.Add("Nom", typeof(string));

            familleDeVin.Rows.Add("FV00001", "Rouge");
            familleDeVin.Rows.Add("FV00002", "Blanc");
            familleDeVin.Rows.Add("FV00003", "Rosé");

            return familleDeVin;
        }
    }
}
