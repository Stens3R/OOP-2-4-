using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal interface Icheck
    {
        Type Type { get; set; }
        Item Item { get; set; }
        DateTime DateTime { get; set; }
    }
}
