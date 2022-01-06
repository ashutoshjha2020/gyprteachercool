using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teachercoolapi.ModelView
{
    public class userview
    {
        [Key]
        public int id { get; set; }
        [StringLength(150)]
        public string name { get; set; }
        public string mobile { get; set; }
        public string altmobile { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string profileimg { get; set; }
        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public int isactive { get; set; }
        public int createdby { get; set; }
        public DateTime createdon { get; set; }
        public string createdip { get; set; }
        public string updatedip { get; set; }
        public int updatedby { get; set; }
        public DateTime? updatedon { get; set; }
        public Guid guid { get; set; }
        public int responseid { get; set; }
        public string msg { get; set; }
    }
}