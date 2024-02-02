using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {
    [Route("/")]
    public string Index() { return "Hello Friend!"; }
  }
}