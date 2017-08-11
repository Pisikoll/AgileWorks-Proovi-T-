using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers {
    public class HomeController : Controller{
        public ActionResult Index(){
            return View();
        }

        public ActionResult About(){
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(){
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Appeal() {
            return View();
        }
        [HttpPost]
        public ActionResult Appeal(Appeal model) {
            if (ModelState.IsValid) {
                Appeals.AadAppeal(model);
                return View("ThanksForInserting");
            }
            return View(model);
        }
        public ActionResult ShowAppeals() {
            List<IAppeal> appeals = Appeals.GetActiveAppeals();
            
            return View(appeals);
        }
        public ActionResult EndAppeal(int id) {
            Appeals.EndAppeal(id);
            return View("ShowAppeals", Appeals.GetActiveAppeals());
        }

    }
}