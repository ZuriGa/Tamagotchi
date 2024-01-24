using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using TamagotchiProject.Models;

namespace TamagotchiProject.Controllers
{
  public class TamagotchiController : Controller
  {
    [HttpGet("/tamagotchi")]
    public ActionResult Index()
    {
      List<Tamagotchi> allTamagotchi = Tamagotchi.GetAll();
      return View(allTamagotchi);
    }
    [HttpGet("/tamagotchi/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/tamagotchi")]
    public ActionResult Create(string tamagotchiName)
    {
      Tamagotchi newTamagotchi = new Tamagotchi(tamagotchiName,20,20,20);
      return RedirectToAction("Index");
    }

    [HttpGet("/tamagotchi/{id}")]
    public ActionResult Show(int id)
    {
      Tamagotchi foundTamagotchi = Tamagotchi.Find(id);
      return View(foundTamagotchi);
    }

    [HttpPost("/tamagotchi/{id}/feed")]
    public ActionResult Show(int id, string action)
    {
      Tamagotchi foundTamagotchi = Tamagotchi.Find(id);
      foundTamagotchi.Food += 1;
      Console.WriteLine("fed");
      if (action == "food")
      {
        
      }
      return View(foundTamagotchi);
    }
    
  }
}





// [HttpGet("/items")]
//     public ActionResult Index()
//     {
//       List<Item> allItems = Item.GetAll();
//       return View(allItems);
//     }

//     [HttpGet("/items/new")]
//     public ActionResult New()
//     {
//       return View();
//     }

//     [HttpPost("/items")]
//     public ActionResult Create(string description)
//     {
//       Item myItem = new Item(description);
//       return RedirectToAction("Index");
//     }

//     [HttpPost("/items/delete")]
//     public ActionResult DeleteAll()
//     {
//       Item.ClearAll();
//       return View();
//     }

    