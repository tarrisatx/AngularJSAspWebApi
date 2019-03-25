using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgularJsWithMvc.Models;
using System.Net.Http;

namespace AgularJsWithMvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //public JsonResult GetStudent()
        //{
        //    var obj = new Student();
        //    obj.Name = "John";
        //    obj.Surname = "Doe";
        //    obj.Address = "Street 34, California";
        //    obj.Mobile = "+180565823487";
        //    return Json(obj, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult Index()
        {
            var client = new HttpClient();
            var response = client.GetAsync("http://localhost:50666/api/HomeStudent").Result;
            var products = response.Content.ReadAsAsync<IEnumerable<Student>>().Result;
            return View("Home");
        }

    }
}
