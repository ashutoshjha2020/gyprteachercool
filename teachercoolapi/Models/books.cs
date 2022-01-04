using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teachercoolapi.Models
{
    public class books
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string edition { get; set; }
        public string publisher { get; set; }
        public string diemension { get; set; }
        public string weight { get; set; }
        public string details { get; set; }
        public string downloadlink { get; set; }
        public decimal listprice { get; set; }
        public decimal currentprice { get; set; }
        public int isused { get; set; }
        public string currency { get; set; }
        public int totdownload { get; set; }
        public string writer { get; set; }
        public string coverimg { get; set; }
        public int isfree { get; set; }
        public string isbn { get; set; }
        public string isbn13 { get; set; }
    }
}