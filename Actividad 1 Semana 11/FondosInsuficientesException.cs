using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_semana_11
{
    internal class FondosInsuficientesException : Exception
    {
        public FondosInsuficientesException(string mensaje) : base(mensaje)
        {

        }
    }
}

