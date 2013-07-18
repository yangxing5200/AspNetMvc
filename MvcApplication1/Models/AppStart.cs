using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class AppStart
    {
        public void Exec()
        {
            var info = typeof(MyCode);
            var classAttributes = Attribute.GetCustomAttribute(info, typeof(Auto));
            var attirbutes = Attribute.GetCustomAttributes(info);
        }
    }
}