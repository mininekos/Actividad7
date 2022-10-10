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
            
        }
    }
}
