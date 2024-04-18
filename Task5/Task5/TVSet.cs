using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class TVSet:ISwitchable
    {
        public void TVState(string state) 
        {
            Console.WriteLine($"Телевизор - {state}");
        }

        public string On()
        {
            return "Включен";
        }
        public string Off()
        {
            return "Выключен";
        }
    }
}
