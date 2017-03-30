using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Talent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Sum { get; set; }
        public double Count { get; set; }
        public double Score { get; set; }

        public Talent(string firstName, string lastName, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
        }

        public void AddScore (double Score)
        {

        }
    }
}
