using System.Collections.Generic;
using System;

namespace LeetSpeak.Objects
{

  public class LeetSpeakTranslator
  {
    public string LeetSpeakGenerator(string input)
    {
      string result = "";
      string prevCharacter = "";
      char[] inputtedArray = input.ToCharArray();
      foreach (char character in inputtedArray)
      {
        if (character.ToString() == "S" && inputtedArray[0].ToString() != "S" && prevCharacter != " ")
        {
          result = result + "Z";
        }
        else if (character.ToString() == "s" && inputtedArray[0].ToString() != "s" && prevCharacter != " ")
        {
          result = result + "z";
        }
        else if (character.ToString() == "I")
        {
          result = result + "1";
        }
        else if (character.ToString() == "t" || character.ToString() == "T")
        {
          result = result + "7";
        }
        else if (character.ToString() == "o" || character.ToString() == "O")
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
        prevCharacter = character.ToString();
      }
      // string result = string.Join("", inputtedArray);
      return result;
    }
  }

}
