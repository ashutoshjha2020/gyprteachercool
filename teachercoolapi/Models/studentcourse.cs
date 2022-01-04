using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teachercoolapi.Models
{
    public class studentcourse
    {
        [Key]
        public int id { get; set; }
        public  int stuid { get; set; }
        public string school { get; set; }
        public string course { get; set; }
    }
}