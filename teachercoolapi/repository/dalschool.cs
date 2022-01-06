using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teachercoolapi.dbcontext;
using teachercoolapi.Models;

namespace teachercoolapi.repository
{
    public class dalschool
    {
        private apidbcontext db = new apidbcontext();

        public string addschool(schools obj)
        {
            string res = "error";
            var emptbl = (from item in db.schools where item.name == obj.name && item.country==obj.country select item).FirstOrDefault();
            if (emptbl == null)
            {
                try
                {
                    db.schools.Add(obj);           // pass the table object 
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

        public string updateschool(schools obj)
        {
            string res = "error";
            var emptbl = (from item in db.schools where item.guid == obj.guid select item).FirstOrDefault();
            if (emptbl != null)
            {
                try
                {
                    emptbl.details = obj.details;
                    emptbl.name = obj.name;
                    emptbl.country = obj.country;
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
        public string deleteschools(int id)
        {
            string res = "error";
            try
            {
                var itm = (from p in db.schools where p.id == id select p).FirstOrDefault();
                if (itm != null)
                {
                    db.schools.Remove(itm);
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
        public schools getschoolsdetailsfromguid(Guid guid)
        {
            var itm = (from p in db.schools where p.guid == guid select p).FirstOrDefault();
            return itm;
        }
        public List<schools> getschools()
        {
            var emptbl = (from item in db.schools select item).ToList();
            return emptbl;
        }

    }
}