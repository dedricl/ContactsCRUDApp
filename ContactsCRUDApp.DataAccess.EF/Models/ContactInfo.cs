﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ContactsCRUDApp.DataAccess.EF.Models
{
    public partial class ContactInfo
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public ContactInfo(int contactId, string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            ContactId = contactId;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

        public ContactInfo()
        {

        }
    }

    
}
