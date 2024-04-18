using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class A:IbasicMathOperations
    {
        public double Minus(double x1, double x2)
        {
            return x1 - x2;
        }
        
        public double Plus(double x1, double x2)
        {
            return x1 + x2;
        }

        public double Divide(double x1, double x2)
        {
            return x1 / x2;
        }
      
        public double Multiply(double x1, double x2)
        {
            return x1 * x2;
        }

    }
}
