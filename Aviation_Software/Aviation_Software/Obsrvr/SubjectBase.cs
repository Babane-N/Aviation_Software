using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    interface SubjectBase
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
