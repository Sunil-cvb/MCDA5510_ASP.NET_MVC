﻿using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
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

                string validEmail = "true";
                var emailPattern = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
                if (!emailPattern.IsMatch(user.email))
                {
                    validEmail = "false";
                }

                string validPostalCode = "true";
                if (user.country == "USA") {
                    var postalCodePattern = new Regex(@"^\d{5}(?:[-\s]\d{4})?$");
                    if (!postalCodePattern.IsMatch(user.postalCode))
                    {
                        validPostalCode = "false";
                    }
                        }
                else if (user.country == "Canada")
                {
                    var postalCodePattern = new Regex(@"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)+$");
                    if (!postalCodePattern.IsMatch(user.postalCode))
                    {
                        validPostalCode = "false";
                    }
                }

                if (validEmail == "false") {
                    ViewBag.valEmail = "Please Enter a valid email.";
                    return View("Register", user);
                }
                    if(validPostalCode == "false")
                {
                    ViewBag.valPostal = "Please Enter a valid postal code.";
                    return View("Register", user);
                }
                    

                userModel.USERs.Add(user);
                userModel.SaveChanges();
                var newUser = userModel.USERs.SingleOrDefault(x => x.userName == user.userName && x.password == user.password);
                Session["userName"] = newUser.userName;
                Session["userId"] = newUser.userID;
                if (Session["fromDate"] != null && Session["toDate"] != null && Session["adults"] != null)
                {
                    return RedirectToAction("Paynow", "Payment");
                }
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "New User Registration Complete.";
            return RedirectToAction("BookingHome", "Booking");
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (Session["userName"]!= null)
            {
                return RedirectToAction("BookingHome", "Booking");
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
                Session["userId"] = validUser.userID;
                if (Session["fromDate"]!=null && Session["toDate"] != null && Session["adults"] != null)
                {
                    return RedirectToAction("Paynow", "Payment");
                }
                return RedirectToAction("BookingHome", "Booking");
            }
            else
            {
                ViewBag.InvalidUserMessage = "Please check the user name or password and try again.";
                ViewBag.triedOnce = "Yes";
                return View("Login",user);
            }
           
        }

        
        public ActionResult LogOff()
        {
            Session.Abandon();

            return RedirectToAction("BookingHome", "Booking");
        }
    }
}