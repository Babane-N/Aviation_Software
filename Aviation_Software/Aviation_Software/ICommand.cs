using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    interface ICommand
    {
        //Command base
        void Execute();
        void Undo();
    }
}
