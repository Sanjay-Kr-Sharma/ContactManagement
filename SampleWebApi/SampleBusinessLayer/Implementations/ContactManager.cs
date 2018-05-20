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
    public class ContactManager:IContactManager
    {
        private ContactModel contactModel;
        public ContactManager(ContactModel contactModel)
        {
            this.contactModel = contactModel;
        }
        public List<Contact> Get()
        {
            var contacts = contactModel.Contacts.ToList();
            return contacts;
        }

        public Contact Get(long id)
        {
            return contactModel.Contacts.Where(c => c.ID == id).FirstOrDefault();
        }

        public Contact Add(Contact contact)
        {
            var addedContact = contactModel.Contacts.Add(contact);
            contactModel.SaveChanges();

            return addedContact;
        }

        public Contact Update(Contact contact)
        {
            var updatedContact = Get(contact.ID);
            updatedContact.FirstName = contact.FirstName;
            updatedContact.LastName = contact.LastName;
            updatedContact.PrimaryEmail = contact.PrimaryEmail;
            updatedContact.Email1 = contact.Email1;
            updatedContact.Email2 = contact.Email2;
            updatedContact.PrimaryPhone = contact.PrimaryPhone;
            updatedContact.Phone1 = contact.Phone1;
            updatedContact.Phone2 = contact.Phone2;
            updatedContact.DeletedDt = contact.DeletedDt;
            contactModel.SaveChanges();

            return updatedContact;
        }

        public bool Delete(long id)
        {
            var contact = Get(id);
            contact.DeletedDt = DateTime.UtcNow;
            Update(contact);
            return true;
        }
    }
}
