using System;

namespace CodeWars0
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "1 23 2 -15 -1 5 22 -9 9 1 2 -13 7";            
        }

        string HighAndLow(string numbers, string[] words)
        {
            // Code here or    
            var nums = numbers.Split(new char[] { ' ' });

            int min=Convert.ToInt32(nums[0]), max=Convert.ToInt32(nums[0]);            

            for (int i = 0; i < nums.Length; i++)
            {
                int num;
                Int32.TryParse(nums[i], out num);

                if (max < num)
                {
                    max = num;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int num;
                Int32.TryParse(nums[i], out num);

                if (min > num)
                {
                    min = num;
                }
            }

            Console.WriteLine(max);

            return "throw towel";
        }
    }
}
