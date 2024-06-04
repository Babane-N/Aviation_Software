using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    // Concrete Command
    class LandingGearOFF: ICommand
    {
        Software software = null;
        public LandingGearOFF(Software software)
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

