using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RepositoryService.CreateDefaultObject("Account");
            RepositoryService.AddField("Account", "AccountName", "varchar(255)");
            RepositoryService.Insert("INSERT INTO Account (AccountName) VALUES ('Test')");
            var accounts = RepositoryService.Select<dynamic>("SELECT * FROM Account");
            return View(accounts);
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
    }
}