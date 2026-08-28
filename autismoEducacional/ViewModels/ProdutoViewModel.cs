using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using autismoEducacional.Models;

namespace autismoEducacional.ViewModels
{
    public class ProdutoViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Produto> _produtos;
        private ObservableCollection<Produto> _produtosFiltrados;

        public ObservableCollection<Produto> ProdutosFiltrados
        {
            get => _produtosFiltrados;
            set { _produtosFiltrados = value; OnPropertyChanged(); }
        }

        public ProdutoViewModel()
        {
            _produtos = new ObservableCollection<Produto>
            {
                new Produto { Nome = "Caderno", Preco = 15 },
                new Produto { Nome = "Lápis", Preco = 2 },
                new Produto { Nome = "Borracha", Preco = 3 },
                new Produto { Nome = "Mochila", Preco = 120 }
            };

            ProdutosFiltrados = new ObservableCollection<Produto>(_produtos);
        }

        public void FiltrarProdutos(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                ProdutosFiltrados = new ObservableCollection<Produto>(_produtos);
            else
                ProdutosFiltrados = new ObservableCollection<Produto>(
                    _produtos.Where(p => p.Nome.ToLower().Contains(texto.ToLower())));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
