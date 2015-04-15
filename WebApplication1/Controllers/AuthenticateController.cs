using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web.Security;

namespace WebApplication1.Controllers
{
    public class AuthenticateController : ApiController
    {
        // GET api/values/5
        //[Route("fg2lambs/auth")]
        [HttpGet]
        public bool Get(string uid, string pwd)
        {
            bool b = Membership.ValidateUser(uid, pwd);
            return b;
        }
    }
}
