using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_winforms
{
    public class HeartBeatEventArgs: EventArgs
    {
        public DateTime TimeStamp { get; }

        public HeartBeatEventArgs():base()
        {
            TimeStamp = DateTime.Now;
        }
    }

    public delegate void HeartBeatEventHandler(object sender, HeartBeatEventArgs args);
}
