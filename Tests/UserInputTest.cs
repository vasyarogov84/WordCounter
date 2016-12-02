using System;
using Xunit;

namespace WordCount
{
  public class UserInputTest
  {
    [Fact]
    public void WordCount_ForSingleWord_True()
    {
      UserInput WordCount = new UserInput("portland","portland");
      Assert.Equal(1, WordCount.Counter());
    }
    [Fact]
    public void WordCount_ForSingleWord_False()
    {
      UserInput WordCount = new UserInput("portland","seatle");
      Assert.Equal(0, WordCount.Counter());
    }
    [Fact]
    public void WordCount_SentenceCount()
    {
      UserInput WordCount = new UserInput("portland","portland is portland");
      Assert.Equal(2, WordCount.Counter());
    }
  }
}
