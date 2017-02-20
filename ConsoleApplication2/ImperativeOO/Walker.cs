using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperativeOO
{

    public class Walker
    {
        public Walker(Location initialLocation)
        {
            CurrentLocation = initialLocation;
        }

        public Location CurrentLocation { get; set; }
        public double Angle { get; set; }

        public void Forward(double distance)
        {
            // calc new location based on angle and current location and distance
            // assign to CurrentLocation
        }

        public void Turn(double angle)
        {
            Angle = angle;
        }
    }
}
