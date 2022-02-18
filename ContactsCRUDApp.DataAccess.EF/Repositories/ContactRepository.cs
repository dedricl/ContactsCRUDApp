using ContactsCRUDApp.DataAccess.EF.Context;
using ContactsCRUDApp.DataAccess.EF.Models;
using System;

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
    }
}
