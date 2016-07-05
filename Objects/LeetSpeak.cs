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
        if (character.ToString() == "o" || character.ToString() == "O")
        {
          result = result + "0";
        }
        else if (character.ToString() == "e" || character.ToString() == "E")
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
