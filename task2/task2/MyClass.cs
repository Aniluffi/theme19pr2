using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class MyClass:Iinterface
    {
        public double PI()
        {
            return Math.PI;
        }

        public int X(int x)
        {
            return x;
        }

        public double XOnX(int x)
        {
            return Math.Pow(x,2);
        }
       
        public double SqrtX(int x)
        {
            return Math.Sqrt(x);
        }
    }
}
