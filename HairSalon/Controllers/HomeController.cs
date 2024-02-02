using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using HairSalon.Models;


namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    private readonly HairSalonContext _db;
    public HomeController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index() { return View(); }
  }
}