using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{

    [AttributeUsage(AttributeTargets.Class)]
    public class MyAttribute:Attribute
    {
        public string Name { get; set; }
        public string Date { get; set; }
    }
}