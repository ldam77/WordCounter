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

      return View(allCounters);
    }
    [HttpGet("/RepeatCounters/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
  }
}
