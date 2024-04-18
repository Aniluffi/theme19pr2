using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    interface IConversation
    {
        /// <summary>
        ///  метод показывает фразу которую говорят громко
        /// </summary>
        /// <param name="text">текст который говорят громко</param>
        void TalkLoud(string text);
        /// <summary>
        /// метод показывает фразу которую говорят спокойно
        /// </summary>
        /// <param name="text">текст который говорят нормально</param>
        void TalkNormal(string text);
    }
}
