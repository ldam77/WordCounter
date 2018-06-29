
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetWord_ReturnWord()
    {
      // arrange
      string word = "hi";
      RepeatCounter repeatCounter = new RepeatCounter(word);

      // act
      string expectedResult = repeatCounter.GetWord();

      // assert
      Assert.AreEqual(word, expectedResult);
    }
  }
}
