using MvcHtmlHelpers.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using MvcHtmlHelpers.Models;

namespace MvcHtmlHelpers.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult JsonResult()
        {
            var cityService = new CityServices();

            //List<User> UserList = new List<User>
            //{
            //    new User()
            //    {
            //        Name = "Jhon",
            //        Age= 23,
            //        Birthday= DateTime.Now,

            //    }
            //};
            bool success =  cityService.GetCity();


            return Json(new
            {
                isSuccess = success
            });

            //return Json(UserList);
        }
    }
}