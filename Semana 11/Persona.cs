using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_11
{
        internal class Persona
        {
            private string nombre = "";
            private int edad;

            public string Nombre { get => nombre; set => nombre = value; }
            public int Edad { get => edad; set => edad = value; }

            public void asignarEdad(int x)
            {
                if (x < 0 || x > 120)
                {
                    // Lanzamos nuestra exception personalizada
                    throw new EdadInvalidaException("La edad debe estar entre 0 y 120 años.");
                }

                edad = x;
            }
        }
    }


