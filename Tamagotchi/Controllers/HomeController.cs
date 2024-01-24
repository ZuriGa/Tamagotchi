using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using TamagotchiProject.Models;

namespace TamagotchiProject.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      Tamagotchi.TimerStart();
      return View();
    }
  }
}