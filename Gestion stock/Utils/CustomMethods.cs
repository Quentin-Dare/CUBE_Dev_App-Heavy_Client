namespace Gestion_stock.Utils
{
    public static class CustomMethods
    {
        public static void DisplayError(string message)
        {
            MessageBox.Show(message, "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ConfirmDataReload()
        {
            return MessageBox.Show("Recharger la page ? Les données modifiées seront perdues.", "Rafraîchir", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public static bool ConfirmDataSave()
        {
            return MessageBox.Show("Etes-vous sûr de vouloir enregistrer ?", "Enregistrement des données", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public static bool ConfirmCloseCommand()
        {
            return MessageBox.Show("Etes-vous sûr de vouloir clore la commande ?", "Clôture d'une commande", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public static bool ConfirmCancelCommand()
        {
            return MessageBox.Show("Etes-vous sûr de vouloir annuler puis clore la commande ?", "Annulation d'une commande", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public static bool ConfirmCommandCreation()
        {
            return MessageBox.Show("Etes-vous sûr de vouloir créer une nouvelle commande ?", "Création d'une commande", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}
