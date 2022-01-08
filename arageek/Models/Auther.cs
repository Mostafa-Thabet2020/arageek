
using System;
using System.Collections.Generic;
using System.Text;

namespace arageek.Models
{
    public class Auther:People
    {
        public string Bio { get; set; }
        public List<Artical> articals { get; set; }
    }
}
