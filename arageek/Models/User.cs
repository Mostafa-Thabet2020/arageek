using System;
using System.Collections.Generic;
using System.Text;

namespace arageek.Models
{
    public class User : People
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Comments> comments { get; set; }
    }
}

