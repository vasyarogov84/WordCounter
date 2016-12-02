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
  }
}
