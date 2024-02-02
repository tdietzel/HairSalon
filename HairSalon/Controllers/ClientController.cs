using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientController : Controller
  {
    private readonly HairSalonContext _db;
    public ClientController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("/Stylist/{id}/Client")]
    public ActionResult Index(int id)
    {
      List<Client> model = _db.Clients
        .Include(model => model.Stylist)
        .Where(client => client.StylistId == id)
        .ToList();

      return View(model);
    }
    [HttpGet("/Client/Create")]
    public ActionResult Create() {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();  
    }
    [HttpPost("/Client/Create")]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();

      return RedirectToAction("Index", "Stylist");
    }
  }
}