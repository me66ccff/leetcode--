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
            int[] nums = { 1,2,3 };
            var tmp = PlusOne(nums);
            foreach (var item in tmp)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] PlusOne(int[] digits)
        {
            int all = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                all += digits[i] * int.Parse(Math.Pow(10,digits.Length-i-1).ToString());
            }
            all += 1;
            //可以用linq
            //return all.ToString().Select(s => int.Parse(s.ToString())).ToArray();
            //也可以使用for循环分割
            int[] tmp = new int[(int)Math.Log10(all) + 1];
            for (int i = (int)Math.Log10(all); i >= 0 ; i--)
            {
                tmp[i] = (int)(all / Math.Pow(10,i));
                all -= tmp[i] * (int)Math.Pow(10, i);
            }
            return tmp.Reverse<int>().ToArray<int>();
        }
    }
}
