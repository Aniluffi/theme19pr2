using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Men:IThinking,IConversation
    {
        public  void Think(string text)
        {
            Console.WriteLine($"Думает - {text}");
        }
        public  void TalkLoud(string text)
        {
            Console.WriteLine($"Говорит громко - {text}");
        }
        public void TalkNormal(string text)
        {
            Console.WriteLine($"Говорит нормально - {text}");
        }
    }
}
