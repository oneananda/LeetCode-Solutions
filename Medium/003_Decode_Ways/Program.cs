namespace _003_Decode_Ways
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/decode-ways/ 
            Console.WriteLine(NumDecodings(Console.ReadLine()));
            Console.ReadLine(); // Hold the screen
        }

        public static int NumDecodings(string s)
        {
            int result = 0;

            Dictionary<string, string> letterToNumberMap = new Dictionary<string, string>();

            for (int i = 0; i < 26; i++)
            {
                string letter = ((char)('A' + i)).ToString();
                string number = (i + 1).ToString();
                letterToNumberMap[letter] = number;
            }

            // Display the dictionary
            foreach (var item in letterToNumberMap)
            {
                //Console.WriteLine($"{item.Key} : {item.Value}");
            }

            //bool isContainsZero = false;
            if (s[0] == '0')
            {
                //isContainsZero = true;
                result = s.Where(x => x != '0').Count();
                result = 0;
            }
            else
            {
                result = s.Count();
            }
            if (result > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    char firstChar = s[i];
                    char secondChar = new char();

                    if (i > s.Length - 1)
                    {
                        secondChar = s[i + 1];
                        string str = firstChar.ToString() + secondChar.ToString();

                        if (letterToNumberMap.ContainsKey(str)) result++;
                    }
                }
            }

            return result;
        }
    }
}
