using StageManagmentTwo.Entities;
using StageManagmentTwo.Service;

namespace StageManagmentTwo.Uc
{
    public partial class UcLogin : UserControl
    {
        private readonly ServiceAccount _serviceAccount;
        private readonly FormMain _formMain;

        public UcLogin(FormMain formMain)
        {
            InitializeComponent();
            var context = new DbContextStageManagmentTwo();
            _serviceAccount = new ServiceAccount(context);

            textBoxPassword.PasswordChar = '*';
            _formMain = formMain;

            // Todo: Löschen am schluss
            textBoxUsername.Text = "admin";
            textBoxPassword.Text = "admin";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginmodel = new LoginModel
            {
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text,
            };

            var account = _serviceAccount.FindAccount(loginmodel.Username);

            if (account != null && BCrypt.Net.BCrypt.Verify(loginmodel.Password, account.HashPassword))
            {
                AuthService.Instance.Login(account.Username);
                _formMain.OnLoggedIn(true);
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort falsch");
            }
        }
    }
}
