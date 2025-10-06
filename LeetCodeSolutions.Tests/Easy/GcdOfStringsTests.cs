using LeetCodeSolutions.Core.Easy;

namespace LeetCodeSolutions.Tests.Easy;

public class GcdOfStringsTests
{
    private readonly GcdOfStrings _solution;

    public GcdOfStringsTests()
    {
        _solution = new GcdOfStrings();
    }
    [Theory]
    [InlineData("ABABAB", "ABAB", "AB")]
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData("LEET", "CODE", "")]
    [InlineData("TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXX")]
    [InlineData("ABCDEF", "ABC", "")]
    public void GcdOfStringsReturnsCorrectGCD(string str1, string str2, string expected)
    {
        var result = _solution.GcdOfStringsSolution(str1, str2);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SolutionMethod_ValidInput_ReturnsExpected()
    {
        // Arrange
         var str1 = "ABABAB";
        var str2 = "ABAB";
        var expected = "AB";
        
        // Act
        var result = _solution.GcdOfStringsSolution(str1, str2);
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SolutionMetadata_ReturnsCorrectValues()
    {
        // Assert
        Assert.Equal(1071, _solution.ProblemNumber);
        Assert.Equal("GcdOfStrings", _solution.Title);
        Assert.Equal(LeetCodeSolutions.Core.Common.Difficulty.Easy, _solution.Difficulty);
        Assert.NotEmpty(_solution.Description);
        Assert.NotEmpty(_solution.TimeComplexity);
        Assert.NotEmpty(_solution.SpaceComplexity);
    }
}
