using Xunit;
using static CodeChallenge.CodingChallenge;

namespace CodeChallenge.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("2#", "A")]
    [InlineData("33#", "E")]
    [InlineData("444#", "I")]
    [InlineData("7777#", "S")]
    [InlineData("233#", "AE")]
    [InlineData("2 2#", "AA")]
    [InlineData("227*#", "B")]
    [InlineData("4433555 555666#", "HELLO")]
    [InlineData("8 88777444666*664#", "TURING")]
    public void TestOldPhonePadWorksWell(string input, string expected)
    {
        Assert.Equal(expected, OldPhonePad(input));
    }
}
