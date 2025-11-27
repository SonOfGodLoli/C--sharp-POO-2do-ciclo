using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Calificada_Nº2
{
    abstract class Herramienta
    {
        public virtual void Encender()
        {
            Console.WriteLine("Encendiendo....");
        }
        public virtual void Accion()
        {
            Console.WriteLine("Funcionando....");
        }
        public virtual void RecargarBateria()
        {
            Console.WriteLine("Recargando batería del dispositivo...");
        }
        public virtual void Apagar()
        {
            Console.WriteLine("Apagando....");
        }
    }
}
