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
            // Accepted solution
            // return x.ToString().ToCharArray().SequenceEqual(x.ToString().ToCharArray().Reverse().ToArray());

            // Refactored, accepted solution
            char[] strX = x.ToString().ToCharArray();
            return strX.SequenceEqual(strX.Reverse().ToArray());
        }
    }
}
