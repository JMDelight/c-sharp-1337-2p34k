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
  }
}
