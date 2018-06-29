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
      string[] wordsInSentence = sentence.Split(' ', ',');
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
      Console.WriteLine("Please enter a word:");
      string word = Console.ReadLine();
      Console.WriteLine("Please enter a sentence or list of words:");
      string sentence = Console.ReadLine();
      RepeatCounter repeatCounter = new RepeatCounter(word);
      int count = repeatCounter.CountWordFrequency(sentence);
      Console.WriteLine("The word " + word + " appears " + count + " times.");
    }
  }
}
