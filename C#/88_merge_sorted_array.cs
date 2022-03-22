public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

            for (int x = m; x < (m + n); x++)
            {
                nums1[x] = nums2[x - m];
            }

            for (int x = 0; x < m + n; x++)
            {
                for (int y = x; y < m + n; y++)
                {
                    if (nums1[y] < nums1[x])
                    {
                        int temp = nums1[x];
                        nums1[x] = nums1[y];
                        nums1[y] = temp;
                        continue;
                    }
                }
            }
    }
}