using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法.数组
{
    public static class 只出现一次的数字
    {
        public static int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            //两个两个跳是因为题目中说了 其余每个元素均出现两次 ，所以才两个两个的跳，如果没这句就只能一个一个遍历
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                // 找到不相等的一组，直接返回
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }
            // 如果没有找到不相等的一组数据，直接返回数组的最后一个数字
            return nums[nums.Length - 1];
        }
    }
}
