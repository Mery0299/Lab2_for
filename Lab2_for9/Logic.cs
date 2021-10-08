using System;

namespace Lab2_for9
{
    public class Logic
    {
        public static string MinItems(float[] nums)
        {
            Array.Sort(nums);
            return $"Два наименьших элементов множества: {nums[0]} и {nums[1]}";
        }

        public static string MaxItems(float[] nums)
        {
            Array.Sort(nums);
            return $"Два наибольших элементов множества: {nums[nums.Length - 2]} и {nums[nums.Length - 1]}";
        }
    }
}