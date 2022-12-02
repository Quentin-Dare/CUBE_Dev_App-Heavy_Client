using System.Windows.Forms;

namespace Gestion_stock.Utils
{
    /// <summary>
    /// Permet d'obtenir des couleurs personnalisées
    /// </summary>
    public static class CustomColors
    {
        #region Getters

        public static Color Red
        {
            get
            {
                return red.ToColor();
            }
        }
        public static Color RedHover
        {
            get
            {
                return redHover.ToColor();
            }
        }
        public static Color DarkRed
        {
            get
            {
                return darkRed.ToColor();
            }
        }
        public static Color DarkRedHover
        {
            get
            {
                return darkRedHover.ToColor();
            }
        }

        public static Color WhiteBackground
        {
            get
            {
                return whiteBackground.ToColor();
            }
        }
        public static Color WhiteBackgroundHover
        {
            get
            {
                return whiteBackgroundHover.ToColor();
            }
        }
        public static Color GrayBackground
        {
            get
            {
                return grayBackground.ToColor();
            }
        }
        public static Color GrayBackgroundHover
        {
            get
            {
                return grayBackgroundHover.ToColor();
            }
        }
        public static Color TabColor
        {
            get
            {
                return tabColor.ToColor();
            }
        }

        public static Color GrayText
        {
            get
            {
                return grayText.ToColor();
            }
        }

        #endregion

        #region Valeurs couleurs

        static string red = "#7A0000";
        static string redHover = "#680000";
        static string darkRed = "#4D0400";
        static string darkRedHover = "#390400";
        static string whiteBackground = "#F9F9F9";
        static string whiteBackgroundHover = "#F4F4F4";
        static string grayBackground = "#F2F2F2";
        static string grayBackgroundHover = "#E8E8E8";
        static string tabColor = "#E6E6E6";

        static string grayText = "#808080";

        #endregion

        #region Private Methods

        /// <summary>
        /// Transforme une chaîne de caractères de type 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        private static Color ToColor(this string color)
        {
            try
            {
                // Séparation des valeurs rgb
                string hexaRed = color.Substring(1, 2);
                string hexaGreen = color.Substring(3, 2);
                string hexaBlue = color.Substring(5, 2);

                // Convert.ToInt32() pour changer les valeurs hexadécimales en décimales. Source : https://www.includehelp.com/dot-net/convert-a-hexadecimal-value-to-decimal-in-c-sharp.aspx
                return Color.FromArgb(Convert.ToInt32(hexaRed, 16), Convert.ToInt32(hexaGreen, 16), Convert.ToInt32(hexaBlue, 16));
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur", "Erreur lors du passage de la couleur en format décimal : " + e.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Color.Gray;
            }
        }

        #endregion
    }
}
