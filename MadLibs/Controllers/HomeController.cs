using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLibs(string firstAdjective, string color, string firstAnimal, string verb, string secondAdjective, string secondAnimal)
    {
      MadLibsVariable newMadLibsVariable = new MadLibsVariable();
      newMadLibsVariable.FirstAdjective = firstAdjective;
      newMadLibsVariable.Color = color;
      newMadLibsVariable.FirstAnimal = firstAnimal;
      newMadLibsVariable.Verb = verb;
      newMadLibsVariable.SecondAdjective = secondAdjective;
      newMadLibsVariable.SecondAnimal = secondAnimal;
      return View(newMadLibsVariable);
    }
  }
}