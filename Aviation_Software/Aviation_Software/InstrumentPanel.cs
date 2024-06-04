using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    // Invoker
    class InstrumentPanel
    {
        public ICommand Engine {  get; set; }
        public ICommand LandingGear { get; set; }
        public ICommand Autopilot { get; set; }

        bool engineOn = false;
        bool landingGear = false;
        bool autopilot = false;

        public void ENGINE()
        {
            if (engineOn)
            {
                Engine.Execute();
            }
            else
            {
                Engine.Undo();
            }
       
        }
        public void Gear()
        {
            if (landingGear)
            {
                LandingGear.Execute();
            }
            else
            {
                LandingGear.Undo();
            }
        
        }
        public void Pilot()
        {
            if (autopilot)
            {
                Autopilot.Execute();
            }
            else
            {
                Autopilot.Undo();
            }
        }
    }
}
