using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {
    private readonly HairSalonContext _db;
    public StylistController(HairSalonContext db)
    {
      _db = db;
    }

    [Route("/")]
    public ActionResult Index() { return View(); }
    [HttpPost("/")]
    public ActionResult IndexConfirmed(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return View("Index");
    }
  }
}