using arageek.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace arageek.Models
{
    public class Artical:Base
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public Auther auther { get; set; }
        public List<Comments> comments { get; set; }
    }
}
