using Actividad_1_semana_11;

CuentaBancaria objC1 = new CuentaBancaria();

try
{
    Console.WriteLine("Ingrese el nombre del titular de la cuenta");
    objC1.Titular = Console.ReadLine();
    Console.WriteLine("\n");
    Console.WriteLine("Ingrese el numero de cuenta: formato 'xxxxxx' ");
    objC1.Numerodecuenta = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");
    Console.WriteLine("Ingrese el saldo inicial : ");
    objC1.Saldo = decimal.Parse(Console.ReadLine());
    Console.WriteLine("\n");

    while (true)
    {
        Console.WriteLine("Ingrese el tipo de operacion que desea realizar: | Retiro - 1 | Deposito - 2 | Salir - 3 |");
        Console.WriteLine("\n");
        string x = Console.ReadLine();
        Console.WriteLine("\n");
        if (x == "1")
        {
            Console.WriteLine("Ingrese el monto a retirar");
            decimal monto = decimal.Parse(Console.ReadLine());
            objC1.Retirar(monto);
            objC1.MostarInfo();
        }
        else if (x == "2")
        {
            Console.WriteLine("Ingrese el monto a depositar");
            decimal monto = decimal.Parse(Console.ReadLine());
            objC1.Depositar(monto);
            objC1.MostarInfo();
        }
        else if (x == "3")
        {
            Console.WriteLine("¡Gracias por su visita!");
            break;

        }
        else
        {
            Console.WriteLine("Opcion invalida") ;
        }
    }
}
catch (FondosInsuficientesException ex)
{
    Console.WriteLine("Error PErsonalizado : " + ex.Message);
}
catch (FormatException)
{
    Console.WriteLine("Error: Debe ingresar un numero valido");
}
catch (Exception ex)
{
    Console.WriteLine("Ocurrio un error inesperado" + ex.Message);
}
