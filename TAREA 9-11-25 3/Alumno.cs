using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_9_11_25_3
{
    internal class Alumno:Persona
    {
        public override void MostrarRol()
        {
            Console.Write("Su Rol es el de Estudiante.");
            Rol = "Estudiante";
        }
    }
}
