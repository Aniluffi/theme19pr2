using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class PersonalComputer:ISwitchable
    {
        public void PCState(string state)
        {
            Console.WriteLine($"ПК - {state}");
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

