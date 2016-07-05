using System.Collections.Generic;
using System;
using Xunit;
namespace LeetSpeak.Objects
{
  public class LeetSpeakTest
  {
    [Fact]
    public void LeetSpeakGenerator_userInputTree_ReturnTr33()
    {
      //Arrange
      string expectedResult = "Tr33";
      LeetSpeakTranslator newLeetSpeakTranslator = new LeetSpeakTranslator();

      //Act
      string result = newLeetSpeakTranslator.LeetSpeakGenerator("Tree");

      //Assert
      Assert.Equal(result, expectedResult);
    }

    [Fact]
    public void LeetSpeakGenerator_userInputBob_ReturnB0b()
    {
      //Arrange
      string expectedResult = "B0b";
      LeetSpeakTranslator newLeetSpeakTranslator = new LeetSpeakTranslator();

      //Act
      string result = newLeetSpeakTranslator.LeetSpeakGenerator("Bob");

      //Assert
      Assert.Equal(result, expectedResult);
    }
  }
}
