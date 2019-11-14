using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OmerSeyfettinApp.Models
{
    public class yarismaciyazilari
    {
        public int Id { get; set; }
        public byte[] DocBytes { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}