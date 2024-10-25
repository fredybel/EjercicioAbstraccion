using EjercicioAbstraccion;

Triangulo triangulo = new Triangulo();
int opcion;

Console.WriteLine("****************************************");
Console.WriteLine("*                  MENU                *");
Console.WriteLine("* 1.      Area de un triangulo         *");
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
}
