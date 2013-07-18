using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Auto:Attribute
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}