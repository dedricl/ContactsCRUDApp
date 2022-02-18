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
        // GET: ContactsControllers
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactsControllers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactsControllers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactsControllers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactsControllers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactsControllers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactsControllers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactsControllers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
