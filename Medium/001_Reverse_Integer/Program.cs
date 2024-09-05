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
            bool isNegative = false;
            long tempX = x;
            if (tempX < 0)
            {
                isNegative = true;
                tempX = -tempX;
            }

            string currentValue = tempX.ToString();

            string convertedValue = string.Empty;

            for (int i = currentValue.Length - 1; i >= 0; i--)
            {
                convertedValue += currentValue[i].ToString();
            }

            long partialResult = Convert.ToInt64(convertedValue);

            if (partialResult > int.MaxValue)
            {
                result = 0;
            }
            else
            {
                result = Convert.ToInt32(convertedValue);
                if (isNegative)
                {
                    result = -result;
                }
            }

            return result;
        }
    }
}
