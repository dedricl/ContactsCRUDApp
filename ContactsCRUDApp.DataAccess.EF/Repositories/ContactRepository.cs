using ContactsCRUDApp.DataAccess.EF.Context;
using ContactsCRUDApp.DataAccess.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsCRUDApp.DataAccess.EF.Repositories
{
    public class ContactRepository
    {
        private DedricDatabaseContext _dbContext;

        public ContactRepository(DedricDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreateContact(ContactInfo contactInfo)
        {
            _dbContext.Add(contactInfo);
            _dbContext.SaveChanges();
            return contactInfo.ContactId;
        }

        public int UpdateContact(ContactInfo contactInfo)
        {
            ContactInfo exisitingContact = _dbContext.ContactInfo.Find(contactInfo.ContactId);
            exisitingContact.FirstName = contactInfo.FirstName;
            exisitingContact.LastName = contactInfo.LastName;
            exisitingContact.EmailAddress = contactInfo.EmailAddress;
            exisitingContact.PhoneNumber = contactInfo.PhoneNumber;

            _dbContext.SaveChanges();
            return exisitingContact.ContactId;
        }

        public bool DeleteContact(int contactId)
        {
            ContactInfo exisitingContact = _dbContext.ContactInfo.Find(contactId);

            _dbContext.Remove(exisitingContact);
            _dbContext.SaveChanges();

            return true;
        }

        public List<ContactInfo> ListContacts()
        {
            List<ContactInfo> currentContacts = _dbContext.ContactInfo.ToList();

            return currentContacts;
        }

        public ContactInfo GetSingleContact(int contactId)
        {
            ContactInfo singleContact =  _dbContext.ContactInfo.Find(contactId);
            return singleContact;
        }
    }
}
