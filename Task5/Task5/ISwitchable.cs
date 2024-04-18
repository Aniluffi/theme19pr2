using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    interface ISwitchable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>возращает включенное состояние</returns>
        string On();
        /// <summary>
        /// 
        /// </summary>
        /// <returns>возращает выключенное состояние</returns>
        string Off();
    }
}
