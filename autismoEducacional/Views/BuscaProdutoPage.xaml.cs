using autismoEducacional.ViewModels;

namespace autismoEducacional.Views
{
    public partial class BuscaProdutoPage : ContentPage
    {
        private ProdutoViewModel viewModel;

        public BuscaProdutoPage()
        {
            InitializeComponent();
            viewModel = new ProdutoViewModel();
            BindingContext = viewModel;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            viewModel.FiltrarProdutos(e.NewTextValue);
        }
    }
}
