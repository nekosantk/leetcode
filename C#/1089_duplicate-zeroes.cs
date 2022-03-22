public class Solution {
    public void DuplicateZeros(int[] arr) {
        for (int x = 0; x < arr.Length; x++)
        {
            if (arr[x] == 0 && x + 1 != arr.Length)
            {
                // Shift array
                for (int z = arr.Length - 1; z > x; z--)
                {
                    arr[z] = arr[z - 1];
                }

                // Double up on zero
                arr[x + 1] = 0;
                x += 1;
            }
        }
    }
}