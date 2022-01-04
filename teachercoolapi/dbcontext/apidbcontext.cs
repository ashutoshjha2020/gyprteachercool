using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using teachercoolapi.Models;

namespace teachercoolapi.dbcontext
{
    public class apidbcontext: DbContext
    {
        public apidbcontext(): base("conn")
        {

        }
        public DbSet<students> students { get; set; }
        public DbSet<studentcourse> studentcourse { get; set; }
        public DbSet<studentpreschool> studentpreschool { get; set; }
        public DbSet<studenttutorchat> studenttutorchat { get; set; }
        public DbSet<questionbank> questionbank { get; set; }
        public DbSet<books> books { get; set; }
        public DbSet<subscriptions> subscriptions { get; set; }
        public DbSet<teacher> teacher { get; set; }
      
    }
}