using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Player:IRecodable,IPlayable
    {
        public string Pause()
        {
            return "проигрывание приостановлено";
        }
        public string Play()
        {
            return "проигрывание запущено";
        }
        public string Stop()
        {
            return "проигрывание остановлено";
        }

        public string Record()
        {
            return "запись начата";

        }
        public string PauseRecord()
        {
            return "запись приостановлена";

        }
        public string StopRecord()
        {
            return "запись остановлена";
        }
    }
}
