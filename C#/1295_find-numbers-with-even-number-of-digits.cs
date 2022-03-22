public class Solution {
    public int FindNumbers(int[] nums) {
        int numEvens = 0;
        for (int x = 0; x < nums.Length; x++)
        {
            int numDigits = 0;
            for (int z = 0; z < 500; z++)
            {
                if (nums[x] % Math.Pow(10, z) < nums[x])
                {
                    numDigits++;
                }
                else
                {
                    break;
                }
            }
            if (numDigits % 2 == 0)
            {
                numEvens++;
            }
        }
        return numEvens;
    }
}