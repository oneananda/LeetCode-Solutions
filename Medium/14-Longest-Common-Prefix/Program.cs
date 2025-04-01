using System.Linq;

namespace _14_Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14-Longest-Common-Prefix!");
        }
        public string LongestCommonPrefix(string[] strs)
        {
            string result = string.Empty;

            List<string> longLst = new List<string>();

            foreach (var item in strs)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    longLst = GetComparision(item[i],item,strs);
                }
            }

            return result;
        }

        private List<string> GetComparision(char v, string item, string[] strs)
        {
            List<string> list = new List<string>(strs);
            list.Remove(item);
            string[] strs2 = list.ToArray();
        }
    }
}
