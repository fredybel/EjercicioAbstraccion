using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public  class Triangulo  :FormulaMatematica
    {
        public double Base {  get; set; }
        public double Altura {  get; set; }


        public override double Calcular()
        {
           return (Base * Altura) / 2;
        }

       
    }
}
