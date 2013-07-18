using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class MyAttribute:Attribute
    {
        public string Name { get; set; }
        public string Date { get; set; }
    }
}