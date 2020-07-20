using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Choice() { return View(); }

    [Route("/madlib1form")]
    public ActionResult MadLib1Form() { return View(); }

    [Route("/madlib1")]
    public ActionResult MadLibs1(string firstAdjective, string color, string firstAnimal, string verb, string secondAdjective, string secondAnimal)
    {
      MadLibs1Variable newMadLibs1Variable = new MadLibs1Variable();
      newMadLibs1Variable.FirstAdjective = firstAdjective;
      newMadLibs1Variable.Color = color;
      newMadLibs1Variable.FirstAnimal = firstAnimal;
      newMadLibs1Variable.Verb = verb;
      newMadLibs1Variable.SecondAdjective = secondAdjective;
      newMadLibs1Variable.SecondAnimal = secondAnimal;
      return View(newMadLibs1Variable);
    }
    [Route("/madlib2form")]
    public ActionResult MadLib2Form() { return View(); }

    [Route("/madlib2")]
    public ActionResult MadLibs2(string food, string firstIngredient, string secondIngredient, string thirdIngredient)
    {
      MadLibs2Variable newMadLibs2Variable = new MadLibs2Variable();
      newMadLibs2Variable.Food = food;
      newMadLibs2Variable.FirstIngredient = firstIngredient;
      newMadLibs2Variable.SecondIngredient = secondIngredient;
      newMadLibs2Variable.ThirdIngredient = thirdIngredient;
      return View(newMadLibs2Variable);
    }
  }
}