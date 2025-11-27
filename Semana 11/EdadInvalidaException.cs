using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11
{
    internal class EdadInvalidaException : Exception
    {
        public EdadInvalidaException(string mensaje)
            : base(mensaje) //Llamada al constructor de la clase base (Exception)
        {

        }
    }
}
