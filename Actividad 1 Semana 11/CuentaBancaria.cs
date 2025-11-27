using Actividad_1_semana_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1_semana_11
{
    internal class CuentaBancaria
    {
        private string titular = "";
        private int numerodecuenta;
        private decimal saldo;

        public string Titular { get => titular; set => titular = value; }
        public int Numerodecuenta { get => numerodecuenta; set => numerodecuenta = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }

        public void Depositar(decimal monto)
        {
            if (monto < 0 || monto > 999999999)
            {
                throw new Exception("Ingrese un monto valido");
            }
            Saldo += monto;  
        }

        public void Retirar(decimal monto)
        {
            if (monto <= 0 || monto > saldo)
            {

                throw new FondosInsuficientesException("Ingrese un monto valido para poder retirar");
            }
            Saldo -= monto;
        }

        public void MostarInfo()
        {
            Console.WriteLine("==== BANCO JUECEPE ====");
            Console.WriteLine($"|Numero de Cuenta: \t{Numerodecuenta}|");
            Console.WriteLine($"|Nombre del titular: \t{Titular}|");
            Console.WriteLine($"|Saldo:\t\t{Saldo} |");
            Console.WriteLine($"======================");
        }
    }
}
