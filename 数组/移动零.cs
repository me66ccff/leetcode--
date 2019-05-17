using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法.数组
{
    public static class 移动零
    {
        public static void Run()
        {
            int[] tmp = { 0, 1, 0, 3, 12 };
            MoveZeroes(tmp);
        }
        public static void MoveZeroes(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return;
            }
            //记录非o元素开始位置
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[k++] = nums[i];
                }
            }
            while (k < nums.Length)
            {
                nums[k] = 0;
                k++;
            }
        }
    }
}
