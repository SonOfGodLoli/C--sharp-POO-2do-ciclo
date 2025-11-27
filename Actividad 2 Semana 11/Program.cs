using Actividad_2_Semana_11;

Producto objP1  = new Producto();

while (true) {

    try
    {
        Console.WriteLine("Ingrese el nombre del producto:");
        objP1.Nombre = Console.ReadLine();
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocurrio un error inesperado: " + ex.Message);
    }
}

while (true)
{
    try
    {
        Console.WriteLine("Ingrese el codigo de producto");
        objP1.Codigo = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Debe ingresar un numero valido");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocurrio un error inesperado: " + ex.Message);
    }
}

while (true)
{
    try
    {
        Console.WriteLine("Ingrese el precio del producto");
        decimal precio = decimal.Parse(Console.ReadLine());
        objP1.EstablecerPrecio(precio);
        objP1.MostrarInformacion();
        break;
    }
    catch (PrecioInvalidoException ex)
    {
        Console.WriteLine("Error Personalizado: " + ex.Message);
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Debe ingresar un numero valido");
    }
}
        