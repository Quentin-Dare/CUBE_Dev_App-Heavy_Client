using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_stock.Utils.CustomControls
{
    public class CustomGridView : DataGridView
    {
        public class ColumnDesign
        {
            public string Name { get; set; }
            public int ColumnWidth { get; set; }
            public char TextAlignement { get; set; }

            public ColumnDesign(string name, int columnWidth, char textAlignement)
            {
                Name = name;
                ColumnWidth = columnWidth;
                TextAlignement = textAlignement;
            }
        }
    }
}
