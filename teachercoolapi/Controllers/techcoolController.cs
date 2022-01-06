using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using teachercoolapi.Models;
using teachercoolapi.repository;

namespace teachercoolapi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class techcoolController : ApiController
    {
        // GET: techcool
        public IHttpActionResult Index()
        {
            return Ok();
        }
        #region ***********question bank**********
        [HttpPost]
        [Route("api/addquestion")]
        public IHttpActionResult addquestion([FromBody] questionbank data)
        {
            common cm = new common();
            data.createdby = 1;
            data.createdip = cm.getIP();
            data.createdon = DateTime.Now;
            data.guid = Guid.NewGuid();
            dalquestionbank dal = new dalquestionbank();
            string res = dal.addquestion(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/updatequestion")]
        public IHttpActionResult updatequestion([FromBody] questionbank data)
        {
            common cm = new common();
            data.updatedip = cm.getIP();
            data.updatedon = DateTime.Now;
            data.updatedby = 1;
            dalquestionbank dal = new dalquestionbank();
            string res = dal.updatequestion(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/deletequestion/{qid}")]
        public IHttpActionResult deletequestion(int qid)
        {            
            dalquestionbank dal = new dalquestionbank();
            string res = dal.deletequestion(qid);
            return Ok(res);
        }
        [HttpGet]
        [Route("api/getquestion")]
        public dynamic getquestion()
        {
            dalquestionbank dal = new dalquestionbank();
            var res = dal.getquestionbank();
            return res;
        }
        [HttpGet]
        [Route("api/searchquestion/{txtsearch}/{skipcnt}/{takecnt}")]
        public dynamic searchquestion(string txtsearch,int skipcnt,int takecnt)
        {
            dalquestionbank dal = new dalquestionbank();
            var res = dal.searchresults(txtsearch,skipcnt,takecnt);
            return res;
        }
        [HttpGet]
        [Route("api/getquestionfromguid/{gid}")]
        public dynamic getquestionfromguid(string gid)
        {
            if(!string.IsNullOrEmpty(gid))
            {
                Guid guid = Guid.Parse(gid);
                dalquestionbank dal = new dalquestionbank();
                var res = dal.getquedetailsfromguid(guid);
                return res;
            }
            return null;
        }

        #endregion
        #region ***********Course Management**********
        [HttpPost]
        [Route("api/addcourse")]
        public IHttpActionResult addcourse([FromBody] course data)
        {
                
            data.createdon = DateTime.Now;
            data.guid = Guid.NewGuid();
            dalcourse dal = new dalcourse();
            string res = dal.addcourse(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/updatecourse")]
        public IHttpActionResult updatecourse([FromBody] course data)
        {          
            dalcourse dal = new dalcourse();
            string res = dal.updatecourse(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/deletecourse/{cid}")]
        public IHttpActionResult deletecourse(int cid)
        {
            dalcourse dal = new dalcourse();
            string res = dal.deletecourse(cid);
            return Ok(res);
        }
        [HttpGet]
        [Route("api/getcourse")]
        public dynamic getcourse()
        {
            dalcourse dal = new dalcourse();
            var res = dal.getcourse();
            return res;
        }
        [HttpGet]
        [Route("api/getcoursefromguid/{gid}")]
        public dynamic getcoursefromguid(string gid)
        {
            if (!string.IsNullOrEmpty(gid))
            {
                Guid guid = Guid.Parse(gid);
                dalcourse dal = new dalcourse();
                var res = dal.getcoursedetailsfromguid(guid);
                return res;
            }
            return null;
        }
        #endregion
        #region ***********School Management**********
        [HttpPost]
        [Route("api/addschool")]
        public IHttpActionResult addschool([FromBody] schools data)
        {            
            data.guid = Guid.NewGuid();
            dalschool dal = new dalschool();
            string res = dal.addschool(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/updateschool")]
        public IHttpActionResult updateschool([FromBody] schools data)
        {
            
            dalschool dal = new dalschool();
            string res = dal.updateschool(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/deleteschool/{qid}")]
        public IHttpActionResult deleteschool(int qid)
        {
            dalschool dal = new dalschool();
            string res = dal.deleteschools(qid);
            return Ok(res);
        }
        [HttpGet]
        [Route("api/getschool")]
        public dynamic getschool()
        {
            dalschool dal = new dalschool();
            var res = dal.getschools();
            return res;
        }
        [HttpGet]
        [Route("api/getschoolfromguid/{gid}")]
        public dynamic getschoolfromguid(string gid)
        {
            if (!string.IsNullOrEmpty(gid))
            {
                Guid guid = Guid.Parse(gid);
                dalschool dal =new dalschool();
                var res = dal.getschoolsdetailsfromguid(guid);
                return res;
            }
            return null;
        }

        #endregion
        #region ***********Subscription Management**********
        [HttpPost]
        [Route("api/addsubscription")]
        public IHttpActionResult addsubscription([FromBody] subscriptions data)
        {            
            data.createdon = DateTime.Now;
            data.guid = Guid.NewGuid();
            dalsubscription dal = new dalsubscription();
            string res = dal.addsubscription(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/updatesubscription")]
        public IHttpActionResult updatesubscription([FromBody] subscriptions data)
        {

            dalsubscription dal = new dalsubscription();
            string res = dal.updatesubscription(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/deletesubscription/{qid}")]
        public IHttpActionResult deletesubscription(int qid)
        {
            dalsubscription dal = new dalsubscription();
            string res = dal.deletesubscriptions(qid);
            return Ok(res);
        }
        [HttpGet]
        [Route("api/getsubscription")]
        public dynamic getsubscription()
        {
            dalsubscription dal = new dalsubscription();
            var res = dal.getsubscription();
            return res;
        }
        [HttpGet]
        [Route("api/getsubscriptionfromguid/{gid}")]
        public dynamic getsubscriptionfromguid(string gid)
        {
            if (!string.IsNullOrEmpty(gid))
            {
                Guid guid = Guid.Parse(gid);
                dalsubscription dal = new dalsubscription();
                var res = dal.getsubscriptiondetailsfromguid(guid);
                return res;
            }
            return null;
        }

        #endregion
        #region ***********User Management**********
        [HttpPost]
        [Route("api/adduser")]
        public IHttpActionResult adduser([FromBody] user data)
        {
            common cm = new common();
            data.createdby = 1;
            data.createdip = cm.getIP();
            data.createdon = DateTime.Now;
            data.guid = Guid.NewGuid();
            daluser dal = new daluser();
            string res = dal.adduser(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/updateuser")]
        public IHttpActionResult updateuser([FromBody] user data)
        {
            common cm = new common();
            data.updatedip = cm.getIP();
            data.updatedon = DateTime.Now;
            data.updatedby = 1;
            daluser dal = new daluser();
            string res = dal.updateuser(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/deleteuser/{qid}")]
        public IHttpActionResult deleteuser(int qid)
        {
            daluser dal = new daluser();
            string res = dal.deleteuser(qid);
            return Ok(res);
        }
        [HttpGet]
        [Route("api/getuser")]
        public dynamic getuser()
        {
            daluser dal = new daluser();
            var res = dal.getuser();
            return res;
        }
        [HttpGet]
        [Route("api/getuserfromguid/{gid}")]
        public dynamic getuserfromguid(string gid)
        {
            if (!string.IsNullOrEmpty(gid))
            {
                Guid guid = Guid.Parse(gid);
                daluser dal = new daluser();
                var res = dal.getuserdetailsfromguid(guid);
                return res;
            }
            return null;
        }
        #endregion
        #region *************admin user authentication*************
        [HttpPost]
        [Route("api/admin/login/{username}/{password}")]
        public dynamic adminlogin(string username, string password)
        {
            daluser da = new daluser();
            var res = da.loginuser(username, password);
            return Ok(res);
        }
        #endregion
        #region ***********User Category Management**********
        [HttpPost]
        [Route("api/addusercategory")]
        public IHttpActionResult addusercategory([FromBody] usercategory data)
        {
            common cm = new common();
            data.createdby = 1;
            data.createdip = cm.getIP();
            data.createdon = DateTime.Now;
            data.guid = Guid.NewGuid();
            daluser dal = new daluser();
            string res = dal.addusercategory(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/updateusercategory")]
        public IHttpActionResult updateusercategory([FromBody] usercategory data)
        {
            common cm = new common();
            data.updatedip = cm.getIP();
            data.updatedon = DateTime.Now;
            data.updatedby = 1;
            daluser dal = new daluser();
            string res = dal.updateusercategory(data);
            return Ok(res);
        }
        [HttpPost]
        [Route("api/deleteusercategory/{qid}")]
        public IHttpActionResult deleteusercategory(int qid)
        {
            daluser dal = new daluser();
            string res = dal.deleteusercategory(qid);
            return Ok(res);
        }
        [HttpGet]
        [Route("api/getusercategory")]
        public dynamic getusercategory()
        {
            daluser dal = new daluser();
            var res = dal.getusercategory();
            return res;
        }
        [HttpGet]
        [Route("api/getusercategoryfromguid/{gid}")]
        public dynamic getusercategoryfromguid(string gid)
        {
            if (!string.IsNullOrEmpty(gid))
            {
                Guid guid = Guid.Parse(gid);
                daluser dal = new daluser();
                var res = dal.getusercategoryfromguid(guid);
                return res;
            }
            return null;
        }
        #endregion
    }
}