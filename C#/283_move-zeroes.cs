public class Solution {
    public void MoveZeroes(int[] nums) {
        int toMoveCount = 0;
        int[] posToMove = new int[nums.Length];
        for (int x = 0; x < nums.Length; x++)
        {
            if (nums[x] != 0)
            {
                posToMove[toMoveCount] = nums[x];
                toMoveCount++;
            }
        }
        for (int x = 0; x < nums.Length; x++)
        {
            nums[x] = posToMove[x];
        }
        for (int x = nums.Length - 1; x > toMoveCount; x--)
        {
            nums[x] = 0;
        }
    }
}