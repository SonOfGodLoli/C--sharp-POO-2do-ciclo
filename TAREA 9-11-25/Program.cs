// 1. Crea una clase base Empleado con los atributos Nombre y SueldoBase,y un método virtual
// CalcularSueldo().
// Crea dos clases derivadas:
//  • empleadoTiempoCompleto: que agregue un bono fijo del 20 %.
//  • empleadoPorHoras: que reciba horas trabajadas y pago por hora.

using TAREA_9_11_25;

empleadoTiempoCompleto objEmpleadoTC1 = new empleadoTiempoCompleto();
empleadoPorHoras objEmpleadoPH1 = new empleadoPorHoras();

Console.WriteLine("---Sistema de calculo de suelo---");
Console.WriteLine("Empleado de Tiempo Completo : --");
Console.WriteLine("Ingrese su nombre: ");
objEmpleadoTC1.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese su sueldo Base :");
objEmpleadoTC1.Sueldobase = Convert.ToDouble(Console.ReadLine());
objEmpleadoTC1.CalcularSueldo();
objEmpleadoTC1.MostrarInfo();
Console.WriteLine("");
Console.WriteLine("Empleado por Horas : --");
Console.WriteLine("Ingrese su nombre: ");
objEmpleadoPH1.Nombre = Console.ReadLine();
objEmpleadoPH1.Sueldobase = objEmpleadoPH1.CalcularSueldo();
objEmpleadoPH1.MostrarInfo();
