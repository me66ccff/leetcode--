using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法.数组
{
    public static class 旋转数组
    {
        //这个是网上找的答案，O(1) 的要求我没弄出符合条件的算法
        public static void Rotate(int[] nums, int k)
        {
            if (nums == null || k == 0 || k == nums.Length)
            {
                return;
            }
            k = k % nums.Length;
            reverse(nums, 0, nums.Length - k - 1);
            reverse(nums, nums.Length - k, nums.Length - 1);
            reverse(nums, 0, nums.Length - 1);
        }

        private static void reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
