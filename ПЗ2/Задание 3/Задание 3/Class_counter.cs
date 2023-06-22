using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    public class Class_counter
    {
        int counter = 0;
        public static event Action? OnIncrement;
        public void increment()
        {
            counter++;
            OnIncrement?.Invoke();
        }
    }
}
