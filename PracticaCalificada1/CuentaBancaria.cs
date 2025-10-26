using System;

namespace BancoPOO
{
    internal class CuentaBancaria
    {
        // Atributos privados
        private string titular;
        private double saldo;
        private string tipoCuenta;

        // Propiedades con GET/SET
        public string Titular
        {
            get => titular;
            set => titular = !string.IsNullOrWhiteSpace(value) ? value : "Cliente sin nombre";
        }

        public double Saldo
        {
            get => saldo;
            set
            {
                if (value >= 0)
                    saldo = value;
                else
                    Console.WriteLine("El saldo no puede ser negativo.");
            }
        }

        public string TipoCuenta
        {
            get => tipoCuenta;
            set
            {
                string tipo = value.ToLower();
                if (tipo == "ahorros" || tipo == "corriente")
                {
                    tipoCuenta = value;
                }
                else
                {
                    Console.WriteLine("Tipo de cuenta no válido. Use 'Ahorros' o 'Corriente'.");
                }
            }
        }


        // Métodos no estáticos
        public void Depositar(double monto)
        {
            if (monto > 0)
            {
                saldo += monto;
                Console.WriteLine($"Depósito realizado. Nuevo saldo: {saldo:C2}");
            }
            else
            {
                Console.WriteLine("Monto inválido para depósito.");
            }
        }

        public void Retirar(double monto)
        {
            if (monto > 0 && monto <= saldo)
            {
                saldo -= monto;
                Console.WriteLine($"Retiro realizado. Nuevo saldo: {saldo:C2}");
            }
            else
            {
                Console.WriteLine("Monto inválido o saldo insuficiente.");
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Tipo de cuenta: {tipoCuenta}");
            Console.WriteLine($"Saldo actual: {saldo:C2}");
        }

        // Método estático (transferencia)
        public static void Transferir(CuentaBancaria origen, CuentaBancaria destino, double monto)
        {
            if (monto > 0 && monto <= origen.saldo)
            {
                origen.saldo -= monto;
                destino.saldo += monto;
                Console.WriteLine($"Transferencia de {monto:C2} completada.");
            }
            else
            {
                Console.WriteLine("Monto inválido o saldo insuficiente para transferir.");
            }
        }
    }
}
