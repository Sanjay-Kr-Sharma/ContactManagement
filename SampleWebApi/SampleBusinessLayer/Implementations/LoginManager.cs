using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SampleDataLayer;
using Utilities;
using System.Data.Entity;

namespace SampleBusinessLayer
{
    public class LoginManager 
    {
        private ContactModel contactModel;
        public LoginManager(ContactModel contactModel)
        {
            this.contactModel = contactModel;
        }
        

        public bool Validate(string username, string password)
        {
            var user = contactModel.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            return user != null;
        }
    }
}
