﻿using static System.Windows.Forms.Control;

namespace Gestion_stock.Utils
{
    public static class Initialize
    {
        /// <summary>
        /// Initialisation du design de la page
        /// </summary>
        /// <param name="form"></param>
        public static void Design(Form form)
        {
            ChangeFont(form.Controls);
            //object properties = this.dgvData.GetType().GetProperties().Where(p => p.PropertyType == typeof(Color)).Where(p => p.PropertyType == typeof(Color));
        }

        /// <summary>
        /// Changement des polices d'écriture de Segoe UI en Open Sans et de Times New Roman en Abril Fatface
        /// </summary>
        /// <param name="controls"></param>
        private static void ChangeFont(ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                // Récursivité pour sélectionner tous les controls
                if (c.Controls.Count != 0)
                {
                    ChangeFont(c.Controls);
                }

                // Changement de la font family Segoe UI en Open Sans
                if (c.Font.FontFamily.Name == "Segoe UI")
                {
                    float emSize = c.Font.Size;
                    c.Font = new Font(CustomFont.OpenSans, emSize);
                }
                // Changement de la font family Times New Roman en Abril Fatface
                else if (c.Font.FontFamily.Name == "Times New Roman")
                {
                    float emSize = c.Font.Size;
                    c.Font = new Font(CustomFont.AbrilFatface, emSize);
                }
            }
        }
    }
}
