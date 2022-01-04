using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace teachercoolapi.Controllers
{
    public class techcoolController : ApiController
    {
        // GET: techcool
        public IHttpActionResult Index()
        {
            return Ok();
        }
        [HttpPost]
        [Route("api/addquestion")]
        public dynamic addquestion()
        {
            return Ok();
        }
    }
}