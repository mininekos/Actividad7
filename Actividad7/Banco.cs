using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad7
{
    internal class Banco
    {
        public Cliente[] clientes { get; set; } = { new Cliente("1","Manu",1000),
        new Cliente("2","Adri",2000),
        new Cliente("3","Pablo",1000000)};

        public void Operar() {
            String dniCliente,operacion="";
            Cliente cliente;
            Console.WriteLine("Introduzca un cliente sobre el que operar");
            dniCliente = Console.ReadLine();

            cliente=SeleccionCliente(dniCliente);
            if (cliente == null)
            {
                Console.WriteLine("cliente nmo valido");
            }
            else {
                do
                {
                    Console.WriteLine("pulse 1 para ingresar, 2 para retirar y 3 para salir");
                    operacion=Console.ReadLine();

                } while (operacion!="3");
                
            }
        }

        Cliente SeleccionCliente(String dni) {
            foreach (Cliente cliente in clientes) {
                if (cliente.Dni.Equals(dni)) return cliente;
            }
            return null;
        }
    }
}
