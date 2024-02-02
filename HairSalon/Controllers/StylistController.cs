using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

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

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    [HttpGet("/Stylist/{id}")]
    public ActionResult Details(int id)
    {
      Stylist stylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);

      return View(stylist);
    }

    public ActionResult Create() { return View(); }
    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return View("Index");
    }
  }
}