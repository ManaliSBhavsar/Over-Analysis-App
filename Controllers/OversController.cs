using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OverAnalysisApp.Models;

namespace OverAnalysisApp.Controllers
{
    public class OversController : Controller
    {
        private OverService service;

        public OversController()
        {
            service = new OverService();
        }
        // GET: Overs
        [HttpGet]
        public ActionResult AddDetails()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDetails(Over over)
        {
            if (!ModelState.IsValid)
            {
                return View("AddDetails", over);
            }
            else
            {
                try
                {
                    if (service.AddOverDetails(over) == true)
                    {
                        ViewBag.Message = "OverDetails added successfully";
                    }
                    else
                    {
                        ViewBag.Message = "Failed to add over details. Try again later";

                    }
                }
                catch(InvalidOverException ex)
                {
                    Console.WriteLine(ex);
                    return View("AddOverError");
                }
                return View("AddDetails", over);
            }
        }

        [HttpGet]
        public ActionResult AnalysisReport()
        {
            ViewBag.Message = "To view report start by searching the bowler details";
            return View();
        }

        [HttpPost]
        public ActionResult AnalysisReport(SearchViewModel model)
        {
            Console.WriteLine("hello");
            model.OverDetails = service.GetOversReport(model.BowlerName, model.DeliveryTypes);
            if (model.OverDetails == null)
            {
                ViewBag.Message = "No details found for selected bowler and delivery type";
            }
            return View("AnalysisReport",model);
            
        }
    }
}
