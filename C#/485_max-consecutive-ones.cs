public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxOnes =  0;
        int curOnes = 0;
        for (int x = 0; x < nums.Length; x++)
        {
            if (nums[x] == 1)
            {
                curOnes++;
                if (curOnes > maxOnes)
                {
                    maxOnes = curOnes;
                }
            }
            else
            {
                curOnes = 0;
            }
        }
        return maxOnes;
    }
}