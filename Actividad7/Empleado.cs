using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad7
{
    internal class Empleado : Persona
    {
        public Double Sueldo { get; set; }

        public Empleado(string nombre, int edad, double sueldo) : base(nombre,edad)
        {   
            Sueldo = sueldo;
        }

        public String Imprimir() {
            return base.Imprimir()+" "+Sueldo;
        }
    }
}
