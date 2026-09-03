using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weatherstation.Interface;

namespace Weatherstation.Class
{
    internal class WeatherStation : ISubject
    {
        public List<IObserver> observers = new List<IObserver>();
        int _temp = 0;
        public void Attach(IObserver ob)
        {
            observers.Add(ob);
        }
        public void Detach(IObserver ob)
        {
            observers.Remove(ob);
        }

        public void Notify()
        {
            foreach (IObserver subscriber in observers)
            {
                subscriber.Update(_temp);

            }
        }

        public void SetTemperature(int temperature)
        {   
            _temp = temperature;

            
            Notify();

        }

    }
}
