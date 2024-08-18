public class Program
{
    public static void Main()
    {
        Console.WriteLine(MergeAlternately("abc", "pqr")); 
        Console.WriteLine(MergeAlternately("ab", "pqrs"));  
        Console.WriteLine(MergeAlternately("abcd", "pq"));  
    }

    static string MergeAlternately(string word1, string word2)
    {
        int length1 = word1.Length;
        int length2 = word2.Length;
        char[] mergedStringChars = new char[length1 + length2];

        int index = 0;
        int maxLength = length1 > length2 ? length1 : length2;

        for (int i = 0; i < maxLength; i++)
        {
            if (i < length1)
            {
                mergedStringChars[index++] = word1[i];
            }

            if (i < length2)
            {
                mergedStringChars[index++] = word2[i];
            }
        }

        return new string(mergedStringChars);
    }
}