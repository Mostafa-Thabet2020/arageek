using arageek.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace arageek.Models
{
    public class TabsOfArticle:Base//Many to Many
    {
        public Tab tab { get; set; }
        public Artical artical { get; set; }
    }
}
