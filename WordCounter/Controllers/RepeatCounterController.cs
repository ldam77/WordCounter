using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class RepeatCountersController : Controller
  {
    [HttpGet("/RepeatCounters")]
    public ActionResult Index()
    {
      return View(RepeatCounter.GetAll());
    }
    [HttpGet("/RepeatCounters/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/RepeatCounters")]
    public ActionResult Create(string word, string sentence)
    {
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      return View("Index", RepeatCounter.GetAll());
    }
    [HttpPost("/RepeatCounters/Delete")]
    public ActionResult DeleteAll()
    {
      RepeatCounter.DeleteAll();
      return View("Index", RepeatCounter.GetAll());
    }
  }
}
