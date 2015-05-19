using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHybridSite.Models
{
    public class Log
    {
        public static Dictionary<Guid, Log> LogList = new Dictionary<Guid, Log>();

        public Guid Id { get; set; }

        public DateTime TimeStamp { get; set; }

        public string Message { get; set; }
    }
}
