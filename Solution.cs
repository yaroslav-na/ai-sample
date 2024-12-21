public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (numToIndex.ContainsKey(complement)) {
                return new int[] { numToIndex[complement], i };
            }
            numToIndex[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
    }
}

// Example usage:
Solution solution = new Solution();
int[] result1 = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);  // Output: [0, 1]
int[] result2 = solution.TwoSum(new int[] { 3, 2, 4 }, 6);       // Output: [1, 2]
int[] result3 = solution.TwoSum(new int[] { 3, 3 }, 6);          // Output: [0, 1]