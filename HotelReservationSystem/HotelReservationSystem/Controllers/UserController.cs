using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservationSystem.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            USER user = new USER();

            return View(user);
        }
        [HttpPost]
        public ActionResult Register(USER user)
        {
            using (UserModel userModel = new UserModel())
            {
                if (userModel.USERs.Any(x =>x.userName == user.userName))
                {
                    ViewBag.DuplicateMessage = "User already Exists with given user name.";
                    return View("Register", user);
                }
                userModel.USERs.Add(user);
                userModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "New User Registration Complete.";
            return View("Register", new USER());
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (Session["userName"]!= null)
            {
                return RedirectToAction("Index", "home",new { userName = Session["userName"].ToString() });
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(USER user)
        {
            UserModel usrModel = new UserModel();
            var validUser=usrModel.USERs.SingleOrDefault(x => x.userName == user.userName && x.password == user.password);
            if (validUser != null)
            {
                ViewBag.SuccessMessage = "Logged in";
                ViewBag.triedOnce = "Yes";
                ViewBag.userName = user.userName.ToString();
                Session["userName"] = user.userName;

                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.InvalidUserMessage = "Please check the user name or password and try again.";
                ViewBag.triedOnce = "Yes";
                return View("Login",user);
            }
           
        }
    }
}