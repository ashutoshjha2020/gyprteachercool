using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teachercoolapi.dbcontext;
using teachercoolapi.Models;
using teachercoolapi.ModelView;

namespace teachercoolapi.repository
{
    public class daluser
    {
        private apidbcontext db = new apidbcontext();

        public string adduser(user obj)
        {
            string res = "error";
            var emptbl = (from item in db.user where item.username == obj.username select item).FirstOrDefault();
            if (emptbl == null)
            {
                try
                {
                    db.user.Add(obj);           // pass the table object 
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

        public string updateuser(user obj)
        {
            string res = "error";
            var emptbl = (from item in db.user where item.guid == obj.guid select item).FirstOrDefault();
            if (emptbl != null)
            {
                try
                {
                    emptbl.altmobile = obj.altmobile;
                    emptbl.name = obj.name;
                    emptbl.isactive = obj.isactive;
                    emptbl.categoryid = obj.categoryid;
                    emptbl.email = obj.email;
                    emptbl.mobile = obj.mobile;
                    emptbl.password = obj.password;
                    emptbl.profileimg = obj.profileimg;
                    emptbl.updatedby = obj.updatedby;
                    emptbl.updatedip = obj.updatedip;
                    emptbl.updatedon = obj.updatedon;
                    emptbl.username = obj.username;
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
        public string deleteuser(int id)
        {
            string res = "error";
            try
            {
                var itm = (from p in db.user where p.id == id select p).FirstOrDefault();
                if (itm != null)
                {
                    db.user.Remove(itm);
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
        public user getuserdetailsfromguid(Guid guid)
        {
            var itm = (from p in db.user where p.guid == guid select p).FirstOrDefault();
            return itm;
        }
        public List<user> getuser()
        {
            var emptbl = (from item in db.user select item).ToList();
            return emptbl;
        }

        #region *************category management************
        public string addusercategory(usercategory obj)
        {
            string res = "error";
            var emptbl = (from item in db.usercategory where item.name == obj.name select item).FirstOrDefault();
            if (emptbl == null)
            {
                try
                {
                    db.usercategory.Add(obj);           // pass the table object 
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

        public string updateusercategory(usercategory obj)
        {
            string res = "error";
            var emptbl = (from item in db.usercategory where item.guid == obj.guid select item).FirstOrDefault();
            if (emptbl != null)
            {
                try
                {
                  
                    emptbl.name = obj.name;
                    emptbl.isactive = obj.isactive;
                     emptbl.updatedby = obj.updatedby;
                    emptbl.updatedip = obj.updatedip;
                    emptbl.updatedon = obj.updatedon;
                    emptbl.details = obj.details;
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
        public string deleteusercategory(int id)
        {
            string res = "error";
            try
            {
                var itm = (from p in db.usercategory where p.id == id select p).FirstOrDefault();
                if (itm != null)
                {
                    db.usercategory.Remove(itm);
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
        public usercategory getusercategoryfromguid(Guid guid)
        {
            var itm = (from p in db.usercategory where p.guid == guid select p).FirstOrDefault();
            return itm;
        }
        public List<usercategory> getusercategory()
        {
            var emptbl = (from item in db.usercategory select item).ToList();
            return emptbl;
        }
        #endregion

        #region user authentication
        public userview loginuser(string uname, string pwd)
        {

            try
            {
                var itm = (from u in db.user
                           where u.username == uname && u.isactive == 1
                           select new userview
                           {
                               id = u.id,
                               name = u.name,                              
                               categoryid = u.categoryid,
                               email = u.email,
                               guid = u.guid,
                               profileimg = u.profileimg,
                               mobile = u.mobile,
                               password = u.password,
                               categoryname = (from uc in db.usercategory where uc.id == u.categoryid select uc.name).FirstOrDefault()

                           }).FirstOrDefault();
                if (itm != null)
                {
                    if (itm.password == pwd)
                    {
                        itm.msg = "success";
                        itm.responseid = 1; //1 for success, 2 for error/unsuccess, 3 for invalid, 4 for not exists
                    }
                    else
                    {
                        itm.msg = "Your password is not valid!";
                        itm.responseid = 3;
                    }
                    return itm;
                }
                else
                {
                    userview itm2 = new userview();
                    itm2.msg = "This password is not exists!";
                    itm2.responseid = 4;
                    return itm2;
                }
            }
            catch
            {
                userview itm2 = new userview();
                itm2.msg = "Some error occurred! please try later or contact to support center.";
                itm2.responseid = 2;
                return itm2;
            }

        }

        #endregion
    }
}