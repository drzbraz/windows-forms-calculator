using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    class Potenciação: Operação
    {
        public override double Calcula(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}
