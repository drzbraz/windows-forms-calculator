using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    class Raiz_Quadrada: Operação
    {
        public override double Calcula(double num1, double num2=0)
        {
            return Math.Sqrt(num1);
        }
    }
}
