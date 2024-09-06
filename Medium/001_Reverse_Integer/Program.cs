namespace _001_Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/reverse-integer/description/


            #region Regular Testing by inputting numbers of our choice

            // Uncomment to test one-by-one
            // RunRegularTests();

            #endregion


            #region Automated Testing

            // Comment this if you need to test one-by-one
            RunAutomatedTests();

            #endregion

            Console.ReadLine();
        }

        private static void RunRegularTests()
        {
            Console.WriteLine("Enter the integer to reverse!");

            Console.WriteLine($"Output: " + Reverse(Convert.ToInt32(Console.ReadLine())));
        }

        private static void RunAutomatedTests()
        {
            TestReverse_PositiveNumber();
            TestReverse_NegativeNumber();
        }
        static void TestReverse_PositiveNumber()
        {
            int input = 123;
            int expected = 321;
            int result = Reverse(input);
            Console.WriteLine($"TestReverse_PositiveNumber: Input={input}, Expected={expected}, Result={result}, Passed={result == expected}");
        }

        static void TestReverse_NegativeNumber()
        {
            int input = -123;
            int expected = -321;
            int result = Reverse(input);
            Console.WriteLine($"TestReverse_NegativeNumber: Input={input}, Expected={expected}, Result={result}, Passed={result == expected}");
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
