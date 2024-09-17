namespace StageManagmentTwo.Service
{
    public class AuthService
    {
        /// <summary>
        /// Singleton Service
        /// </summary>
        private static AuthService _instance;

        public static AuthService Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new AuthService();
                }
                return _instance;
            }
        }

        private AuthService()
        {

        }

        public bool IsAuthenticated { get; set; }
        public string Username { get; set; }

        public void Login(string username)
        {
            IsAuthenticated = true;
            Username = username;
        }

        public void Logout()
        {
            IsAuthenticated = false;
            Username = string.Empty;
        }
    }
}
