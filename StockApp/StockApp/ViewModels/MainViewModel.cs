namespace StockApp.ViewModels
{
    public class MainViewModel
    {
        public LoginViewModel Login { get; set; }
        public MainViewModel()
        {
            Login = new LoginViewModel();
        }
    }
}
