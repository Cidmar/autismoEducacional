using autismoEducacional.Views;

namespace autismoEducacional
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Views.CadastroEventoPage), typeof(Views.CadastroEventoPage));
            Routing.RegisterRoute(nameof(Views.AgendaInclusivaPage), typeof(Views.AgendaInclusivaPage));
            Routing.RegisterRoute(nameof(Views.BuscaProdutoPage), typeof(Views.BuscaProdutoPage));
            Routing.RegisterRoute(nameof(Views.ResumoEventoPage), typeof(Views.ResumoEventoPage));
        }
    }
}
