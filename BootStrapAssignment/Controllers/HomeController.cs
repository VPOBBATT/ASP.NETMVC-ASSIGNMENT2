using BootStrapAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootStrapAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<BootStrap> qry = new List<BootStrap>();
            using (MYBUSEntities dc = new MYBUSEntities())
            {
                qry = (from s in dc.BusInfoes
                       where s.BoardingPoint == "MUM"

                       select new BootStrap
                       {
                           Bus_ID = s.Bus_ID,
                           BoardingPoint = s.BoardingPoint,
                           TravelDate = s.TravelDate,
                           Amount = s.Amount,
                           Rating = s.Rating,


                       }).ToList();

            }
            return View(qry);
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