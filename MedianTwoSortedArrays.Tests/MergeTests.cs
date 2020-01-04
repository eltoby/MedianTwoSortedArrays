namespace MedianTwoSortedArrays.Tests
{
    using MedianTwoSortedArrays.Logic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MergeTests
    {
        [TestMethod]
        public void MergeSortedArraysTests()
        {
            var nums1 = new[] { 1, 3 };
            var nums2 = new[] { 2 };
            var sut = new Solution();
            var result = sut.MergeSortedArrays(nums1, nums2);
            Assert.AreEqual(3, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
        }
        
    }
}
