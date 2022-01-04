using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teachercoolapi.Models
{
    public class teacher
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; } 
        public string username { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string altphone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
        public string profimage { get; set; }
        public string qualification{ get; set; }
        public string languages { get; set; }
        public string currency { get; set; }
        public decimal earnexpect { get; set; }
        public string writingstyle { get; set; }
        public string dedicatedhours { get; set; }
        public int isassignmentexp { get; set; }
        public int isknowstyle { get; set; }
        public int isknowplagrism { get; set; }
        public int isavldemoassignment { get; set; }
        public DateTime createdon { get; set; }
        public string createdip { get; set; }
        public DateTime? updatedon { get; set; }
        public string updatedip { get; set; }
        public Guid guid { get; set; }
        public int isactive { get; set; }
        public string emailotp { get; set; }
        public DateTime otpcreatedon { get; set; }
        public int isotpverified { get; set; }
        
    }
}