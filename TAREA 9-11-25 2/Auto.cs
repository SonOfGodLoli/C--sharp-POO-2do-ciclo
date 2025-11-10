using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_9_11_25_2
{
    internal class Auto:Vehiculo
    {
        public override void EncenderMotor()
        {
            base.EncenderMotor();
            Console.WriteLine("El Auto esta listo para avanzar!");
        }
    }
}
