namespace _334_Increasing_Triplet_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(IncreasingTriplet(new Int32[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(IncreasingTriplet(new Int32[] { 20, 100, 10, 12, 5, 13 }));
            
            Console.ReadLine(); // Hold Screen
        }

        public static bool IncreasingTriplet(int[] nums)
        {
            bool result = false;
            for (int i = 0; i <= nums.Length; i++)
            {
                List<int> list = nums.Skip(i).Take(3).ToList();
                if(list.Count == 3)
                {
                    if (list[0] < list[1] && list[1] < list[2]) return true;
                }
            }
            return result;
        }
    }
}
