using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weatherstation.Interface
{
    internal interface ISubject
    {
        public void Attach(IObserver ob);
        public void Detach(IObserver ob);
        public void Notify();
    }
}
