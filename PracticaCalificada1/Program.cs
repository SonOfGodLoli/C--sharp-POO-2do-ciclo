using System;

namespace BancoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("   SISTEMA BANCARIO - POO C# ");
            Console.WriteLine("=====================================\n");

            
            CuentaBancaria cuenta1 = new CuentaBancaria();
            CuentaBancaria cuenta2 = new CuentaBancaria();

            
            Console.WriteLine("Ingrese datos de la primera cuenta:");
            Console.Write("Titular: ");
            cuenta1.Titular = Console.ReadLine();
            Console.Write("Tipo de cuenta (Ahorros o Corriente): ");
            cuenta1.TipoCuenta = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            cuenta1.Saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese datos de la segunda cuenta:");
            Console.Write("Titular: ");
            cuenta2.Titular = Console.ReadLine();
            Console.Write("Tipo de cuenta (Ahorros o Corriente): ");
            cuenta2.TipoCuenta = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            cuenta2.Saldo = double.Parse(Console.ReadLine());

            int opcion = 0;

            
            do
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("   MENÚ DE OPERACIONES BANCARIAS ");
                Console.WriteLine("=====================================");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Transferir");
                Console.WriteLine("4. Mostrar Datos");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Seleccione cuenta (1 o 2): ");
                        int cDep = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese monto a depositar: ");
                        double montoDep = double.Parse(Console.ReadLine());
                        if (cDep == 1)
                            cuenta1.Depositar(montoDep);
                        else
                            cuenta2.Depositar(montoDep);
                        break;

                    case 2:
                        Console.Write("Seleccione cuenta (1 o 2): ");
                        int cRet = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese monto a retirar: ");
                        double montoRet = double.Parse(Console.ReadLine());
                        if (cRet == 1)
                            cuenta1.Retirar(montoRet);
                        else
                            cuenta2.Retirar(montoRet);
                        break;

                    case 3:
                        Console.WriteLine("Seleccione el sentido de la transferencia:");
                        Console.WriteLine("1. De cuenta 1 a cuenta 2");
                        Console.WriteLine("2. De cuenta 2 a cuenta 1");
                        int direccion = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese monto a transferir: ");
                        double montoTrans = double.Parse(Console.ReadLine());

                        if (direccion == 1)
                            CuentaBancaria.Transferir(cuenta1, cuenta2, montoTrans);
                        else
                            CuentaBancaria.Transferir(cuenta2, cuenta1, montoTrans);
                        break;

                    case 4:
                        Console.WriteLine("\nESTADO DE LAS CUENTAS:");
                        cuenta1.MostrarDatos();
                        cuenta2.MostrarDatos();
                        break;

                    case 5:
                        Console.WriteLine("Gracias por usar el sistema. Hasta pronto.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }
    }
}
