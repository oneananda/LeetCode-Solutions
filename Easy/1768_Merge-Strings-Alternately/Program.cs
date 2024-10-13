namespace _1768_Merge_Strings_Alternately
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter, word 1!");

            string? word1 = Console.ReadLine();

            Console.WriteLine("Enter, word 2!");

            string? word2 = Console.ReadLine();

            Console.WriteLine($"The result is: "+MergeAlternately(word1, word2)); 

            Console.ReadLine(); // Hold the screen
        }
        public static string MergeAlternately(string word1, string word2)
        {
            string result = string.Empty;
            int i = 0, j = 0;

            while (i < word1.Length && j < word2.Length)
            {
                result += word1[i++];
                result += word2[j++];
            }

            if (i < word1.Length)
            {
                result += word1.Substring(i);
            }

            if (j < word2.Length)
            {
                result += word2.Substring(j);
            }

            return result;
        }
    }
}
