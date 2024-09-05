namespace _001_Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/reverse-integer/description/

            Console.WriteLine("Enter the integer to reverse!");

            Console.WriteLine($"Output: " + Reverse(Convert.ToInt32(Console.ReadLine())));

            Console.ReadLine();
        }
        public static int Reverse(int x)
        {
            int result = 0;

            if (x < 0) x = -x;

            string currentValue = x.ToString();

            string convertedValue = string.Empty;

            for (int i = currentValue.Length - 1; i >= 0; i--)
            {
                convertedValue += currentValue[i].ToString();
            }

            result = Convert.ToInt32(convertedValue);

            if (x < 0)
            {
                result = -result;
            }

            return result;
        }
    }
}
