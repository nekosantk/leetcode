public class Solution {
    public int[] SortedSquares(int[] nums) {
        for (int x = 0; x < nums.Length; x++)
        {
            nums[x] *= nums[x];
        }
        for (int x = 0; x < nums.Length; x++)
        {
            for (int z = x; z < nums.Length; z++)
            {
                if (nums[z] < nums[x])
                {
                    int temp = nums[x];
                    nums[x] = nums[z];
                    nums[z] = temp;
                    continue;
                }
            }
        }
        return nums;
    }
}