using Practica_Calificada_Nº2;

void ProbarHerramienta(IComportamiento herramienta, string marca)
{
    herramienta.NombreMarca(marca);
    herramienta.Encender();
    herramienta.Accion();
    herramienta.RecargarBateria();
    herramienta.Apagar();
}

Console.WriteLine("===========================");
Console.WriteLine("  PRUEBA DE HERRAMIENTA");
Console.WriteLine("===========================\n");

ProbarHerramienta(new Taladro(), "Bosch");
ProbarHerramienta(new Sierra(), "Makita");
ProbarHerramienta(new Pulidora(), "Dewalt");

Console.WriteLine("===========================");
Console.WriteLine("  FIN DE LA DEMOSTRACIÓN");
Console.WriteLine("===========================");

