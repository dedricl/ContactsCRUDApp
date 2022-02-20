using ContactsCRUDApp.DataAccess.EF.Context;
using ContactsCRUDApp.DataAccess.EF.Models;
using ContactsCRUDApp.DataAccess.EF.Repositories;
using ContactsCRUDApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsCRUDApp.Controllers
{
    public class ContactsControllers : Controller
    {
        private readonly DedricDatabaseContext _context;

        public ContactsControllers(DedricDatabaseContext context)
        {
            _context = context;
        }
        // GET: ContactsControllers
        public IActionResult Index()
        {
            ContactsViewModel model = new ContactsViewModel(_context);
            return View();
        }

        

        // POST: ContactsControllers/Create
        [HttpPost]
        

        public IActionResult Index(int contactId, string firstName, string lastName,string emailAddress, string phoneNumber)
        {
            ContactsViewModel model = new ContactsViewModel(_context);
            ContactModel contact = new ContactModel(contactId,firstName,lastName, emailAddress, phoneNumber);

            model.SaveContact(contact);
            model.IsActionSuccess = true;
            model.ActionMessage = "Contact has been saved successfully";

            return View(model);
            
        }

        public IActionResult Update(int id)
        {
            ContactsViewModel model = new ContactsViewModel(_context, id);
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            ContactsViewModel model = new ContactsViewModel(_context);

            if (id > 0)
            {
                model.DeleteContact(id);
            }

            model.IsActionSuccess = true;
            model.ActionMessage = "Contact has been delete successfully";

            return View("Index",model);
        }

    }
}
