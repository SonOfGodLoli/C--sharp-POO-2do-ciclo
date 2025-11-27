using Semana_11;

Persona p = new Persona();
p.Nombre = "Carlos";

try
{
    Console.WriteLine("Ingrese la edad de la persona: ");
    int edadIngresada = int.Parse(Console.ReadLine());

    p.asignarEdad(edadIngresada);

    Console.WriteLine($"Edad asignada Correctamente:{p.Edad}");
}
catch (EdadInvalidaException ex)
{
    Console.WriteLine("Error Personalizado: " + ex.Message);
}
catch (FormatException)
{
    Console.WriteLine("Error: Debe ingresar un numero valido");
}
catch (Exception ex)
{
    Console.WriteLine("Ocurrio un error inesperado: " + ex.Message);
}