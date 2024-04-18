using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    interface IThinking
    {
        /// <summary>
        /// метод который показывает что думает
        /// </summary>
        /// <param name="text">о чем думает</param>
        void Think(string text);
    }
}
