public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> tempHashSet = new HashSet<int>();
        for (int x = 0; x < nums.Length; x++)
        {
            tempHashSet.Add(nums[x]);
        }
        int count = 0;
        foreach (int n in tempHashSet)
        {
            nums[count] = n;
            count++;
        }
        return count;
    }
}