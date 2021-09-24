using System;
using System.Collections.Generic;

namespace solutionForProb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int target_value;
            var indexes = string.Empty;

            Console.WriteLine("Write nums with specific format like [1,2,3]: ");
            var input = Console.ReadLine();
            input =input.Remove(0, 1);
            input = input.Remove(input.Length-1);

            string[] input_nums = input.Split(",");

            Console.WriteLine("Enter Terget Value:");
            target_value = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < input_nums.Length; i++)
            {
                for (int j = i + 1; j < input_nums.Length; j++)
                {
                    if (int.Parse(input_nums[i].ToString()) + int.Parse(input_nums[j].ToString()) == target_value)
                    {
                        indexes = indexes + $",{Array.IndexOf(input_nums, input_nums[i])},{Array.IndexOf(input_nums, input_nums[j])}";
                    }
                }
            }
            if (!string.IsNullOrWhiteSpace(indexes))
            {
                indexes = string.Equals(indexes[0].ToString(), ",") ? indexes.Remove(0, 1) : indexes.Trim();

            }
            if (!string.IsNullOrWhiteSpace(indexes) && indexes.Length > 1)
            {
                indexes = string.Equals(indexes[indexes.Length - 1].ToString(), ",") ? indexes.Remove(indexes.Length - 1) : indexes.Trim();
            }
            Console.WriteLine("[" + indexes + "]");
        }
    }
}
