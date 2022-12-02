using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
