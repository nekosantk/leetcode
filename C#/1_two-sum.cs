public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int x = 0; x < nums.Length; x++)
        {
            for (int z = x + 1; z < nums.Length; z++)
            {
                if (nums[x] == target - nums[z])
                {
                    return new int[] {x, z};
                }
            }
        }
        return new int[] {0, 0};
    }
}