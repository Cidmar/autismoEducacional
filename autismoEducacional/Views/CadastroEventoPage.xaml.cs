using autismoEducacional.Models;
using autismoEducacional.Views;
using System;

namespace autismoEducacional.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        public Evento NovoEvento { get; set; }

        public CadastroEventoPage()
        {
            InitializeComponent();

            NovoEvento = new Evento();
            BindingContext = NovoEvento;
        }

        private async void OnCalcularEAvancarClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NovoEvento.Nome))
            {
                await DisplayAlertAsync("Erro", "Por favor, insira o nome do evento.", "OK");
                return;
            }

            if (NovoEvento.DataTermino < NovoEvento.DataInicio)
            {
                await DisplayAlertAsync("Erro", "A data de término não pode ser anterior à data de início.", "OK");
                return;
            }

            // ESSA LINHA EMPURRA A NOVA TELA REPASSANDO OS DADOS JÁ CALCULADOS
            await Navigation.PushAsync(new ResumoEventoPage(NovoEvento));
        }
    }
}