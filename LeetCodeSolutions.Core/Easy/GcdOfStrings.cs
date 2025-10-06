using LeetCodeSolutions.Core.Common;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace LeetCodeSolutions.Core.Easy;

/// <summary>
/// LeetCode Problem #1071: Greatest common divisor of strings
/// For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t (i.e., t is concatenated with itself one or more times).
/// Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
/// </summary>
public class GcdOfStrings : ISolution
{
    /// <inheritdoc/>
    public int ProblemNumber => 1071;

    /// <inheritdoc/>
    public string Title => "GcdOfStrings";

    /// <inheritdoc/>
    public Difficulty Difficulty => Difficulty.Easy;

    /// <inheritdoc/>
    public string Description => "Find greatest common divisor of strings";

    /// <inheritdoc/>
    public string TimeComplexity => "O(n)";

    /// <inheritdoc/>
    public string SpaceComplexity => "O(n)";

    /// <summary>
    /// gets the greatest common divisor of two strings.
    /// </summary>
    /// <param name="str1">First string</param>
    /// <param name="str2">Second string</param>
    /// <returns>returns string divisor</returns>
    public string GcdOfStringsSolution(string str1, string str2)
    {
        if ((str1 + str2) != (str2 + str1))
            return string.Empty;
        int gcdLength = Gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcdLength);
    }
    private int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
