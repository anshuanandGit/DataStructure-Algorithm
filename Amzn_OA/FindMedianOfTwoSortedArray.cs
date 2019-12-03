using System;
using System.Collections.Generic;
using System.Text;

namespace Amzn_OA
{
    class FindMedianOfTwoSortedArray
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            int m = nums1.Length;
            int n = nums2.Length;
            int mid1 = (m + n + 1) / 2;
            int mid2 = (m + n + 2) / 2;

            return (findKth(nums1, 0, m, nums2, 0, n, mid1) + findKth(nums1, 0, m, nums2, 0, n, mid2)) / 2;
        }

        private double findKth(int[] nums1, int s1, int m, int[] nums2, int s2, int n, int k)
        {
            if (m > n)
            {
                return findKth(nums2, s2, n, nums1, s1, m, k);
            }

            if (m == 0)
            {
                return nums2[s2 + k - 1];
            }
            if (k == 1)
            {
                return Math.Min(nums1[s1], nums2[s2]);
            }

            int i = Math.Min(m, k / 2);
            int j = Math.Min(n, k / 2);

            if (nums1[s1 + i - 1] < nums2[s2 + j - 1])
            {
                return findKth(nums1, s1 + i, m - i, nums2, s2, n, k - i);
            }
            else
            {
                return findKth(nums1, s1, m, nums2, s2 + j, n - j, k - j);
            }
        }
    }
}
