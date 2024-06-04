using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    // Receiver
    class Software
    {
        bool EngineOn;
        bool landingGearOn;
        bool autopilotON;

        public Software() 
        { 
            this.EngineOn = true;
            this.landingGearOn = true;
            this.autopilotON = true;
        }

        public void EngineON()
        {
           EngineOn = true;
           Console.WriteLine("Engine Started");
        }
        public void EngineOFF()
        {
            EngineOn = false;
            Console.WriteLine("Engine Stopped");
        }
        public void LandingGearOn()
        {
           landingGearOn = true;
           Console.WriteLine("Landing Gear On");
        }
        public void LandingGearOff()
        {
            landingGearOn = false;
            Console.WriteLine("Landing Gear Off");
        }

        public void AutopilotON()
        {
            autopilotON = true;
            Console.WriteLine("Autopilot On");
        }
        public void AutopilotOff()
        {
            autopilotON = false;
            Console.WriteLine("Autopilot Off");
        }
    }
}
