using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace autismoEducacional.Models
{
    public class Evento : INotifyPropertyChanged
    {
        private string nome;
        private DateTime dataInicio = DateTime.Today;
        private DateTime dataTermino = DateTime.Today.AddDays(1);
        private int numeroParticipantes;
        private string local;
        private decimal custoPorParticipante;

        public string Nome
        {
            get => nome;
            set { nome = value; OnPropertyChanged(); }
        }

        public DateTime DataInicio
        {
            get => dataInicio;
            set
            {
                dataInicio = value;
                OnPropertyChanged();
                // Força a atualização dos dias calculados quando a data muda
                OnPropertyChanged(nameof(DuracaoDias));
            }
        }

        public DateTime DataTermino
        {
            get => dataTermino;
            set
            {
                dataTermino = value;
                OnPropertyChanged();
                // Força a atualização dos dias calculados quando a data muda
                OnPropertyChanged(nameof(DuracaoDias));
            }
        }

        public string Local
        {
            get => local;
            set { local = value; OnPropertyChanged(); }
        }

        public int NumeroParticipantes
        {
            get => numeroParticipantes;
            set
            {
                numeroParticipantes = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CustoTotal)); // Atualiza o custo total
            }
        }

        public decimal CustoPorParticipante
        {
            get => custoPorParticipante;
            set
            {
                custoPorParticipante = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(CustoTotal)); // Atualiza o custo total
            }
        }

        // REQUISITO 2: Usando TimeSpan para calcular a diferença em dias
        public int DuracaoDias
        {
            get
            {
                TimeSpan diferenca = DataTermino.Date - DataInicio.Date;
                return diferenca.Days < 0 ? 0 : diferenca.Days;
            }
        }

        // REQUISITO 1: Lógica do Custo Total calculado
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;

        // Evento necessário para atualizar as telas no MAUI
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}