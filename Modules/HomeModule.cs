using Nancy;
using System;


namespace WordCount.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/result"] = _ =>
      {
        UserInput newUserInput = new UserInput(Request.Form["word"], Request.Form["sentence"]);
        newUserInput.Counter();
        return View["index1.cshtml", newUserInput];
      };
    }
  }
}
