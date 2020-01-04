namespace MedianTwoSortedArrays.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var totalLength = nums1.Length + nums2.Length;
            var center = (totalLength) / 2 + 1;

            var centers = this.MergeSortedArraysUntil(nums1, nums2, center);

            if (totalLength % 2 == 0)
                return (centers[center - 2] + centers[center - 1]) / 2F;
            else
                return centers[center - 1];
        }

        public int[] MergeSortedArraysUntil(int[] nums1, int[] nums2, int position)
        {
            if (!nums1.Any())
                return nums2;

            if (!nums2.Any())
                return nums1;

            var result = new List<int>(position);
            var q1 = new Queue<int>(nums1);
            var q2 = new Queue<int>(nums2);
            var n1 = q1.Dequeue();
            var n2 = q2.Dequeue();

            while ((n1 != int.MaxValue || n2 != int.MaxValue) && result.Count < position)
            {
                if (n1 < n2)
                    n1 = ExtractToResult(result, q1, n1);
                else
                    n2 = ExtractToResult(result, q2, n2);
            }

            return result.ToArray();
        }

        public int[] MergeSortedArrays(int[] nums1, int[] nums2)
        {
            return this.MergeSortedArraysUntil(nums1, nums2, nums1.Length + nums2.Length);
        }

        private static int ExtractToResult(List<int> result, Queue<int> q, int n)
        {
            result.Add(n);
            n = q.Count > 0 ? q.Dequeue() : int.MaxValue;
            return n;
        }
    }
}
