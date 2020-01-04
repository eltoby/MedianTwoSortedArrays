namespace MedianTwoSortedArrays.Logic
{
    using System;

    public class Solution2
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var mergedLength = nums1.Length + nums2.Length;
            var partitionLength = mergedLength / 2 + 1;

            var min = Math.Max(0, partitionLength - nums2.Length);
            var max = Math.Min(partitionLength, nums1.Length);
            while (min < max)
            {
                var s1Length = (max + min) / 2;
                var s2Length = partitionLength - s1Length;

                if (nums1[s1Length] < nums2[s2Length - 1])
                    min = s1Length + 1;
                else
                    max = s1Length;
            }

            var n11 = int.MinValue;
            if (max > 0)
                n11 = nums1[max - 1];

            var n12 = int.MinValue;
            if (max > 1)
                n12 = nums1[max - 2];

            var n21 = int.MinValue;
            if (partitionLength - max > 0)
                n21 = nums2[partitionLength - max - 1];

            var n22 = int.MinValue;
            if (partitionLength - max > 1)
                n22 = nums2[partitionLength - max - 2];

            if (mergedLength % 2 != 0)
                return Math.Max(n11, n21);
            else
            {
                int m1;
                int m2;

                if (n11 > n21)
                {
                    m1 = n11;
                    m2 = Math.Max(n12, n21);
                }
                else
                {
                    m1 = n21;
                    m2 = Math.Max(n22, n11);
                }

                return (m1 + m2) / 2F;

            }
        }
    }
}
