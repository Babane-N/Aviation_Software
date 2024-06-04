using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    // Concrete Command
    class LandingGearON : ICommand
    {
        Software software = null;
        public LandingGearON(Software software)
        {
            this.software = software;
        }

        public void Execute()
        {
            software.LandingGearOn();
        }
        public void Undo() { }
    }
}
