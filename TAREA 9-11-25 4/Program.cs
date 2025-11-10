//Crea una clase Producto con los atributos Nombre y Precio,
//y un método virtual CalcularDescuento().
//Crea dos clases hijas:
//  ProductoAlimento: aplica un descuento del 5%.
//  ProductoElectronico: aplica un descuento del 10%.
//En el Main, solicita al usuario que ingrese 3 productos de cada tipo,
//guárdalos en un arreglo y muestra el precio final después del descuento.

using System.ComponentModel.DataAnnotations;
using TAREA_9_11_25_4;
using static System.Runtime.InteropServices.JavaScript.JSType;

Producto[] productos = new Producto[6];

Console.WriteLine("-----Tiendita tu Tia Dina-----");
Console.WriteLine("--Ingreso de Alimentos--");
for (int i = 0; i < 3; i++)
{
    ProductoAlimento objAlimento = new ProductoAlimento();
    Console.WriteLine("Ingrese el nombre del alimento numero " + (i + 1));
    objAlimento.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el precio del alimento numero " + (i + 1));
    objAlimento.Precio = Convert.ToDouble(Console.ReadLine());
    productos [i] = objAlimento;
    Console.WriteLine("");
}
Console.WriteLine("");
Console.WriteLine("--Ingreso de electronicos--");
for (int i = 3 ; i < 6; i++)
{
    ProductoElectronico objElectronico = new ProductoElectronico();
    Console.WriteLine("Ingrese el nombre del electronico numero " + (i - 2));
    objElectronico.Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el precio del electronico numero " + (i - 2));
    objElectronico.Precio = Convert.ToDouble(Console.ReadLine());
    productos[i] = objElectronico;
    Console.WriteLine("");
}

double descuentoA = 0;
double totalA = 0;
string listaA = "";

for ( int i = 0; i<3 ; i++)
{
    descuentoA += productos[i].CalcularDescuento();
    totalA += productos[i].Precio;
    listaA += "\t" + productos[i].Nombre + "\t" + productos[i].Precio + "\n";
}

double descuentoE = 0;
double totalE = 0;
string listaE = "";

for (int i = 3; i < 6; i++)
{
    descuentoE += productos[i].CalcularDescuento();
    totalE += productos[i].Precio;
    listaE += "\t" + productos[i].Nombre + "\t" + productos[i].Precio + "\n";
}
Console.WriteLine("");
Console.WriteLine("Resumen de la venta");
Console.WriteLine("Resumen Alimentos : ");
Console.WriteLine("Nombre" + "\t" + "Precio");
Console.WriteLine(listaA);
Console.WriteLine("-------------------------");
Console.WriteLine("Precio total : " + "\t" + totalA);
Console.WriteLine("Descuento ; " + "\t" + descuentoA);
Console.WriteLine("Precio Final : " + "\t" + (totalA - descuentoA));
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Resumen Electronicos : ");
Console.WriteLine("Nombre" + "\t" + "Precio");
Console.WriteLine(listaE);
Console.WriteLine("-------------------------");
Console.WriteLine("Precio total : " + "\t" + totalE);
Console.WriteLine("Descuento ; " + "\t" + descuentoE);
Console.WriteLine("Precio Final : " + "\t" + (totalE - descuentoE));
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("-------------------------");
Console.WriteLine($"Total a Pagar : {(((totalA + totalE)-descuentoA)-descuentoE)} soles.");


