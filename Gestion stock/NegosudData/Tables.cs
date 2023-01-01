using System.Data;

namespace Gestion_stock.NegosudData
{
    public static class Tables
    {
        public static readonly DataTable Articles = LoadArticlesTable();
        public static readonly DataTable Fournisseurs = LoadFournisseurTable();
        public static readonly DataTable FamillesDeVin = LoadFamilleDeVinTable();
        public static readonly DataTable Clients = LoadClientsTable();
        public static readonly DataTable CommandesClient = LoadCommandesClients();
        public static readonly DataTable CommandesClientListe = LoadCommandesClientsList();
        public static readonly DataTable CommandesFournisseur = LoadCommandesFournisseurs();
        public static readonly DataTable CommandesFournisseurListe = LoadCommandesFournisseursList();

        private static DataTable LoadArticlesTable()
        {
            DataTable articles = new DataTable();
            articles.Columns.Add("IDArticle", typeof(string));
            articles.Columns.Add("Reference", typeof(string));
            articles.Columns.Add("Nom", typeof(string));
            articles.Columns.Add("Annee", typeof(int));
            articles.Columns.Add("Quantite", typeof(int));
            articles.Columns.Add("QuantiteMin", typeof(int));
            articles.Columns.Add("PrixTTC", typeof(decimal));
            articles.Columns.Add("PrixAchat", typeof(decimal));
            articles.Columns.Add("TVA", typeof(decimal));
            articles.Columns.Add("Description", typeof(string));
            articles.Columns.Add("IDFournisseur", typeof(string));
            articles.Columns.Add("IDFamilleDeVin", typeof(string));

            string description = @"Très bon vin, plutôt bon dans la bouche,
avec un bon goût. Il fait l'unanimité parmi les amateurs de ce vin.

Bref c'est du bon çui-là";

            articles.Rows.Add("V00001", "RefVin1", "Montazac Rouge 2020", 2020, 30, 5, 59.99, 35.84, 20, description, "F00001", "FV00001");
            articles.Rows.Add("V00002", "RefVin2", "Montazac Rouge 2020", 2020, 30, 5, 34.89, 20.42, 20, null, "F00002", "FV00001");
            articles.Rows.Add("V00003", "RefVin3", "Montazac Blanc 2021", 2021, 30, 5, 34.89, 25.30, 20, description, "F00002", "FV00002");

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
            fournisseur.Rows.Add("F00002", "Dimitri le vigneron", "jojo@gmail.com", "23 Rue Salvador Dali", "34900", "Poirret");

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

        private static DataTable LoadClientsTable()
        {
            DataTable clients = new DataTable();
            clients.Columns.Add("IDClient", typeof(string));
            clients.Columns.Add("Nom", typeof(string));
            clients.Columns.Add("Prenom", typeof(string));
            clients.Columns.Add("Adresse", typeof(string));
            clients.Columns.Add("CodePostal", typeof(string));
            clients.Columns.Add("Ville", typeof(string));
            clients.Columns.Add("Email", typeof(string));

            clients.Rows.Add("C00001", "Dupont", "Michel", "1 Rue des Palourdes", "34500", "Bruxelles", "m.dupont@gmail.com");
            clients.Rows.Add("C00002", "Dupondt", "Grégoire", "2 Rue des Palourdes", "34540", "bruz", "m.dupondt@gmail.com");
            clients.Rows.Add("C00003", "Dupond", "François", "3 Rue des Palourdes", "32500", "Bourges", "m.dupond@gmail.com");

            return clients;
        }

        private static DataTable LoadCommandesClients()
        {
            DataTable cmdClients = new DataTable();
            cmdClients.Columns.Add("IDCommandeClient", typeof(string));
            cmdClients.Columns.Add("Statut", typeof(string));
            cmdClients.Columns.Add("DateCommande", typeof(DateTime));
            cmdClients.Columns.Add("IDClient", typeof(string));

            cmdClients.Rows.Add("CmdC00001", "CLOS", "01/01/2001 12:09", "C00001");
            cmdClients.Rows.Add("CmdC00002", "EN COURS", "05/01/2001 12:09", "C00002");
            cmdClients.Rows.Add("CmdC00003", "CLOS", "07/01/2001 12:09", "C00002");

            return cmdClients;
        }

        private static DataTable LoadCommandesClientsList()
        {
            DataTable cmdClientsList = new DataTable();
            cmdClientsList.Columns.Add("IDCommandeClient", typeof(string));
            cmdClientsList.Columns.Add("IDArticle", typeof(string));
            cmdClientsList.Columns.Add("Quantite", typeof(int));

            cmdClientsList.Rows.Add("CmdC00001", "V00001", 3);
            cmdClientsList.Rows.Add("CmdC00001", "V00002", 3);
            cmdClientsList.Rows.Add("CmdC00001", "V00003", 3);
            cmdClientsList.Rows.Add("CmdC00001", "V00003", 7);
            cmdClientsList.Rows.Add("CmdC00002", "V00001", 3);
            cmdClientsList.Rows.Add("CmdC00002", "V00002", 4);
            cmdClientsList.Rows.Add("CmdC00002", "V00003", 5);
            cmdClientsList.Rows.Add("CmdC00003", "V00001", 13);

            return cmdClientsList;
        }

        private static DataTable LoadCommandesFournisseurs()
        {
            DataTable cmdFournisseurs = new DataTable();
            cmdFournisseurs.Columns.Add("IDCommandeFournisseur", typeof(string));
            cmdFournisseurs.Columns.Add("Statut", typeof(string));
            cmdFournisseurs.Columns.Add("DateCommande", typeof(DateTime));
            cmdFournisseurs.Columns.Add("TypeCommande", typeof(string));
            cmdFournisseurs.Columns.Add("CoutTransport", typeof(decimal));
            cmdFournisseurs.Columns.Add("IDFournisseur", typeof(string));

            cmdFournisseurs.Rows.Add("CmdF00001", "CLOS", "01/01/2001 12:09", "MANUEL", 12.0, "F00001");
            cmdFournisseurs.Rows.Add("CmdF00002", "EN COURS", "05/01/2001 12:09", "AUTOMATIQUE", 12.0, "F00002");
            cmdFournisseurs.Rows.Add("CmdF00003", "CLOS", "07/01/2001 12:09", "MANUEL", 12.0, "F00002");

            return cmdFournisseurs;
        }

        private static DataTable LoadCommandesFournisseursList()
        {
            DataTable cmdClientsList = new DataTable();
            cmdClientsList.Columns.Add("IDCommandeFournisseur", typeof(string));
            cmdClientsList.Columns.Add("IDArticle", typeof(string));
            cmdClientsList.Columns.Add("Quantite", typeof(int));

            cmdClientsList.Rows.Add("CmdF00001", "V00001", 3);
            cmdClientsList.Rows.Add("CmdF00002", "V00002", 3);
            cmdClientsList.Rows.Add("CmdF00002", "V00003", 3);
            cmdClientsList.Rows.Add("CmdF00003", "V00003", 10);

            return cmdClientsList;
        }
    }
}
