using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Welp.Models;
using System.Collections.Generic;
using System.Linq;

namespace Welp.Controllers
{
    public class HomeController : Controller
    {

    private readonly WelpContext _db;

    public HomeController(WelpContext db)
    {
        _db = db;
    }
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}