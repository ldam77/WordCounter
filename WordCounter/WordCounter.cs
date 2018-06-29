using System;
using System.Linq;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string Word;
    
    public RepeatCounter(string inputWord = "")
    {
      Word = inputWord;
    }

    public string GetWord()
    {
      return Word;
    }

    public int CountWordFrequency(string sentence)
    {
      string[] wordsInSentence = sentence.Split(' ');
      int counter = 0;

      foreach(string myWord in wordsInSentence)
      {
        if(String.Equals(Word, myWord, StringComparison.OrdinalIgnoreCase))
        {
          counter++;
        }
      }
      return counter;
    }
  }

  public class Program
  {
    public static void Main()
    {

    }
  }
}
