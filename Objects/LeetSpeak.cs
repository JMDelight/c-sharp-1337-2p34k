using System.Collections.Generic;
using System;

namespace LeetSpeak.Objects
{

  public class LeetSpeakTranslator
  {
    public string LeetSpeakGenerator(string input)
    {
      string result = "";
      char[] inputtedArray = input.ToCharArray();
      foreach (char character in inputtedArray)
      {
        if (character.ToString() == "e")
        {
          result = result + "3";
        }
        else
        {
          result = result + character.ToString();
        }
      }
      // string result = string.Join("", inputtedArray);
      return result;
    }
  }

}
