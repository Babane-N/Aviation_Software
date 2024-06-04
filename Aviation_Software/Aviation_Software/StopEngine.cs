using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    // Concrete Command
    class StopEngine: ICommand
    {
        Software software = null;
        public StopEngine(Software software)
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
