using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_clase_1_semana_10
{
    internal class Caja
    {
        public void RealizarPago(IPago metodoPago, double monto)
        {
            Console.WriteLine("Inicializando Operacion....");
            metodoPago.ProcesarPago(monto);
            Console.WriteLine("Operacion finalizada.\n");
        }
    }
}
