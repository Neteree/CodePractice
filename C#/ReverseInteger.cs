public class Solution {
    public int Reverse(int x)
    {
        int result = 0;
        char[] reversedUnsignedXChars = x.ToString().TrimStart('-').Reverse().ToArray();
        
        if (int.TryParse(reversedUnsignedXChars, out result))
        {
            if (x < 0) 
            {
                result = -result;
            }
        }

        return result;
    }
}
