using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviation_Software
{
    sealed class AirControllerSingleton
    {
        private static AirControllerSingleton contact;
        private static readonly object Locked = new object();
        private AirControllerSingleton() { }

        public static AirControllerSingleton CallAirController()
        {
            lock (Locked)
            {
                if (contact == null)
                {
                    contact = new AirControllerSingleton();
                }
                return contact;
            }
        }
        public void ContactAirController(string communication)
        {
            Console.WriteLine("Contacting Air Controller: " + communication);
        }
    }
}
