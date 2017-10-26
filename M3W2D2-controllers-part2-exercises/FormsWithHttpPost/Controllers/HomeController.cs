using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
        const string connectionString = "Data Source = localhost\\SQLExpress; Initial Catalog = SquirrelParty; Integrated Security = True";
        public ReviewSqlDAL ReviewDAL = new ReviewSqlDAL(connectionString);

        // GET: Home
        public ActionResult Index()
        {
            List<Review> model = ReviewDAL.GetAllReviews();
            return View(model);
        }

        //POST: New Review
        public ActionResult NewReview()
        {
            return View();
        }

        public ActionResult NuReview(Review review)
        {
            ReviewDAL.SaveReview(review);

            return RedirectToAction("Index", "Home");
        }
    }
}