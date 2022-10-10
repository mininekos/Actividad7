using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad7
{
    internal class Triangulo
    {
        public Double Lado { get; set; }
        public Double Base { get; set; }
        public Double Altura { get; set; }

        public Triangulo(Double lado, Double basse)
        {
            Lado= lado;
            Base = basse;
            Altura = Math.Round(Math.Sqrt(Math.Pow(Lado,2)- Math.Pow((Base/2), 2)), 2) ;
        }

        public Double Perimetro() { 
            return Lado+Lado+Base;
        }

        public double Area() {
            return (Altura*Base)/2;
        }

    }
}
