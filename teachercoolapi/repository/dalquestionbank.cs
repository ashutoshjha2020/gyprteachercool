using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Web;
using teachercoolapi.dbcontext;
using teachercoolapi.Models;

namespace teachercoolapi.repository
{
    public class dalquestionbank
    {
        private apidbcontext db = new apidbcontext();

        public string addquestion(questionbank obj)
        {
            string res = "error";
            var emptbl = (from item in db.questionbank where item.question == obj.question select item).FirstOrDefault();
            if (emptbl == null)
            {
                try
                {
                    db.questionbank.Add(obj);           // pass the table object 
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

        public string updatequestion(questionbank obj)
        {
            string res = "error";
            var emptbl = (from item in db.questionbank where item.guid == obj.guid select item).FirstOrDefault();
            if (emptbl != null)
            {
                try
                {
                    emptbl.fullanswer = obj.fullanswer;
                    emptbl.isactive = obj.isactive;
                    emptbl.isexchange = obj.isexchange;
                    emptbl.metadescription = obj.metadescription;
                    emptbl.metakeywords = obj.metakeywords;
                    emptbl.metatitle = obj.metatitle;
                    emptbl.price = obj.price;
                    emptbl.question = obj.question;
                    emptbl.shortanswer = obj.shortanswer;
                    emptbl.updatedby = obj.updatedby;
                    emptbl.updatedip = obj.updatedip;
                    emptbl.updatedon = obj.updatedon;
                    // pass the table object 
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
        public string deletequestion(int id)
        {
            string res = "error";
            try
            {
                var itm = (from p in db.questionbank where p.id == id select p).FirstOrDefault();
                if (itm != null)
                {
                    db.questionbank.Remove(itm);
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
        public questionbank getquedetailsfromguid(Guid guid)
        {
            var itm = (from p in db.questionbank where p.guid == guid select p).FirstOrDefault();
            return itm;
        }
        public List<questionbank> getquestionbank()
        {
            var emptbl = (from item in db.questionbank select item).ToList();
            return emptbl;
        }
        public List<questionbank> searchresults(string txtsearch, int skipCount, int takeCount)
        {
            var emptbl = (from item in db.questionbank where item.question.Contains(txtsearch) || SqlMethods.Like(item.question, txtsearch) select item).Skip(skipCount).Take(takeCount).ToList();
            return emptbl;
        }

    }
}