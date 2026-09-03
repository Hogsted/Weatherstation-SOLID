using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weatherstation.Interface;

namespace Weatherstation.Class
{
    internal class Dingenot : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Dingenot received temperature update: {temperature}");
        }
    }
}
