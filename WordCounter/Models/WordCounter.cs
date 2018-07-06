using System;
using System.Linq;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string Word;
    private string Sentence;
    private int repeatCounter = 0;
    private int Id;
    private static int lastId = 0;
    private static List<RepeatCounter> Counters = new List<RepeatCounter> {};

    public RepeatCounter(string inputWord = "", string newSentence = "")
    {
      Word = inputWord;
      Sentence = newSentence;
      Counters.Add(this);
      Id = ++lastId;
      this.CountWordFrequency();
    }

    public string GetWord()
    {
      return Word;
    }

    public string GetSentence()
    {
      return Sentence;
    }

    public int GetId()
    {
      return Id;
    }

    public int GetCount()
    {
      return repeatCounter;
    }

    public static List<RepeatCounter> GetAll()
    {
      return Counters;
    }

    public static void DeleteAll()
    {
      Counters.Clear();
    }

    public static RepeatCounter Find(int searchID)
    {
      return Counters[searchID - 1];
    }

    private void CountWordFrequency()
    {
      string[] wordsInSentence = Sentence.Split(' ', ',');

      foreach(string myWord in wordsInSentence)
      {
        if(String.Equals(Word, myWord, StringComparison.OrdinalIgnoreCase))
        {
          repeatCounter++;
        }
      }
    }
  }

  // public class Program
  // {
  //   public static void Main()
  //   {
  //     Console.WriteLine("Please enter a word:");
  //     string word = Console.ReadLine();
  //     Console.WriteLine("Please enter a sentence or list of words:");
  //     string sentence = Console.ReadLine();
  //     RepeatCounter repeatCounter = new RepeatCounter(word);
  //     int count = repeatCounter.CountWordFrequency(sentence);
  //     Console.WriteLine("The word " + word + " appears " + count + " times.");
  //   }
  // }
}
