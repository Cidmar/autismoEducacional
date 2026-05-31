namespace autismoEducacional.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Models.Evento eventoCadastrado)
        {
            InitializeComponent();
            // Vincula os dados digitados na tela anterior para serem exibidos nesta
            BindingContext = eventoCadastrado;
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Volta para a tela de cadastro
        }
    }
}