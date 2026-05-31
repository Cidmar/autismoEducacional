namespace autismoEducacional
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Certifique-se de usar "new NavigationPage(...)" aqui:
            MainPage = new NavigationPage(new Views.CadastroEventoPage());
        }
    }
}