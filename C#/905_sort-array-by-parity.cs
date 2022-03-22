public class Solution {
    public int[] SortArrayByParity(int[] A) {
        int evenCount = 0;
        int oddCount = 0;
        int[] result = new int[A.Length];
        for (int x = 0; x < A.Length; x++)
        {
            if (A[x] % 2 == 0)
            {
                result[evenCount] = A[x];
                evenCount++;
            }
            else
            {
                result[A.Length - 1 - oddCount] = A[x];
                oddCount++;
            }
        }
        return result;
    }
}