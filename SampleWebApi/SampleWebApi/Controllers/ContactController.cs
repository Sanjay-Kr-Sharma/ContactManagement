using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Utilities;
using SampleBusinessLayer;
using SampleDataLayer;

namespace SampleWebApi.Controllers
{
    public class ContactController : ApiController
    {
        IContactManager contactManager;
        public List<Contact> Get()
        {
            contactManager = new ContactManager(ModelFactory<ContactModel>.GetContext());
            return contactManager.Get();
        }

        public Contact Get(long id)
        {
            contactManager = new ContactManager(ModelFactory<ContactModel>.GetContext());
            return contactManager.Get(id);
        }

        public Contact Put(Contact contact)
        {
            contactManager = new ContactManager(ModelFactory<ContactModel>.GetContext());
            return contactManager.Update(contact);
        }

        public Contact Post(Contact contact)
        {
            contactManager = new ContactManager(ModelFactory<ContactModel>.GetContext());
            return contactManager.Add(contact);
        }
        public bool Delete(long id)
        {
            contactManager = new ContactManager(ModelFactory<ContactModel>.GetContext());
            return contactManager.Delete(id);
        }
    }
}
