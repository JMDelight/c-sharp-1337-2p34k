using System.Collections.Generic;
using System;

namespace LeetSpeak.Objects
{

  public class LeetSpeakTranslator
  {
    public string LeetSpeakGenerator(string input)
    {
      string result = "";
      string prevCharacter = "/";
      List<string> alphabet = new List<string> {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
      char[] inputtedArray = input.ToCharArray();
      foreach (char character in inputtedArray)
      {
        if (character.ToString() == "S" && alphabet.Contains(prevCharacter.ToLower()))
        {
          result = result + "Z";

        }
        else if (character.ToString() == "s" && alphabet.Contains(prevCharacter.ToLower()))
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
