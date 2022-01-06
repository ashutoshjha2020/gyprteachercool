using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teachercoolapi.dbcontext;
using teachercoolapi.Models;

namespace teachercoolapi.repository
{
    public class dalcourse
    {
        private apidbcontext db = new apidbcontext();

        public string addcourse(course obj)
        {
            string res = "error";
            var emptbl = (from item in db.course where item.name == obj.name && item.edition==obj.edition select item).FirstOrDefault();
            if (emptbl == null)
            {
                try
                {
                    db.course.Add(obj);           // pass the table object 
                    //dbc.Entry(emptbl).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    res = "success";
                }
                catch (Exception ex)
                {
                    res = "error";

                }
            }
            else
            {
                res = "already";
            }
            return res;
        }

        public string updatecourse(course obj)
        {
            string res = "error";
            var emptbl = (from item in db.course where item.guid == obj.guid select item).FirstOrDefault();
            if (emptbl != null)
            {
                try
                {
                    emptbl.details = obj.details;
                    emptbl.edition = obj.edition;
                    emptbl.name = obj.name;                   
                     //dbc.Entry(emptbl).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    res = "success";
                }
                catch (Exception ex)
                {
                    res = "error";

                }
            }
            else
            {
                res = "notavail";
            }
            return res;
        }
        public string deletecourse(int id)
        {
            string res = "error";
            try
            {
                var itm = (from p in db.course where p.id == id select p).FirstOrDefault();
                if (itm != null)
                {
                    db.course.Remove(itm);
                    db.SaveChanges();

                }
                res = "success";
            }
            catch
            {
                res = "error";
            }
            return res;
        }
        public course getcoursedetailsfromguid(Guid guid)
        {
            var itm = (from p in db.course where p.guid == guid select p).FirstOrDefault();
            return itm;
        }
        public List<course> getcourse()
        {
            var emptbl = (from item in db.course select item).ToList();
            return emptbl;
        }
        

    }
}