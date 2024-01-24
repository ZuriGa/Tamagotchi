using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace TamagotchiProject.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}