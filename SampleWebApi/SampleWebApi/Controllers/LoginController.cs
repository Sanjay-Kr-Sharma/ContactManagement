using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Security;

using SampleDataLayer;
using SampleBusinessLayer;
using Utilities;
using System.Web.Mvc;

namespace SampleWebApi.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index(string returnurl)
        {
            return View(); // present the login page to the user
        }

        // Login page gets posted to this action method
        [HttpPost]
        public ActionResult Index(string userId, string password)
        {
            var loginManager = new LoginManager(ModelFactory<ContactModel>.GetContext());
            if (loginManager.Validate(userId, password))
            {
                // Create the ticket and stuff it in a cookie
                FormsAuthentication.SetAuthCookie("Badri", false);
                return Redirect("index.html");
            }

            return View();
        }
    }
}
