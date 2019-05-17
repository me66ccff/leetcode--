using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法.数组
{
    public static class 加一
    {
        public static void Run()
        {
            int[] nums = { 6,1,4,5,3,9,0,1,9,5,1,8,6,7,0,5,5,4,3 };
            var tmp = PlusOne(nums);
            foreach (var item in tmp)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (++digits[i] != 10)
                {
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                    if (i == 0)
                    {
                        //增加数组长度，扩容
                        int[] newDigits = new int[digits.Length + 1];
                        for (int j = 0; j < digits.Length; j++)
                        {
                            newDigits[j + 1] = digits[j];
                        }
                        newDigits[0] = 1;
                        return newDigits;
                    }
                }
            }
            return null;
        }
    }
}
