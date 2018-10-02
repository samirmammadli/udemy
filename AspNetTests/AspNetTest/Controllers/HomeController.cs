using AspNetTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GetQuestions();
            return View();
        }

        [HttpPost]
        public ActionResult Index(QuestionModel model)
        {
            if (ModelState.IsValid)
            {
                if (model != null)
                {
                    using (var db = new QuestionContext())
                    {
                        db.Questions.Add(model);
                        db.SaveChanges();
                    }
                }
            }
            return RedirectToAction("Index");
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

        private void GetQuestions()
        {
            using (var db = new QuestionContext())
            {
                ViewBag.items = db.Questions.ToList();
            }
        }
    }
}