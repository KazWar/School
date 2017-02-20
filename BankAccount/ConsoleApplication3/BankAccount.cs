using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class BankAccount
    {
        private decimal test;

        public decimal Test
        {
            get { return test;}
            set { test = value;}
        }

        public int Number { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int BirthdateDay { get; set; }
        public int BirthdateMonth { get; set; }
        public int BirthdateYear { get; set; }
        public int balance { get; set; }
    }
}
