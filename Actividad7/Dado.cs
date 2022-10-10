using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad7
{
    internal class Dado
    {
        Random random = new Random();
        public int Valor { get; set; }

        public  void Tirar() => Valor = random.Next(1, 7);

        public void Imprimir() {
            Tirar();
            Console.WriteLine("La Tirada del dado es:" + Valor);
        }
    }
}
