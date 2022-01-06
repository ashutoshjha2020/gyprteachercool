using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teachercoolapi.Models
{
    public class course
    {
        [Key]
        public int id { get; set; }     
        public string edition { get; set; }
        public string name { get; set; }
        public string details { get; set; }
        public DateTime createdon { get; set; }
        public Guid guid { get; set; }
    }
}