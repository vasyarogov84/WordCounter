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

    public int Counter()
    {
      return 1;
    }

  }
}
