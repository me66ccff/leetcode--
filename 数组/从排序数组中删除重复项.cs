using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法.数组
{
    public static class 从排序数组中删除重复项
    {
        public static void  Run()
        {
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(RemoveDuplicates(nums1));
        }
        public static int RemoveDuplicates(int[] nums)
        {
            nums.Count<int>();
            if (nums.Length == 0)
            {
                return 0;
            }
            else
            {
                int number = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[number] != nums[i])
                    {
                        number++;
                        nums[number] = nums[i];
                    }
                }
                return (number + 1);
            }
        }
    }
}
