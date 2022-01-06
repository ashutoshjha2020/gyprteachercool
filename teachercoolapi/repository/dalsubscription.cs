using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teachercoolapi.dbcontext;
using teachercoolapi.Models;

namespace teachercoolapi.repository
{
    public class dalsubscription
    {
        private apidbcontext db = new apidbcontext();

        public string addsubscription(subscriptions obj)
        {
            string res = "error";
            var emptbl = (from item in db.subscriptions where item.name == obj.name select item).FirstOrDefault();
            if (emptbl == null)
            {
                try
                {
                    db.subscriptions.Add(obj);           // pass the table object 
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

        public string updatesubscription(subscriptions obj)
        {
            string res = "error";
            var emptbl = (from item in db.subscriptions where item.guid == obj.guid select item).FirstOrDefault();
            if (emptbl != null)
            {
                try
                {
                    emptbl.details = obj.details;
                    emptbl.name = obj.name;
                    emptbl.isactive = obj.isactive;
                    emptbl.price = obj.price;
                    emptbl.validdays = obj.validdays;
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
        public string deletesubscriptions(int id)
        {
            string res = "error";
            try
            {
                var itm = (from p in db.subscriptions where p.id == id select p).FirstOrDefault();
                if (itm != null)
                {
                    db.subscriptions.Remove(itm);
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
        public subscriptions getsubscriptiondetailsfromguid(Guid guid)
        {
            var itm = (from p in db.subscriptions where p.guid == guid select p).FirstOrDefault();
            return itm;
        }
        public List<subscriptions> getsubscription()
        {
            var emptbl = (from item in db.subscriptions select item).ToList();
            return emptbl;
        }
    }
}