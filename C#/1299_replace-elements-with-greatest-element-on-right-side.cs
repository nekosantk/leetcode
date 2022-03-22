public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxNum = -1;
        int[] tempArr = new int[arr.Length];
        tempArr[arr.Length - 1] = maxNum;
        for (int x = arr.Length - 1; x > 0; x--)
        {
            if (arr[x] > maxNum)
            {
                maxNum = arr[x];
            }
            tempArr[x - 1] = maxNum;
        }
        return tempArr;
    }
}