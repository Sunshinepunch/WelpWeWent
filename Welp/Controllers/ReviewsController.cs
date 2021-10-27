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
using System.Diagnostics;

namespace Welp.Controllers
{
  
  public class ReviewsController : Controller
  {

    public IActionResult Index()
    {
    var allReviews = Review.GetReviews();
    return View(allReviews);
    }

    public IActionResult Details(int id)
    {
      var review = Review.GetDetails(id);
      return View(review);
    }

    public IActionResult Edit (int id)
    {
      var review = Review.GetDetails(id);
      return View(review);
    }

    public ActionResult Create()
    {
      ViewBag.DestinationId = new SelectList (Destination.GetDestinations(), "DestinationId", "Name");
      return View();
    }

    [HttpPost]
    public IActionResult Create(Review review)
    {
      Review.Post(review);
      return RedirectToAction("Index");
    }

    public IActionResult Delete (int id)
    {
      Review.Delete(id);
      return RedirectToAction("Index");
    }
  }
}