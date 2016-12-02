using System;

namespace WordCount
{
  public class UserInput
  {
    private string _word;
    private string _stringOfWords;
    private int _wordCount = 0;

    public  UserInput(string word, string stringOfWords)
    {
      _word = word;
      _stringOfWords = stringOfWords;
    }

    public string Getword()
   {
     return _word;
   }

   public string GetstringOfWords()
   {
     return _stringOfWords;
   }

   public int GetwordCount()
   {
     return _wordCount;
   }

    public int Counter()
    {
      string[] searchString = _stringOfWords.Split(' ');
      foreach(string newWord in searchString)
      {
      if(_word.ToLower() == newWord.ToLower())
      {
        _wordCount += 1;

       }

       }
       return _wordCount;
      }
    }
  }
