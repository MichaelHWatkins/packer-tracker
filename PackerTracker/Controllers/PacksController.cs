using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class PacksController : Controller
  {
    [HttpGet("/packs")]
    public ActionResult Index()
    {
      List<Pack> allPacks = Pack.GetAll();
      return View(allPacks);
    }

    [HttpGet("/packs/new")]
    public ActionResult New()
    {
      return View();
    }
    
    [HttpPost("/packs")]  //POST method sends data to the serve take data from user
    public ActionResult Create(string itemName, int price, int weight)
    {
      Pack myPack = new Pack(itemName, price, weight);
      return RedirectToAction("Index");
    }

    [HttpPost("/packs/delete")]
    public ActionResult DeleteAll()
    {
      Pack.ClearAll();
      return View();
    }
  }
}