namespace Add_Two_Numbers.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { }, new int[] { }, "")]
        [InlineData(new int[] { 0 }, new int[] { 0 }, "0")]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, "708")]
        [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, "89990001")]
        [InlineData(new int[] { 9, 9, 9, 9 },  new int[] { 9, 9, 9, 9, 9, 9, 9 },  "89990001")]
        [InlineData(new int[] { 2, 4, 9 }, new int[] { 5, 6, 4, 9 }, "70401")]
        [InlineData(new int[] { 9 }, new int[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, "00000000001")]
        [InlineData(new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, new int[] { 4, 6, 5 }, "5650000000000000000000000000001")]
        public void XunitTest1(int[] nums1, int[] nums2, string expected)
        {
            ListNode? l1 = null;
            ListNode? l2 = null;
            Solution sol = new Solution();
            foreach (int x in nums1)
            {
                l1 = sol.Append(l1!, x);
            }
            foreach (int x in nums2)
            {
                l2 = sol.Append(l2!, x);
            }
            ListNode res = sol.AddTwoNumbers(l1!, l2!);
            Assert.Equal(expected, String.Join("", sol.printAllNodes(res)));
            
        }
    }
}