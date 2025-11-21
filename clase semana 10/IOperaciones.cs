using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_semana_10
{
    interface IOperaciones
    {
        int Sumar(int a, int b);
        int Restar(int a, int b);
        int Producto(int x, int y);
        double Division(double x, double y);
    }
}
