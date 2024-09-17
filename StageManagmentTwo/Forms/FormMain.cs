using StageManagmentTwo.Uc;

namespace StageManagmentTwo
{
    public partial class FormMain : Form
    {
        private UserControl _ucLogin;

        public FormMain()
        {
            InitializeComponent();

            if (_ucLogin == null)
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new UcLogin(this));
            }
            panelMain.Controls.Add(_ucLogin);
        }

        public void OnLoggedIn(bool LoginLogout)
        {
            if (LoginLogout)
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new UcManageUserControls());
            }
        }
    }
}
