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
        public string IsValid(BOOKING booking)
        {

            DateTime checkinDate = (DateTime)booking.fromDate;
            DateTime checkoutDate = (DateTime)booking.toDate;

            int result = DateTime.Compare(checkinDate, checkoutDate);

            if (checkinDate < DateTime.Now.Date)
            {
                return "validation1";
            }

            if ((DateTime)checkoutDate <= checkinDate)
            {
                return "validation2";
            }

            return "";
        }

        public ActionResult SearchRooms(BOOKING bookingDetails)
        {
            Session["fromDate"] = bookingDetails.fromDate;
            Session["toDate"] = bookingDetails.toDate;
            Session["adults"] = bookingDetails.adults;
            Session["children"] = bookingDetails.children;
            
            string validationString = IsValid(bookingDetails);
            if (!validationString.Equals(""))
            {
                if (validationString == "validation1")
                {
                    ViewBag.Message1 = "Check-in date must be greater than or equal to the current date.";
                }

                if (validationString == "validation2")
                {
                    ViewBag.Message2 = "Check-Out date must be greater than the check-in date.";
                }
                return View("BookingHome");
            }
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
            string roomPrice = Session["roomPrice"].ToString();
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

        public ActionResult ManageBooking()
        {
            int userID = Convert.ToInt32(Session["userId"].ToString());
            BookingModel bookingModel = new BookingModel();
            IEnumerable<BOOKING> userTransactions = bookingModel.BOOKINGs.Where(x => x.FK_UID == userID).ToList();
            //IEnumerable<BOOKING> userTransactions;
            string query = "SELECT * FROM ROOM";
            IEnumerable<ROOM> roomList = bookingModel.Database.SqlQuery<ROOM>(query).ToList();

            foreach(BOOKING booking in userTransactions)
            {
                foreach(ROOM room in roomList)
                {
                    if (booking.FK_RID == room.roomID)
                    {
                        booking.priceInCAD = room.priceInCAD;
                    }
                }
                
            }


            ViewBag.UserTransactions = userTransactions;
            ViewBag.userName = Session["userName"].ToString();

            return View();
        }
    }
}
