using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.src
{
    public class Calc : IOperacoes
    {
        public double Dividir(double a, double b)
        {
            return a / b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Subtrair(double a, double b)
        {
            return a - b;
        }
    }
}
