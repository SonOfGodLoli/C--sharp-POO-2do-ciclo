using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_9_11_25
{
    internal class empleadoTiempoCompleto:Empleado
    {

        public override double CalcularSueldo()
        {
            
            Sueldobase = (Sueldobase * 0.20) + Sueldobase;
            return Sueldobase;
        }
    }
}
