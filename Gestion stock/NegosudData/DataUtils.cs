using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock.NegosudData
{
    public static class DataUtils
    {
        public static string UserName { get => userName; set => userName = value; }
        public static string Password { get => password; set => password = value; }

        private static string userName = "";
        private static string password = "";
    }
}
