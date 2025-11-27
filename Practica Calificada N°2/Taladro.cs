using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Calificada_Nº2
{
    internal class Taladro : Herramienta, IComportamiento
    {
        public void NombreMarca(string marca)
        {
            Console.WriteLine($"Herramienta de marca: {marca}");
        }
        public override void Encender()
        {
            Console.WriteLine("El Taladro esta encendiendo");
        }

        public override void Accion()
        {
            Console.WriteLine("El Taladro esta Perforando");
        }

        public override void RecargarBateria()
        {
            Console.WriteLine("Recargando batería del Taladro...");
        }

        public override void Apagar()
        {
            Console.WriteLine("El Taladro se ha detenido");
            Console.WriteLine("=========================\n");
        }
    }
}
