using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    // Concrete Command
    class TurnOffAutopilot : ICommand
    {
        Software software = null;
        public TurnOffAutopilot(Software software)
        {
            this.software = software;
        }

        public void Execute() { }
        public void Undo() 
        {
            software.EngineOFF();
        }
    }
}
