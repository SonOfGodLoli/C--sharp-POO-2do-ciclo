using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Calificada_Nº2
{
    internal interface IComportamiento
    {
        public void NombreMarca(string marca);
        public void Encender();
        void Accion();
        void RecargarBateria();
        void Apagar();
    }
}

