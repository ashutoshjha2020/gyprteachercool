using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teachercoolapi.Models
{
    public class studenttutorchat
    {
        [Key]
        public int id { get; set; }
        public int stuid { get; set; }
        public int teacherid { get; set; }
        public int ismsgfromteacher { get; set; }
        public int ismsgfromstudent { get; set; }
        public int isread { get; set; }
        public string msg { get; set; }
        public DateTime createdon { get; set; }
        public int isdeleted { get; set; }
    }
}