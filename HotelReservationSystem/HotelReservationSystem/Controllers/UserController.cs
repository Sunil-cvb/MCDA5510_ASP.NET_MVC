using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelReservationSystem.Models;

namespace HotelReservationSystem.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Register(int id=0)
        {
            USER userModel = new USER();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult Register(USER user)
        {
            using (UserModels userModel = new UserModels())
            {
                userModel.USERs.Add(user);
                userModel.SaveChanges();

            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "New User Registration Complete.";

            return View("Register",new USER());
        }
    }
}