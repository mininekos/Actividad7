using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad7
{
    internal class Persona
    {
        public String? Nombre { get; set; } = null;
        public int Edad { get; set; }

        public Persona(string? nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public String Imprimir() {
            return Nombre+" "+ Edad;
        }
    }
}
