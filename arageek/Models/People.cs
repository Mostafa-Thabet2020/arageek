using arageek.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace arageek.Models
{
    public class People : Base
    {
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public Gender gender { get; set; }
        public void GetFullName()
        {
            FullName = $"Fullname is {FullName} {LastName}";
        }

    }
}
