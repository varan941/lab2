remusing System;

namespace CodeWars0
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "8 3 -5 42 -1 0 0 -9 4 7 4 -4";            
        }

        string HighAndLow(string numbers)
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
