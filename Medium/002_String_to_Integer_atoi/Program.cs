namespace _002_String_to_Integer_atoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer to Convert!");

            Console.WriteLine($"Output: " + MyAtoi(Convert.ToString(Console.ReadLine())));
            Console.ReadLine(); // Hold the screen
        }

        public static int MyAtoi(string s)
        {
            var strArr = s.ToArray();
            string convertedValue = string.Empty;
            foreach (var i in strArr)
            {
                if(Char.IsDigit(i)) 
                    convertedValue += Convert.ToString(i);
                else break;
            }

            Console.WriteLine(convertedValue);
            return s.Length;
        }
    }
}
