using System;

public class Solution
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Example 1
        Console.WriteLine(solution.GcdOfStrings("ABCABC", "ABC")); // Output: "ABC"

        // Example 2
        Console.WriteLine(solution.GcdOfStrings("ABABAB", "ABAB")); // Output: "AB"

        // Example 3
        Console.WriteLine(solution.GcdOfStrings("LEET", "CODE")); // Output: ""
    }

    public string GcdOfStrings(string str1, string str2)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;

        int gcdLength = GCD(len1, len2);

        string candidate = str1.Substring(0, gcdLength);

        if (IsDivisible(str1, candidate) && IsDivisible(str2, candidate))
        {
            return candidate;
        }

        return "";
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private bool IsDivisible(string str, string x)
    {
        int lenX = x.Length;
        int lenStr = str.Length;

        if (lenStr % lenX != 0)
            return false;

        string repeatedX = new string(x[0], lenStr / lenX).Replace(x[0].ToString(), x);

        return repeatedX == str;
    }
}
