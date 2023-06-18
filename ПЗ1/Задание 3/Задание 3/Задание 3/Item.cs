using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Item : Iitem
    {
        public string Name { get ; set ; }
        public Itype Type { get ; set ; }
        public int Price { get; set; }
    }
}
