using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teachercoolapi.Models
{
    public class studentpreschool
    {
        [Key]
        public int id { get; set; }
        public int stuid { get; set; }
        public string schooltype { get; set; }
        public string name { get; set; }
        public int attendfrommonth { get; set; }
        public int attendfromyear { get; set; }
        public int attendtomonth { get; set; }
        public int attendtoyear { get; set; }
        public string majors { get; set; }
    }
}