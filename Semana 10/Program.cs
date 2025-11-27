using clase_semana_10;

IOperaciones objOper1 = new Calculadora();

Console.WriteLine("Ingrese un numero");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un numero");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Suma : " + n1 + "+" + n2 + "=" + objOper1.Sumar(n1,n2));
Console.WriteLine("Resta : " + n1 + "-" + n2 + "=" + objOper1.Restar(n1, n2));
Console.WriteLine("Multiplicaciòn : " + n1 + "x" + n2 + "=" + objOper1.Producto(n1, n2));
Console.WriteLine("Division : " + n1 + "/" + n2 + "=" + objOper1.Division(n1, n2));

/*Console.WriteLine("4" + "+" + "5" + "=" + objOper1.Sumar(4, 5));*/