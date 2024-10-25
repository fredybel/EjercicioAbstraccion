
namespace EjercicioAbstraccion
{
    public abstract class FormulaMatematica
    {
        public abstract double Calcular();
        public void Imprimir()
        {
            Console.WriteLine($"Resultado: {Calcular()}");
        }
    }
}
