using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace teachercoolapi.Models
{
    public class subscriptions
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }       
        public string details { get; set; }
        public decimal price { get; set; }
        public int validdays { get; set; }
        public Guid guid { get; set; }
        public DateTime createdon { get; set; }
        public int isactive { get; set; }
    }
}