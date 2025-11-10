//Crea una clase Vehiculo con un método virtual
//EncenderMotor() que muestre un mensaje general.
//Crea una clase Auto que sobrescriba este método y utilice
//base.EncenderMotor() para mostrar el mensaje original antes de uno propio.
//Agrega también una clase Moto que solo muestre su propio mensaje.

using TAREA_9_11_25_2;

Auto objAuto1 = new Auto();
Moto objMoto1 = new Moto();

Console.WriteLine("Vehiculos preparandose");
Console.WriteLine("");
objAuto1.EncenderMotor();
Console.WriteLine("");
objMoto1.EncenderMotor();