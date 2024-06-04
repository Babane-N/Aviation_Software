using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    class AlarmObserver: IObserver
    {
        SubjectBase subject;
        public AlarmObserver(SubjectBase subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public void Update(int Altitude)
        {
            bool Descend = true;

            if (Altitude > 42000)
            {
                Console.WriteLine("Turn on Red alarm");
            }

            if (Altitude < 31000 && Descend == false)
            {
                Console.WriteLine("Turn on Red alarm");
            }
        }
    }
}

