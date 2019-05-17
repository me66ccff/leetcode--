using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法.数组
{
    public static class 两数之和
    {
        public static void Run()
        {
            int[] nums = { 2, 7, 11, 15 };
            var tmp = TwoSum(nums, 9);
            foreach (var item in tmp)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i]+ nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                        
                }
            }
            return null;
        }
    }
}
