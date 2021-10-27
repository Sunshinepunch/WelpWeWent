using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Welp.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Welp.Controllers
{
  
  public class ReviewsController : Controller
  {
    private readonly WelpContext _db;

    public ReviewsController(WelpContext db)
    {
      _db = db;
    }
    [AllowAnonymous]
    public ActionResult Index()
    {
    var allReviews = Reviews.GetReviews();
    return View(allReviews);
    }

    [HttpPost]
    public ActionResult Create(Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Review thisReview = _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
      return View(thisReview);
    }

    public ActionResult Edit (int id)
    {
      var thisReview = _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
      return View(thisReview);
    }

    [HttpPost]
    public ActionResult Edit (Review review)
    {
      _db.Entry(review).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete (int id)
    {
      var thisReview = _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
      return View(thisReview);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisReview = _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
      _db.Reviews.Remove(thisReview);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}