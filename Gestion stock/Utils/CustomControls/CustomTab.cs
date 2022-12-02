namespace Gestion_stock.Utils.CustomControls
{
    public class CustomTab : Panel
    {
        private readonly int tabWidth = 170;

        public CustomTab(string tabID, string tabName)
        {
            Name = tabID;
            BackColor = CustomColors.TabColor;
            Margin = new Padding(0, 15, 8, 0);
            Size = new Size(tabWidth, 45);
            TabIndex = 0;
            Controls.Add(new TabLabel(tabName, tabWidth));
            Controls.Add(new TabXMark(tabWidth));
            Click += new EventHandler(OpenTab);
        }

        internal class TabLabel : Label
        {
            internal TabLabel(string tabName, int tabWidth)
            {
                Font = new Font(CustomFont.OpenSans, 9.5F);
                AutoEllipsis = true;
                Margin = new Padding(0);
                Location = new Point(5, 12);
                Size = new Size(tabWidth - 30, 20);
                Text = tabName;
                TextAlign = ContentAlignment.MiddleLeft;
                Click += new EventHandler(OpenTab);
            }
        }

        private class TabXMark : Label
        {
            internal TabXMark(int tabWidth)
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right;
                Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
                Margin = new Padding(0);
                Location = new Point(tabWidth - 30, 0);
                Size = new Size(30, 45);
                Text = "✖";
                TextAlign = ContentAlignment.MiddleCenter;
                Cursor = Cursors.Hand;
                Click += new EventHandler(CloseTab);
            }

            private static void CloseTab(object? sender, EventArgs e)
            {
                if (sender is TabXMark closeBtn
                && closeBtn.TopLevelControl is NegoSUD mainForm)
                {
                    // On sélectionne le texte du label de l'onglet
                    string tabID = closeBtn.Parent.Name;

                    // On trouve l'index de l'onglet en fonction de son nom
                    int tabIndex = mainForm.GetTabIndex(tabID);

                    // Si l'onglet a été trouvé on change d'onglet
                    if (tabIndex != -1)
                    {
                        mainForm.CloseTab(tabIndex);
                    }
                }
            }
        }

        // EVENEMENTS 
        private static void OpenTab(object? sender, EventArgs e)
        {
            // On checke si l'objet sender est un control, et que le Form qui le contient est un Form Negosud
            if (sender is Control ctrl
                && ctrl.TopLevelControl is NegoSUD mainForm)
            {
                string tabID;

                // Si on a cliqué sur l'onglet
                if (ctrl is CustomTab tab)
                {
                    tabID = tab.Name;
                }

                // Si on a cliqué sur le texte de l'onglet
                else if (ctrl is TabLabel label)
                {
                    tabID = label.Parent.Name;
                }

                // Sinon on ne fait rien
                else
                {
                    return;
                }

                // On trouve l'index de l'onglet en fonction de son nom
                int tabIndex = mainForm.GetTabIndex(tabID);

                // Si l'onglet a été trouvé on change d'onglet
                if (tabIndex != -1)
                {
                    mainForm.OpenTab(tabIndex);
                }
            }
        }
    }
}
