using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    class Divisão: Operação
    {
        public override double Calcula(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
