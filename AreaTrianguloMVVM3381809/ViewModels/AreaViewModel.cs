using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AreaTrianguloMVVM3381809.ViewModels
{
    public class AreaViewModel : INotifyPropertyChanged
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;
        private double area;

        public event PropertyChangedEventHandler? PropertyChanged;

         public double LadoA
        {
            get => ladoA;
            set
            {
                ladoA = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }

        public double LadoB
        {
            get => ladoB;
            set
            {
                ladoB = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }

        public double LadoC
        {
            get => ladoC;
            set
            {
                ladoC = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Area));
            }
        }

        public double Area
        {
            get
            {
                var triangulo = new AreaViewModel { LadoA = ladoA, LadoB = ladoB, LadoC = ladoC };
                return triangulo.CalcularArea();
            }
        }

        public double CalcularArea()
        {
            // Usando la fórmula de Herón para calcular el área
            double semiPerimetro = (LadoA + LadoB + LadoC) / 2;
            double area = Math.Sqrt(semiPerimetro * (semiPerimetro - LadoA) * (semiPerimetro - LadoB) * (semiPerimetro - LadoC));
            return area;
        }

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
