using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_9_11_25_4
{
    internal class ProductoAlimento:Producto
    {
        public override double CalcularDescuento()
        {
            return Precio * 0.05;
        }
    }
}
