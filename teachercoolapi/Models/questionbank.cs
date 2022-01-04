using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teachercoolapi.Models
{
    public class questionbank
    {
        [Key]
        public int id { get; set; }
        public string question { get; set; }
        public string metakeywords { get; set; }
        public string metadescription { get; set; }
        public string metatitle { get; set; }
        public string shortanswer { get; set; }
        public decimal fullanswer { get; set; }
        public decimal price { get; set; }
        public int isexchange { get; set; }
        public Guid guid { get; set; }
        public DateTime createdon { get; set; }
        public string createdip { get; set; }
        public int createdby { get; set; }
        public DateTime? updatedon { get; set; }
        public string updatedip { get; set; }
        public int updatedby { get; set; }
        public int isactive { get; set; }
    }
}