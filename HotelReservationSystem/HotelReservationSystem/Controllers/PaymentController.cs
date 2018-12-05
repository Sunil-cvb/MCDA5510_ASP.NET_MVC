using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservationSystem.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Paynow()
        {
            int userID = 0;
            ViewBag.userName=Session["userName"].ToString();
            if (Session["userId"] != null)
            {
                string user = Session["userId"].ToString();
                userID = Convert.ToInt32(user);
            }

            JavaWebService.CustomerWebServiceService webService = new JavaWebService.CustomerWebServiceService();
            string details = webService.getTransaction(userID);
            if (details != null) {
                
                string[] cardDetails = details.Split(',');
                if (cardDetails.Length == 4)
                {
                    ViewBag.ExistingCustomer = "true";
                    ViewBag.CardNumber = cardDetails[0];
                    string card = cardDetails[0];
                    //string cardType = "";
                    //string cardtsya = card.Substring(0, 2);
                    if ((card.Substring(0,2)=="51" || card.Substring(0, 2) == "52" || card.Substring(0, 2) == "53" ||
                        card.Substring(0, 2) == "54" || card.Substring(0, 2) == "55")&& card.Length==16)
                    {
                        ViewBag.cardType = "Master Card";
                    }else if (card.ElementAt(0)=='4' && card.Length == 16)
                    {
                        ViewBag.cardType = "Visa";
                    }
                    else if ((card.Substring(0, 2) == "34" || card.Substring(0, 2) == "37") && card.Length == 15)
                    {
                        ViewBag.cardType = "American Express";
                    }
                    else
                    {
                        ViewBag.cardType = "Unknown";
                    }
                    ViewBag.NameOnCard = cardDetails[1];
                    ViewBag.ExpiryDate = cardDetails[2];
                    ViewBag.CardCreationDate = cardDetails[3];
                }
                else
                {
                    ViewBag.ExistingCustomer = "false";
                    

                }
            }


            ViewBag.userName = Session["userName"].ToString();
            ViewBag.userID = userID;

            return View();
        }

        [HttpPost]
        public ActionResult Paynow(FormCollection form)
        {
            
            int roomId = Convert.ToInt32(Session["roomId"].ToString());
            Double roomPrice = Convert.ToDouble(Session["roomPrice"].ToString());
            DateTime fromDate = Convert.ToDateTime(Session["fromDate"].ToString());
            DateTime toDate = Convert.ToDateTime(Session["toDate"].ToString());
            UserBankModel userBank = new UserBankModel();
            DateTime currentTime = DateTime.UtcNow;
            int userID = Convert.ToInt32(Session["userId"].ToString());
            string query = "SELECT * FROM USERBANK WHERE FK_UID=@uid";
            IEnumerable<USERBANK> results = userBank.Database.SqlQuery<USERBANK>(query, new SqlParameter("@uid",userID));
            double userAmount = 0;
            foreach (USERBANK userAcnt in results ){
                userAmount = Convert.ToDouble(userAcnt.amount);
            }
            if (userAmount>=roomPrice) {
                BookingModel bookingModel = new BookingModel();
                BOOKING bookingDetails = new BOOKING();
                bookingDetails.FK_RID = roomId;
                bookingDetails.FK_UID = userID;
                bookingDetails.fromDate = fromDate;
                bookingDetails.toDate = toDate;
                bookingDetails.bookedTime = currentTime;
                bookingModel.BOOKINGs.Add(bookingDetails);
                bookingModel.SaveChanges();
                ViewBag.PaymentStatus = "Success";
                ViewBag.PaymentInfo = "Thank you for using our services. Enjoy your stay.";
            }
            else
            {
                ViewBag.PaymentStatus = "Failure";
                ViewBag.PaymentInfo = "Insufficient Funds in your Account. PLease try later.";
            }
            ViewBag.userName = Session["userName"].ToString();
            Session.Remove("toDate");
            Session.Remove("fromDate");
            Session.Remove("adults");
            Session.Remove("children");
            Session.Remove("roomId");
            Session.Remove("roomPrice");
            return View();
        }


        public ActionResult DeleteCard(FormCollection form)
        {
            int userId = 0;
            if (Session["userId"].ToString() == form["userId"].ToString())
            {
                userId = Convert.ToInt32(Session["userId"].ToString());
            }
            JavaWebService.CustomerWebServiceService javaWebService = new JavaWebService.CustomerWebServiceService();
            string result=javaWebService.deleteTransaction(userId);
            if(result != null)
            {
                ViewBag.DeleteStatus = "Delete Failed";
            }
            return View("Paynow");
        }

        public ActionResult AddCard(FormCollection form)
        {
            int userId = 0;
            if (Session["userId"].ToString() !=null)
            {
                userId = Convert.ToInt32(Session["userId"].ToString());
            }
            string nameOnCard = form["nameOnCard"].ToString();
            string cardNumber = form["cardNumber"].ToString();
            string expDate = form["expDate"].ToString();
            JavaWebService.CustomerWebServiceService javaWebService = new JavaWebService.CustomerWebServiceService();
            string createMsg=javaWebService.createTranscation(userId, nameOnCard, cardNumber, 1.00, 1, expDate);
            
                ViewBag.CreateMsg = createMsg;
            

            return View("Paynow","Payment");
        }
    }
}