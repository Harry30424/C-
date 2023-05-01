using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcHtmlHelpers.Models;

namespace MvcHtmlHelpers.Controllers
{
    public class HelperController : Controller
    {
        // GET: Helper
        public ActionResult Index()
        {
            return View();
        }
        //Post: Login
        [HttpPost]
        public ActionResult Login(string id, string password)
        {
            ViewBag.id = id; //bring parameters to view
            ViewBag.password = password;
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Member user)
        {
            return View(user);
        }
        // GET: Helper/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Helper/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Helper/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Helper/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Helper/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Helper/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Helper/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
