using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2_Semana_11
{
    internal class PrecioInvalidoException : Exception
    {
        public PrecioInvalidoException(string mensaje)
            : base(mensaje)
        {

        }
    }
}
