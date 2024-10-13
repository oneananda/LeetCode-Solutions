namespace _151_Reverse_Words_In_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseWords("a good   example");
            Console.ReadLine(); // Hold the screen
        }

        public static string ReverseWords(string s)
        {
            string result = string.Empty;

            List<string> words = s.Split(" ").ToList();

            for (int i = words.Count - 1; i >= 0; i--)
            {
                if (words[i].Trim().Length > 0)
                    result += words[i] + " ";
            }

            return result.Trim();
        }
    }
}
