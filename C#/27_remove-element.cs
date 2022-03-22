public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int[] tempArr = new int[nums.Length];
        int tempCount = 0;
        for (int x = 0; x < nums.Length; x++)
        {
            if (nums[x] != val)
            {
                tempArr[tempCount] = nums[x];
                tempCount++;
            }
        }
        for (int x = 0; x < tempCount; x++)
        {
            nums[x] = tempArr[x];
        }
        return tempCount;
    }
}