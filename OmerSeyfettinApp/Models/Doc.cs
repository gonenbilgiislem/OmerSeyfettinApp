using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OmerSeyfettinApp.Models
{
    public class Doc
    {
        public Guid Id { get; set; }
        public byte[] DocBytes { get; set; }
        public string Comment { get; set; }
    }
}