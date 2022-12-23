using System.Drawing.Text;

namespace Gestion_stock.Utils
{
    public static class CustomFont
    {
        public static FontFamily AbrilFatface
        {
            get
            {
                if (abrilFatface != null)
                {
                    return abrilFatface;
                }
                else
                {
                    return FontFamily.GenericSansSerif;
                }
            }
        }

        public static FontFamily OpenSans
        {
            get
            {
                if (openSans != null)
                {
                    return openSans;
                }
                else
                {
                    return FontFamily.GenericSansSerif;
                }
            }
        }

        // Fonts custom
        private static FontFamily? abrilFatface;
        private static FontFamily? openSans;

        // Source : https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-create-a-private-font-collection?view=netframeworkdesktop-4.8
        public static bool LoadFonts()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();

            // On trouve le dossier où le projet se situe
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            if (directory == null)
            {
                return false;
            }

            // On trouve le nom du projet
            string projectName = Application.ProductName;

            // On remonte dans les dossiers jusqu'à ce qu'on arrive à la racine du projet
            while (!directory.EndsWith(projectName))
            {
                DirectoryInfo? info = Directory.GetParent(directory);
                if (info != null)
                {
                    directory = info.FullName;
                }
                else
                {
                    CustomMethods.DisplayError("Impossible d'atteindre la racine du projet.");
                    return false;
                }
            }

            try
            {
                // On va dans le dossier Resources pour ajouter les fonts.
                pfc.AddFontFile(Path.Combine(directory, "Resources", "AbrilFatface.ttf"));
                pfc.AddFontFile(Path.Combine(directory, "Resources", "OpenSans.ttf"));
            }
            catch
            {
                CustomMethods.DisplayError("Erreur lors du chargement des polices d'écriture personnalisées.");
                return false;
            }

            // Assignation des polices
            abrilFatface = pfc.Families[0];
            openSans = pfc.Families[1];

            return true;
        }
    }
}
