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

        public int CreateContact(ContactModel contactModel)
        {
            _dbContext.Add(contactModel);
            _dbContext.SaveChanges();
            return contactModel.ContactId;
        }

        public int UpdateContact(ContactModel contactModel)
        {
            ContactModel exisitingContact = _dbContext.ContactModel.Find(contactModel.ContactId);
            exisitingContact.FirstName = contactModel.FirstName;
            exisitingContact.LastName = contactModel.LastName;
            exisitingContact.EmailAddress = contactModel.EmailAddress;
            exisitingContact.PhoneNumber = contactModel.PhoneNumber;

            _dbContext.SaveChanges();
            return exisitingContact.ContactId;
        }

        public bool DeleteContact(int contactId)
        {
            ContactModel exisitingContact = _dbContext.ContactModel.Find(contactId);

            _dbContext.Remove(exisitingContact);
            _dbContext.SaveChanges();

            return true;
        }

        public List<ContactModel> ListContacts()
        {
            List<ContactModel> currentContacts = _dbContext.ContactModel.ToList();

            return currentContacts;
        }

        public ContactModel GetSingleContact(int contactId)
        {
            ContactModel singleContact =  _dbContext.ContactModel.Find(contactId);
            return singleContact;
        }
    }
}
