using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock.Utils
{
    public static class CustomMethods
    {
        public static void DisplayError(string message)
        {
            MessageBox.Show(message, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
