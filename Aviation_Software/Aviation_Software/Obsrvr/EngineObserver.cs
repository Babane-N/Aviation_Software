using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    class EngineObserver: IObserver
    {
        SubjectBase subject;
        public EngineObserver(SubjectBase subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public void Update(int Altitude)
        {
            bool Descend = false;

            if (Altitude > 42000)
            {
                Console.WriteLine("Decrease engines power");
            }

            if (Altitude < 31000 && Descend == false)
            {
                Console.WriteLine("Increase engines power");
            }
        }
    }
}

