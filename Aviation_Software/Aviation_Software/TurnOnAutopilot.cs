using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    // Concrete Command
    class TurnOnAutopilot : ICommand
    {
        Software software = null;
        public TurnOnAutopilot(Software software)
        {
            this.software = software;
        }

        public void Execute() 
        {
            software.AutopilotON();
        }
        public void Undo() { }

    }
}

