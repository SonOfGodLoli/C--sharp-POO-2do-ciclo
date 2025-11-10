//Crea un programa en C# que modele una jerarquía de
//personas dentro de una institución educativa.
//Debe existir una clase base llamada Persona
//con un método MostrarRol().
//A partir de ella, define tres clases hijas:
//Alumno, Profesor y Director.
//Cada clase debe sobrescribir el método MostrarRol()
//para mostrar un mensaje distinto según su rol.
//En el método Main(), crea un objeto de cada clase e
//imprime su función en la institución.

using TAREA_9_11_25_3;

Alumno objAlumno1 = new Alumno();
Profesor objProfesor1 = new Profesor();
Director objDirector1 = new Director();


Console.WriteLine("Ingrese su nombre");
objAlumno1.Nombre=Console.ReadLine();
Console.WriteLine("Ingrese su Edad");
objAlumno1.Edad = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
objAlumno1.MostrarRol();
Console.WriteLine();
objAlumno1.MostrarInfo();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Ingrese su nombre");
objProfesor1.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese su Edad");
objProfesor1.Edad = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
objProfesor1.MostrarRol();
Console.WriteLine();
objProfesor1.MostrarInfo();
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Ingrese su nombre");
objDirector1.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese su Edad");
objDirector1.Edad = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
objDirector1.MostrarRol();
Console.WriteLine();
objDirector1.MostrarInfo();
