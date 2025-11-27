using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Calificada_Nº2
{
    internal class Sierra : Herramienta ,IComportamiento
    {
        public void NombreMarca(string marca)
        {
            Console.WriteLine($"Herramienta de marca: {marca}");
        }

        public override void Encender()
        {
            Console.WriteLine("La Sierra esta encendiendo");
        }

        public override void Accion()
        {
            Console.WriteLine("La Sierra esta cortando");
        }
        public override void RecargarBateria()
        {
            Console.WriteLine("Recargando batería de la Sierra...");
        }

        public override void Apagar()
        {
            Console.WriteLine("La Sierra se ha detenido");
            Console.WriteLine("=========================\n");
        }
    }
}
