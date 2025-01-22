using Xunit;
using static CodeChallenge.Class1;

namespace CodeChallenge.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("E", OldPhonePad("33#"));
        Assert.Equal("B", OldPhonePad("227*#"));
    }
}