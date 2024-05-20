using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canada_Airline_Test
{
    internal class Passenger
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int week1 { get; set; }
        public int week2 { get; set; }
        public int week3 { get; set; }
        public int week4 { get; set; }


        public Passenger() { }
        public Passenger(string fname, string lname, int week1, int week2, int week3, int week4) 
        {
            this.firstName = fname;
            this.lastName = lname;
            this.week1 = week1;
            this.week2 = week2;
            this.week3 = week3;
            this.week4 = week4;
        }
    }
}
