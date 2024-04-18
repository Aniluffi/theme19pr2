using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    interface IRootsQuare
    {
        /// <summary>
        /// метод возведения в квадрат
        /// </summary>
        /// <param name="x">число которое будет возводиться</param>
        /// <returns>возведенное число</returns>
        int Pow(int x);
        /// <summary>
        /// метод  извлечения квадратного корня
        /// </summary>
        /// <param name="x">квадратный корень</param>
        /// <returns>извлеченный квадратный корень</returns>
        double Sqrt(int x);
    }
}
