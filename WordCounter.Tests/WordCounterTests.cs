
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
    [TestMethod]
    public void CountWordFrequency2_ReturnFrequencyOfWordInSentence()
    {
      // arrange
      string word = "hello";
      string sentence = "hello there";
      int count = 1;
      RepeatCounter repeatCounter = new RepeatCounter(word);


      // act
      int expectedResult = repeatCounter.CountWordFrequency(sentence);

      // assert
      Assert.AreEqual(count, expectedResult);
    }
    [TestMethod]
    public void CountWordFrequency3_ReturnFrequencyOfWordInSentence()
    {
      // arrange
      string word = "I";
      string sentence = "I am what i eat";
      int count = 2;
      RepeatCounter repeatCounter = new RepeatCounter(word);


      // act
      int expectedResult = repeatCounter.CountWordFrequency(sentence);

      // assert
      Assert.AreEqual(count, expectedResult);
    }
    [TestMethod]
    public void CountWordFrequency4_ReturnFrequencyOfWordInSentence()
    {
      // arrange
      string word = "he";
      string sentence = "He is over there";
      int count = 1;
      RepeatCounter repeatCounter = new RepeatCounter(word);


      // act
      int expectedResult = repeatCounter.CountWordFrequency(sentence);

      // assert
      Assert.AreEqual(count, expectedResult);
    }
  }
}
