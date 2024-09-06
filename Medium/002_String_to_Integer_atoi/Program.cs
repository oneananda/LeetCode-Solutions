using System.Numerics;

namespace _002_String_to_Integer_atoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  https://leetcode.com/problems/string-to-integer-atoi/
            Console.WriteLine("Enter the integer to Convert!");

            Console.WriteLine($"Output: " + MyAtoi(Convert.ToString(Console.ReadLine())));
            Console.ReadLine(); // Hold the screen
        }

        public static int MyAtoi(string s)
        {
            int result = 0;
            bool isConverted = BigInteger.TryParse(s, out BigInteger result1);
            string convertedValue = string.Empty;
            bool isNegative = false;

            if (isConverted)
            {
                convertedValue = result1.ToString();
            }
            else
            {

                var strArr = s.TrimStart().ToArray();

                if (strArr.Length > 0)
                {

                    if (strArr[0] == '-')
                    {
                        strArr[0] = '0';
                        isNegative = true;
                    }

                    if (strArr[0] == '+')
                    {
                        strArr[0] = '0';
                    }

                    foreach (var i in strArr)
                    {
                        if (Char.IsDigit(i))
                            convertedValue += Convert.ToString(i);
                        else break;
                    }

                    if (convertedValue == string.Empty)
                    {
                        convertedValue = "0";
                        isNegative = false;
                    }
                }
            }
            if (convertedValue != string.Empty)
            {
                BigInteger partialResult = 0;
                BigInteger partialResult2 = 0;
                bool isLargerThanLong = BigInteger.TryParse(convertedValue, out partialResult2);
                partialResult = partialResult2;

                if (isNegative) partialResult = -partialResult;

                if (partialResult2 < 0)
                {
                    partialResult2 = -partialResult2;
                }

                if (partialResult2 > int.MaxValue)
                {
                    if (partialResult < 0)
                    {
                        result = -int.MaxValue - 1;
                    }
                    else
                    {
                        result = int.MaxValue;
                    }
                }
                else
                {
                    result = Convert.ToInt32(convertedValue);
                    if (isNegative)
                    {
                        result = -result;
                    }
                }
            }
            Console.WriteLine(convertedValue);
            return result;
        }
    }
}
