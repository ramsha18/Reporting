using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reporting.Models.Response
{
    public class employeedata
    {
        public object data { get; set; }
        public int totalemp { get; set; }
        public int salary { get; set; }
    }
    public class projectdata
    {
        public object data { get; set; }
        public int revenue { get; set; }
    }
    public class tsdata
    {
        public object data { get; set; }
        public int completed { get; set; }
    }
}