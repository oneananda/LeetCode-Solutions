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
            var strArr = s.TrimStart().ToArray();
            string convertedValue = string.Empty;
            bool isNegative = false;
            foreach (var i in strArr)
            {
                if (i == '-')
                {
                    isNegative = true;
                }
                else
                {
                    if (Char.IsDigit(i))
                        convertedValue += Convert.ToString(i);
                    else break;
                }                
            }

            if (convertedValue == string.Empty)
            {                
                convertedValue = "0";
                isNegative = false;
            }

            int result = 0;
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

            Console.WriteLine(convertedValue);
            return result;
        }
    }
}
