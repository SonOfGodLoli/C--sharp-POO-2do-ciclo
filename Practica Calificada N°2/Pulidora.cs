using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Calificada_Nº2
{
    internal class Pulidora : Herramienta,  IComportamiento
    {
        public void NombreMarca(string marca)
        {
            Console.WriteLine($"Herramienta de marca: {marca}");
        }
        public override void Encender()
        {
            Console.WriteLine("La Pulidora esta encendiendo");
        }

        public override void Accion()
        {
            Console.WriteLine("La pulidora esta sacando brillo");
        }

        public override void RecargarBateria()
        {
            Console.WriteLine("Recargando batería de la Pulidora...");
        }
        public override void Apagar()
        {
            Console.WriteLine("La pulidora se ha detenido");
            Console.WriteLine("=========================\n");
        }
    }
}
