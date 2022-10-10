using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad7
{
    internal class Cliente
    {

        public String Dni { get; set; }
        public String Nombre { get; set; }
        public Double Cantidad { get; set; }

        public Cliente(String dni, String nombre, Double cantidad)
        {
            Dni = dni;
            Nombre = nombre;
            Cantidad = cantidad;
        }

        public void Ingresar(Double cantidad){
            if (cantidad > 0)
                Cantidad += cantidad;
        }

        public void Extraer(Double cantidad){
            if (cantidad < Cantidad && cantidad > 0)
                Cantidad -= cantidad;
            else
                Console.WriteLine("Saldo insuciente");
        }

        public void ConsultarSaldo(){
            Console.WriteLine(Cantidad);
        }
    }
}
