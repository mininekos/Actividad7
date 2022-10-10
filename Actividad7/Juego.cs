using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad7
{
    internal class Juego
    {
        public Dado[] dados = { new Dado(), new Dado(), new Dado()};

        public void Jugar() {
            foreach (var dado in dados)
            {
                dado.Tirar();
                dado.Imprimir();
            }
            if (dados[0].Valor== dados[1].Valor && dados[0].Valor== dados[2].Valor) {
                Console.WriteLine("Ha ganado");
            }
            else
            {
                Console.WriteLine("Ha Perdido");
            }
        }
    }
}
