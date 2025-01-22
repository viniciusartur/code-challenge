using Xunit;
using static CodeChallenge.Class1;

namespace CodeChallenge.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("A", OldPhonePad("2#"));
        Assert.Equal("E", OldPhonePad("33#"));
        Assert.Equal("I", OldPhonePad("444#"));
        Assert.Equal("S", OldPhonePad("7777#"));
        //Assert.Equal("B", OldPhonePad("227*#"));
    }
}