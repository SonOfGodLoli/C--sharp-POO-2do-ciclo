using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_9_11_25
{
    internal class Empleado
    {
        private string nombre;
        private double sueldobase;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Sueldobase { get => sueldobase; set => sueldobase = value; }

        public virtual double CalcularSueldo()
        {
            return 0;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Nombre del Empleado: "+ Nombre);
            Console.WriteLine("Sueldo Total: " +Sueldobase);
        }
    }
}
