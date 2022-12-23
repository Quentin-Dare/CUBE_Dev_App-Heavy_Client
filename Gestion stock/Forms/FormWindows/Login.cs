using Gestion_stock.NegosudData;
using Gestion_stock.Utils;

namespace Gestion_stock.MainForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Initialize.Design(this);
            this.AutoScaleMode = AutoScaleMode.Font;
        }

        #region Events

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TryLogin(object sender, EventArgs e)
        {
            // Check du nom d'utilisateur et du mot de passe
            if (tbUsername.Text == DataUtils.UserName
                && tbPassword.Text == DataUtils.Password)
            {
                // Passage à la page principale
                this.Visible = false;
                new NegoSUD().ShowDialog();
                this.Close();
            }
            else
            {
                lbErreurLogin.Visible = true;
            }
        }

        /// <summary>
        /// Evenement quand la touche Entrée est tapée dans un des textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckEnterKeyPress(object sender, KeyEventArgs e)
        {
            // Source : https://stackoverflow.com/questions/3558814/net-textbox-handling-the-enter-key
            if (e.KeyValue == (char)Keys.Return)
            {
                e.SuppressKeyPress = true;
                this.ActiveControl = btnLogin;
            }
        }

        #endregion

        private void pnlMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void lblCloseIcon_MouseEnter(object sender, EventArgs e)
        {
            pnlClose.BackColor = Color.FromArgb(255, 128, 128);
            lblCloseIcon.ForeColor = Color.Gray;
        }

        private void lblCloseIcon_MouseLeave(object sender, EventArgs e)
        {
            pnlClose.BackColor = Color.Red;
            lblCloseIcon.ForeColor = Color.White;
        }

        private void pnlMinimize_MouseEnter(object sender, EventArgs e)
        {
            pnlMinimize.BackColor = CustomColors.WhiteBackgroundHover;
        }

        private void pnlMinimize_MouseLeave(object sender, EventArgs e)
        {
            pnlMinimize.BackColor = CustomColors.WhiteBackground;
        }
    }
}
