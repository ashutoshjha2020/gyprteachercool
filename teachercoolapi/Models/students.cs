using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teachercoolapi.Models
{
    public class students
    {
        [Key]
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public DateTime ? dob { get; set; }
        public string phone { get; set; }
        public string altphone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zip { get; set; }
        public string profimage { get; set; }
        public string college { get; set; }
        public int gradeyear { get; set; }
        public string majors { get; set; }
        public string gpa { get; set; }
        public string gender { get; set; }
        public string religions { get; set; }
        public string heritage { get; set; }
        public string languages { get; set; }
        public string ethnicity { get; set; }
        public string millitary { get; set; }
        public string citizenship { get; set; }
        public string disabilities { get; set; }
        public string academicinterest { get; set; }
        public string sports { get; set; }
        public string password { get; set; }
       public DateTime createdon { get; set; }
        public string createdip { get; set; }
        public DateTime? updatedon { get; set; }
        public string updatedip { get; set; }
        public Guid guid { get; set; }
        public int isactive { get; set; }
        public string emailotp { get; set; }
        public DateTime otpcreatedon { get; set; }
        public int isotpverified { get; set; }
        public int subscriptionid { get; set; }

        
    }
}