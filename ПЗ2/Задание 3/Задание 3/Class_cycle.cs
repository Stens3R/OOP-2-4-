using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Class_cycle
    {
        public int iter = 0;

        public void new_iteration(Action body_func)
        {
            iter++;
            body_func();
        }
    }
}
