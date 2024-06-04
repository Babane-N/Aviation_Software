using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    class RadioAltimeter: SubjectBase
    {
        int altitude;
        Random feet = new Random();
        List<IObserver> Observers = new List<IObserver>();

        public void setAltitude()
        {
            this.altitude = feet.Next(0, 45000);
        }
        public int getAltitude()
        {
            return this.altitude;
        }

        public void Attach(IObserver observer)
        {
            this.Observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            this.Observers.Remove(observer);
        }
        public void Notify()
        {
            foreach(IObserver CurrentObserver in Observers)
            { 
                CurrentObserver.Update(altitude);
            }
        }
    }
}
