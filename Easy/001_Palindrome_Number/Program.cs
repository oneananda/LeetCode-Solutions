namespace _001_Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/palindrome-number/description/
            Console.WriteLine($"Enter the number to check!");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPalindrome(number));
            Console.ReadLine(); // Hold the screen
        }

        public static bool IsPalindrome(int x)
        {
            //char[] strX = x.ToString().ToCharArray();
            //char[] str2X = strX.Reverse().ToArray();
            return x.ToString().ToCharArray().SequenceEqual(x.ToString().ToCharArray().Reverse().ToArray());
        }
    }
}
