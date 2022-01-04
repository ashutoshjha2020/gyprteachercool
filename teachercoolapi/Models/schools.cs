using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teachercoolapi.Models
{
    public class schools
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public  string country { get; set; }
        public string details { get; set; }
        public Guid guid { get; set; }
    }
}