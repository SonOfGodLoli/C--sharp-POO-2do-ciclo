using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_clase_1_semana_10
{
    internal class Efectivo:IPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago en efectivo por S/. {monto}");
            Console.WriteLine("Recibiendo Dinero...");
            Console.WriteLine("Pago en efectivo completado con exito.\n");
        }
    }
}
