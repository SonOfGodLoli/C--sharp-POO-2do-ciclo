using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2_Semana_11
{
    internal class Producto
    {
        private int codigo;
        private string nombre;
        private decimal precio;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
    

        public void EstablecerPrecio(decimal precio)
        {
            if (precio <= 0)
            {
                throw new PrecioInvalidoException("El precio no es valido");
            }

            Precio = precio;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("======= Bodega Panchita =======");
            Console.WriteLine($"Nombre de Producto: {Nombre} ");
            Console.WriteLine($"Codigo de Producto: {Codigo}");
            Console.WriteLine($"Precio del producto: {Precio}");
            Console.WriteLine("==============================");
        }
    }
}