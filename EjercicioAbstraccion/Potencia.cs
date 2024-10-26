
namespace EjercicioAbstraccion
{
    public class Potencia: FormulaMatematica
    {
        public double Numero { get; set; }
        public double Exponente { get; set; }


        public override double Calcular()
        {
            return Math.Pow(Numero, Exponente);
        }

    }
}
