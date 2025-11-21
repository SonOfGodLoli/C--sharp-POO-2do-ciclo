using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_clase_1_semana_10
{
    internal class TransferenciaBancaria:IPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago por Transferencia por S/. {monto}");
            Console.WriteLine("Recibiendo Dinero...");
            Console.WriteLine("Pago por Transferencia completado con exito.\n");
        }
    }
}
