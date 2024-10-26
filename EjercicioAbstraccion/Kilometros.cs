
namespace EjercicioAbstraccion
{
    public class Kilometros : FormulaMatematica
    {
        public double metros {  get; set; }

        public override double Calcular()
        {
           return metros * 0.001;
        }
        
    }
}
