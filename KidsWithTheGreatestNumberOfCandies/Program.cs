public class Solution
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Example 1
        int[] candies1 = { 2, 3, 5, 1, 3 };
        int extraCandies1 = 3;
        Console.WriteLine(string.Join(",", solution.KidsWithCandies(candies1, extraCandies1))); // Output: true,true,true,false,true

        // Example 2
        int[] candies2 = { 4, 2, 1, 1, 2 };
        int extraCandies2 = 1;
        Console.WriteLine(string.Join(",", solution.KidsWithCandies(candies2, extraCandies2))); // Output: true,false,false,false,false

        // Example 3
        int[] candies3 = { 12, 1, 12 };
        int extraCandies3 = 10;
        Console.WriteLine(string.Join(",", solution.KidsWithCandies(candies3, extraCandies3))); // Output: true,false,true
    }

    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int maxCandies = 0;

        foreach (int candy in candies)
        {
            if (candy > maxCandies)
            {
                maxCandies = candy;
            }

        }

        IList<bool> result = new List<bool>();
        foreach (int candy in candies)
        {
            if (candy + extraCandies >= maxCandies)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }

        return result;
    }
}