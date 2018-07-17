namespace StockApp.ViewModels
{
    using System.Windows.Input;

    public class LoginViewModel : BaseViewModel
    {

        private string _email;
        private string _password;
        private bool _rememberMe;
        private bool _isRunning;

        public string Email
        {
            get { return _email; }
            set { SetValue(ref _email, value); }
        }

        public string Password
        {
            get { return _password; }
            set { SetValue(ref _password, value); }
        }

        public bool RememberMe
        {
            get { return _rememberMe; }
            set { SetValue(ref _rememberMe, value); }
        }

        public bool IsRunning
        {
            get { return _isRunning; }
            set { SetValue(ref _isRunning, value); }
        }

        public LoginViewModel()
        {
            RememberMe = true;
            Email = "muo.cpp@gmail.com";
            Password = "12345";
        }

        public ICommand LoginCommmand { get; set; }
        public ICommand RegisterCommand { get; set; }

    }
}
