using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_9_11_25_3
{
    internal class Persona
    {
        private string nombre, rol;
        private double edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rol { get => rol; set => rol = value; }
        public double Edad { get => edad; set => edad = value; }

        public virtual void MostrarRol()
        {
            Console.WriteLine("Asignacion de Rol");
        }

        public void MostrarInfo()
        {
            Console.WriteLine("-------Datos--------");
            Console.WriteLine("Nombre : " + Nombre);
            Console.WriteLine("Edad : " + Edad + " Años");
            Console.WriteLine("Rol : " + Rol);
        }
    }
}
