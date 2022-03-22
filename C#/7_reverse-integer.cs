public class Solution {
    public int Reverse(int x) {
        try{
            char[] reversedArray;
            if (x < 0)
            {
                reversedArray = x.ToString().ToCharArray(1, x.ToString().Length - 1);
            }
            else
            {
                reversedArray = x.ToString().ToCharArray();
            }
            Array.Reverse(reversedArray);
            string answer = new string(reversedArray);
            if (x < 0) {
                return Int32.Parse(answer) * -1;
            }
            else
            {
                return Int32.Parse(answer);
            }
        }
        catch
        {
            return 0;
        }
    }
}