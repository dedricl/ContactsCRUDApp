using System;
using System.Collections.Generic;

#nullable disable

namespace ContactsCRUDApp.DataAccess.EF.Models
{
    public partial class ContactModel
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public ContactModel(int contactId, string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            ContactId = contactId;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

        public ContactModel()
        {

        }
    }

    
}
