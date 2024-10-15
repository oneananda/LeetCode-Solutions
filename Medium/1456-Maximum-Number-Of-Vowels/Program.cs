﻿namespace _1456_Maximum_Number_Of_Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(MaxVowels("abciiidef", 3));
            Console.WriteLine(MaxVowels("aeiou", 2));
            //Console.WriteLine(MaxVowels("leetcode", 3));


            Console.ReadLine(); // Hold the screen
        }
        public static int MaxVowels(string s, int k)
        {
            int result = 0;

            List<string> vowelsList = new List<string>() { "a", "e", "i", "o", "u" };

            for (int i = 0; i <= s.Length - 1; i++)
            {
                int count = 0;
                var str = string.Join("", s.Skip(i).Take(k).ToList());

                if(str.Length >= k)
                {                    
                    foreach (var item in str.ToLower())
                    {
                        if (vowelsList.Contains(item.ToString()))
                        {
                            count++;
                        }
                    }
                }
                if (count > result)                
                    result =count;        

            }
            return result;
        }
    }
}
