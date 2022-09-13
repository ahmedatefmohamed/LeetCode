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
    public int AddDigits(int num)
    {
        int counter=0;
        if (num < 10 && num % 2 == 0)
        {
            counter++;
        }
        else
        {
            String cumulative_str_result = getCumulativeSum(num.ToString()).ToString();
            if ( Convert.ToInt32 (cumulative_str_result) % 2 == 0) { counter++; }
        }
        return counter;

    }
    public int CountEven(int num)
    {
        int i = 2;
        int counter= 0, flag;
        while (i<=num)
        {
            flag = AddDigits(i);
            if (flag !=0) { counter++; }
            i++;
        }
        return counter;
    }
}