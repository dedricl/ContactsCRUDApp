using ContactsCRUDApp.DataAccess.EF.Context;
using ContactsCRUDApp.DataAccess.EF.Models;
using ContactsCRUDApp.DataAccess.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsCRUDApp.Models
{
    public class ContactsViewModel
    {
        private ContactRepository _repo;

        public List<ContactModel> ContactList { get; set; }
        public ContactModel CurrentContact { get; set; }

        public bool IsActionSuccess { get; set; }
        public string ActionMessage { get; set; }

        public ContactsViewModel(DedricDatabaseContext context)
        {
            _repo = new ContactRepository(context);
            ContactList = GetAllContacts();
            CurrentContact = ContactList.FirstOrDefault();
        }

        public ContactsViewModel(DedricDatabaseContext context, int contactId)
        {
            _repo = new ContactRepository(context);
            ContactList = GetAllContacts();
            if (contactId > 0)
            {
                CurrentContact = GetContact(contactId);
            }
            else
            {
                CurrentContact = new ContactModel();
            }

            

        }

        public void SaveContact(ContactModel contact)
        {
            if (contact.ContactId > 0)
            {
                _repo.UpdateContact(contact);
            }
            else
            {
                contact.ContactId = _repo.CreateContact(contact);
            }
            ContactList = GetAllContacts();
            CurrentContact = GetContact(contact.ContactId);

        }

        public void DeleteContact(int contactId)
        {
            _repo.DeleteContact(contactId);

            ContactList = GetAllContacts();
            CurrentContact = ContactList.FirstOrDefault();
        }

        public List<ContactModel> GetAllContacts()
        {
           return  _repo.ListContacts();
        }

        public ContactModel GetContact(int contactId)
        {
            return _repo.GetSingleContact(contactId);
        }
    }
}
