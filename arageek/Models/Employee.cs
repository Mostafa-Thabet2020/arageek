using System;
using System.Collections.Generic;
using System.Text;

namespace arageek.Models
{
    public class Employee: People
    {
        public double Salary { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
