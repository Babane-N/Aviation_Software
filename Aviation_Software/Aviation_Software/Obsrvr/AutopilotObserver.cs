using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    class AutopilotObserver: IObserver
    {
        SubjectBase subject;
        public AutopilotObserver(SubjectBase subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public void Update(int Altitude)
        {
            bool Autopilot = true;
            bool Descend = true;

            if (Altitude > 42000 && Autopilot == false)
            {
                Console.WriteLine("Automatically activate Autopilot");
            }
            
            if (Altitude < 31000  && Autopilot == false && Descend == false)
            {
                Console.WriteLine("Automatically activate Autopilot");
            }
        }
    }
}
