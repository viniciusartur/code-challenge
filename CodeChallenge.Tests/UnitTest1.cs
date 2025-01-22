using Xunit;
using static CodeChallenge.Class1;

namespace CodeChallenge.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(OldPhonePad("33#"), "E");
        Assert.Equal(OldPhonePad("227*#"), "B");
    }
}