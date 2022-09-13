public class Solution {
    public int getCumulativeSum(string cum_str)
    {
        int total = 0;
        for (int i = 0; i < cum_str.Length; i++)
        {
            total += (int)char.GetNumericValue(cum_str[i]);
        }
        return total;
    }
    public int AddDigits(int num) {
        
        int counter=0;
        if (num < 10) { return num; }
        else
        {
            String cumulative_str_result = getCumulativeSum(num.ToString()).ToString();
            counter = 1;
            while (cumulative_str_result.Length > 1)
            {
                counter++;
                cumulative_str_result = getCumulativeSum(cumulative_str_result).ToString();
            }
            if ( Convert.ToInt32 (cumulative_str_result) < 10)
            {
                return Convert.ToInt32(cumulative_str_result);
            }
            return counter;
        }
    }
}