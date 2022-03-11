using RR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RR.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDbContext _db = new RestaurantDbContext();
        // GET: MVC
        public ActionResult Index()
        {
            return View(_db.Restaurants.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}