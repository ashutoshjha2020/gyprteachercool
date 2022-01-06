using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teachercoolapi.Models
{
    public class usercategory
    {
        [Key]
        public int id { get; set; }
        [StringLength(100)]
        public string name { get; set; }       
        public string details { get; set; }
        public int isactive { get; set; }
        public int createdby { get; set; }
        public DateTime createdon { get; set; }
        public string createdip { get; set; }
        public string updatedip { get; set; }
        public int updatedby { get; set; }
        public DateTime? updatedon { get; set; }
        public Guid guid { get; set; }
    }
}