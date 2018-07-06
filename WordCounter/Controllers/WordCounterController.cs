using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCountersController : Controller
  {
    [HttpGet("/WordCounters")]
    public ActionResult Index()
    {
      return View(RepeatCounter.GetAll());
    }
    [HttpGet("/WordCounters/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/WordCounters")]
    public ActionResult Create(string word, string sentence)
    {
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      return RedirectToAction("Index");
    }
    [HttpPost("/WordCounters/Delete")]
    public ActionResult DeleteAll()
    {
      RepeatCounter.DeleteAll();
      return RedirectToAction("Index");
    }
  }
}
