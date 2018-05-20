using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace SampleWebApi.Controllers
{
    public class LoginController : ApiController
    {
        public string Get()
        {
            FormsAuthentication.SetAuthCookie("Badri", false);
            return "Redirecting to login page...";
        }

        public void Post()
        {
            FormsAuthentication.SetAuthCookie("Badri", false);
        }
    }
}
