using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperativeOO
{
    public class WalkerFunctional
    {
        public WalkerFunctional(Location initialLocation)
        {
            currentLocation = initialLocation;
        }

        public WalkerFunctional Forward(double distance)
        {
            // calc new location based on angle and current location and distance
            // assign to CurrentLocation
            return this;
        }

        public WalkerFunctional Turn(double angle)
        {
            this.angle = angle;
            return this;
        }

        public Location Finish()
        {
            return currentLocation;
        }


        private Location currentLocation { get; set; }
        private double angle { get; set; }

    }
}
