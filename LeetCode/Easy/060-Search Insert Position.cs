Link: https://leetcode.com/problems/search-insert-position/
Language: C#




public class Solution {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int m = (left + right) / 2;
            while (left <= right) {
                if (nums[m] == target)
                {
                    return m;

                }
                else if (nums[m] > target)
                    right = m - 1;
                else
                    left = m + 1;
                m = (left + right) / 2;
            }
            return left;
        }
}