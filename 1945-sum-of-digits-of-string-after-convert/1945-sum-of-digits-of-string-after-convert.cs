public class Solution {
    
    public string GetCumulativeString(string s)
    {
        String cumulative_str = String.Empty;
        foreach (var item in s.ToCharArray())
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (item == i) { cumulative_str += char.ToUpper(i) - 64; }
            }
        }
        return cumulative_str;
    }
    public int getCumulativeSumTotal(string s, int k)
    {
        int total = 0;
        for (int i = 0; i < k; i++)
        {

            total = getCumulativeSum(s);
            s = total.ToString();
        }
        return total;
    }
    public int getCumulativeSum(string cum_str)
    {
        int total = 0;
        for (int i = 0; i < cum_str.Length; i++)
        {
            total += (int)char.GetNumericValue(cum_str[i]);
        }
        return total;
    }
    public int GetLucky(string s, int k) {
        
        String cumulative_str_result = GetCumulativeString(s);
        int final_res = getCumulativeSumTotal(cumulative_str_result, k);
        return final_res;
    }
}