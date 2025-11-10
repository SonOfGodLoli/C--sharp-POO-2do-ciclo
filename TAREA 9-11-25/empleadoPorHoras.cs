using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_9_11_25
{
    internal class empleadoPorHoras:Empleado
    {
        private double horasT;
        private double precioH;

        public double HorasT { get => horasT; set => horasT = value; }
        public double PrecioH { get => precioH; set => precioH = value; }

        public override double CalcularSueldo()
        {
            Console.WriteLine("Ingrese el Precio por Hora : ");
            PrecioH = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese las Horas Trabajadas : ");
            HorasT = Convert.ToDouble(Console.ReadLine());
            return Sueldobase = PrecioH * HorasT;
        }
    }
}
