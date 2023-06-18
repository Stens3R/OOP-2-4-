using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal interface Iitem
    {
        string Name { get; set; }
        Itype Type { get; set; }
        int Price { get; set; }
    }
}
