using Nancy;
using System.Collections.Generic;
using LeetSpeak.Objects;

namespace LeetSpeak {

  public class HomeModule : NancyModule {

    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        LeetSpeakTranslator newLeetSpeakTranslator = new LeetSpeakTranslator();
        string result = newLeetSpeakTranslator.LeetSpeakGenerator(Request.Form["phrase"]);
        return View["result.cshtml", result];
      };
    }

  }

}
