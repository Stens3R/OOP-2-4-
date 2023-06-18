using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Check
    {
        public Itype Type { get; set; }
        public Iitem Item { get; set; }
        public DateTime DateTime { get; set; }

        public override string ToString()
        {
            return DateTime.ToString();
        }
    }
}
