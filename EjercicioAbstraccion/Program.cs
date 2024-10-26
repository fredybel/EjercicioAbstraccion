using EjercicioAbstraccion;

Triangulo triangulo = new Triangulo();
Kilometros kilometros = new Kilometros();
Potencia potencia = new Potencia();
int opcion;

Console.WriteLine("****************************************");
Console.WriteLine("*                  MENU                *");
Console.WriteLine("* 1.      Area de un triangulo         *");
Console.WriteLine("* 2. Convertir Metros a Kilometros     *");
Console.WriteLine("* 3.      Potencia de numero           *");
Console.WriteLine("****************************************");
Console.WriteLine("Escoja la opción:");
opcion = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
switch (opcion)
{
    case 1:
        Console.WriteLine("Escriba la base del triangulo: ");
        triangulo.Base = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba la altura del triangulo: ");
        triangulo.Altura = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine();
        triangulo.Imprimir();
        break;

    case 2:
        Console.WriteLine("          Mts a Kms         ");
        Console.WriteLine("Esciba la cantidad en metros");

        Console.WriteLine();
        kilometros.metros = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        kilometros.Imprimir();
        break;

    case 3:
        Console.WriteLine("        Calcular la potencia de un numero        ");
        Console.WriteLine("Esciba un numero");
        potencia.Numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba cuantas veces quiere elevar el numero");
        potencia.Exponente = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        potencia.Imprimir();
        break;




}
