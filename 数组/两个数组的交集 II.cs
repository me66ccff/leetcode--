using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算法.数组
{
    public static class 两个数组的交集_II
    {
        public static void Run()
        {
            int[] nums1 = { 1,2,2,1 };
            int[] nums2 = { 2,2 };
            int[] all = Intersect(nums1, nums2);
            foreach (var item in all)
            {
                Console.WriteLine(item);
            }
            
        }
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var list = new List<int>();
            var dic = new Dictionary<int, int>();

            for (var i = 0; i < nums1.Length; i++)
            {
                if (dic.ContainsKey(nums1[i]))
                {
                    dic[nums1[i]]++;
                }
                else
                {
                    dic[nums1[i]] = 1;
                }
            }

            for (var i = 0; i < nums2.Length; i++)
            {
                if (dic.ContainsKey(nums2[i]) && dic[nums2[i]] != 0)
                {
                    list.Add(nums2[i]);
                    dic[nums2[i]]--;
                }
            }

            return list.ToArray();
        }
    }
}
