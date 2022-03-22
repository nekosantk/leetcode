public class Solution {
    public bool CheckIfExist(int[] arr) {
        for (int x = 0; x < arr.Length; x++)
        {
            for (int y = 0; y < arr.Length; y++)
            {
                if (arr[x] * 2 == arr[y] && x != y)
                {
                    Console.WriteLine(arr[x] * 2 + " is equal to " + arr[y]);
                    return true;
                }
            }
        }
        return false;
    }
}