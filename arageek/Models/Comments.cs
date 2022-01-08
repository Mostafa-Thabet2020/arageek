using arageek.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace arageek.Models
{
    public class Comments:Base//many to many
    {
        public Artical artical { get; set; }
        public User user { get; set; }
        public string Comment { get; set; }
    }
}
