namespace Gestion_stock.Utils
{
    public static class CustomEvents
    {
        #region Hover Events

        public static void OnMouseEnterRed(object sender)
        {
            if (sender is Control ctrl)
            {
                ctrl.BackColor = CustomColors.RedHover;
            }
        }

        public static void OnMouseLeaveRed(object sender)
        {
            if (sender is Control ctrl)
            {
                ctrl.BackColor = CustomColors.Red;
            }
        }

        public static void OnMouseEnterDarkRed(object sender)
        {
            if (sender is Control ctrl)
            {
                ctrl.BackColor = CustomColors.DarkRedHover;
            }
        }

        public static void OnMouseLeaveDarkRed(object sender)
        {
            if (sender is Control ctrl)
            {
                ctrl.BackColor = CustomColors.DarkRed;
            }
        }
        public static void OnMouseEnterGrayBackground(object sender)
        {
            if (sender is Control ctrl)
            {
                ctrl.BackColor = CustomColors.GrayBackgroundHover;
            }
        }

        public static void OnMouseLeaveGrayBackground(object sender)
        {
            if (sender is Control ctrl)
            {
                ctrl.BackColor = CustomColors.GrayBackground;
            }
        }

        #endregion

        #region Text events

        /// <summary>
        /// Filtre uniquement les nombres entiers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void FilterIntegers(object? sender, KeyPressEventArgs e)
        {
            // Source : https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Filtre uniquement les nombres décimaux
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void FilterDecimals(object? sender, KeyPressEventArgs e)
        {
            // Source : https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && sender is TextBox textBox && (textBox.Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
