using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    interface IbasicMathOperations
    {
        /// <summary>
        /// метод вычитания
        /// </summary>
        /// <param name="x1">Уменьшаемое число</param>
        /// <param name="x2">Вычитаемое число</param>
        /// <returns>Возращает разность</returns>
        double Minus(double x1, double x2);
        /// <summary>
        /// метод сложения
        /// </summary>
        /// <param name="x1">первое слагаемое</param>
        /// <param name="x2">второе слагаемое</param>
        /// <returns>возращает сумму</returns>
        double Plus(double x1, double x2);
        /// <summary>
        /// метод деления
        /// </summary>
        /// <param name="x1">делимое число</param>
        /// <param name="x2">делитель числа</param>
        /// <returns>Возращает частное</returns>
        double Divide(double x1, double x2);
        /// <summary>
        /// метод умножения
        /// </summary>
        /// <param name="x1">множетель 1</param>
        /// <param name="x2">множетель 2</param>
        /// <returns>произведение</returns>
        double Multiply(double x1, double x2);
       
    }
}
