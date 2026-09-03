using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weatherstation.Interface;

namespace Weatherstation.Class
{
    internal class Display : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Display: Current temperature is {temperature}°C");
        }
    }
}
