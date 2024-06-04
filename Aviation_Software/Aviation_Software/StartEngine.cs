using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    // Concrete Command
    class StartEngine : ICommand
    {
        Software software = null;
        public StartEngine(Software software)
        {
            this.software = software;
        }

        public void Execute()
        {
            software.EngineON();
        }
        public void Undo() { }
    }
}
