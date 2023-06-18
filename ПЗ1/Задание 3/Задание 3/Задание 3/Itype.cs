using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal interface Itype
    {
        string Name { get; set; }
        int CountItems { get; set; }
        IEnumerable<Iitem> GetAllItems();

        Check Sell(Iitem item);
    }
}
