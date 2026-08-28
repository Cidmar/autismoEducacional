namespace autismoEducacional.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCadastroEventoClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(CadastroEventoPage));
        }

        private async void OnAgendaInclusivaClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AgendaInclusivaPage));
        }

        private async void OnBuscaProdutoClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(BuscaProdutoPage));
        }


    }
}
