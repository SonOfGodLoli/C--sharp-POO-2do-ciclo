using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_9_11_25_4
{
    internal class Producto
    {
        private string nombre;
        private double precio;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }

        public virtual double CalcularDescuento()
        {
            return Precio;
        }
    }
}
