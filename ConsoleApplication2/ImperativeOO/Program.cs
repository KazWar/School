using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperativeOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROCEDURAL STYLE
            Location = new Location()
            {
                Latitude = 7,
                Longitude = 12
            };
            WalkToSupermarket();


            // OO style
            var initialLocation = new Location()
            {
                Latitude = 7,
                Longitude = 12
            };
            var walker = new Walker(initialLocation);
            walker.Forward(100);
            walker.Turn(90);
            walker.Forward(50);
            walker.Turn(-90);
            walker.Forward(100);

            // FUNCTIONAL STYLE
            var destination = new WalkerFunctional(new Location()
            {
                Latitude = 7,
                Longitude = 12
            })
            .Forward(100)
            .Turn(90)
            .Forward(50)
            .Turn(-90)
            .Forward(100)
            .Finish();

            // The above proves that C# is a multi-paradigm language, allowing procedural, OO and functional programing styles
        }


        static Location Location;
        static double Angle;

        static void Forward(double distance)
        {
            // location = ....
        }

        static void Turn(double newAngle)
        {
            Angle = newAngle;
        }

        static void WalkToSupermarket()
        {
            Forward(100);
            Turn(90);
            Forward(50);
            Turn(-90);
            Forward(100);
        }

    }
}
