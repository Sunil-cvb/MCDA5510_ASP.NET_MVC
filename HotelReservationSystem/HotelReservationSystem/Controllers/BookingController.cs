using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservationSystem.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult BookingHome()
        {
            //BookingModel bookingModel = new BookingModel();
            if (Session["userName"] != null)
            {
                ViewBag.userName = Session["userName"].ToString();
            }
            BOOKING booking = new BOOKING();
            return View(booking);
        }
    }
}