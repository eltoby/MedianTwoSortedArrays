namespace MedianTwoSortedArrays.Tests
{
    using MedianTwoSortedArrays.Logic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Examples
    {
        [DataTestMethod]
        [DataRow(new[] { 1,3 }, new[] { 2 }, 2)]
        [DataRow(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
        public void ExamplesTests(int[] nums1, int[] nums2, double expected)
        {
            var sut = new Solution();
            var result = sut.FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(new[] { 1, 3 }, new[] { 2 }, 2)]
        [DataRow(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
        [DataRow(new int[] { }, new[] { 1 }, 1)]
        [DataRow(new[] { 3 }, new[] { -2, -1 }, -1)]
        public void ExamplesTests2(int[] nums1, int[] nums2, double expected)
        {
            var sut = new Solution2();
            var result = sut.FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(expected, result);
        }
    }
}
