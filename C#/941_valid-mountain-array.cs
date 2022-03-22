public class Solution {
    public bool ValidMountainArray(int[] arr) {
        bool uphill = false;
        for (int x = 0; x < arr.Length - 1; x++)
        {
            if (arr[x + 1] > arr[x])
            {
                uphill = true;
            }
            else
            {
                if (uphill)
                {
                    for (int y = arr.Length - 1; y > x; y--)
                    {
                        if (arr[y] >= arr[y - 1])
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        return false;
    }
}