using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public ActionResult SearchRooms(BOOKING bookingDetails)
        {
            Session["fromDate"] = bookingDetails.fromDate;
            Session["toDate"] = bookingDetails.toDate;
            Session["adults"] = bookingDetails.adults;
            Session["children"] = bookingDetails.children;

            BookingModel model = new BookingModel();
            string query = "SELECT * FROM ROOM WHERE roomId NOT IN (SELECT FK_RID FROM BOOKING WHERE fromDate =@fromDate AND toDate=@toDate)";
            IEnumerable<ROOM> roomList = model.Database.SqlQuery<ROOM>(query, new SqlParameter("@fromDate", bookingDetails.fromDate), new SqlParameter("@toDate", bookingDetails.toDate));
            ViewBag.RoomList = roomList.ToList();
            return View("BookingHome");
        }

        [HttpPost]
        public ActionResult BookNow(FormCollection form)
        {
            Session["roomId"] = form["roomId"];
            Session["roomPrice"] = form["roomPrice"];
            if (Session["userId"] == null) {
                return RedirectToAction("Login", "User");
            }
            //string toDate = Session["fromDate"].ToString();
            //string fromDate = Session["toDate"].ToString();
            //string adults = Session["adults"].ToString();
            //string children = Session["children"].ToString();
            //string userId = Session["userId"].ToString();
            //string roomId=Session["roomID"].ToString();
            return RedirectToAction("Paynow", "Payment");
        }
    }
}
