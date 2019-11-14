using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OmerSeyfettinApp.Models
{
    public class Log
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string IPAddress { get; set; }
        public string UrlAccessed { get; set; }
        public string Data { get; set; }
        public long ExecutionMs { get; set; }
        public System.DateTime AddedDate { get; set; }
    }
}