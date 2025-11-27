using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_semana_10
{
    internal class Calculadora:IOperaciones
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Producto(int a, int b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            return a / b;
        }
    }
}
