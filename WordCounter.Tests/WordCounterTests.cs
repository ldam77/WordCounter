
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
    [TestMethod]
    public void CountWordFrequency_ReturnFrequencyOfWordInSentence()
    {
      // arrange
      string word = "hi";
      string sentence = "hi";
      int count = 1;
      RepeatCounter repeatCounter = new RepeatCounter(word);


      // act
      int expectedResult = repeatCounter.CountWordFrequency(sentence);

      // assert
      Assert.AreEqual(count, expectedResult);
    }
    
  }
}
