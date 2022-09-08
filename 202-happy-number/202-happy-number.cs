public class Solution {
    public int SumDigitSquares(int n)
    {
        if (n < 10)
            return n * n;
        else
            return SumDigitSquares(n % 10) + SumDigitSquares(n / 10);
    }
    public bool IsHappy(int n)
    {
        if (n == 1)
            return true;
        else if (n == 0 || n == 4)
            return false;
        else
            return IsHappy(SumDigitSquares(n));
    }
    // public bool IsHappy(int n)
    // {
    //     String num = n.ToString();
    //     int sum = 0;
    //     if (n % 2 == 0)
    //     {
    //         return false;
    //     }
    //     else
    //     {
    //         while (sum != 1)
    //         {
    //             sum = 0;
    //             for (int i = 0; i < num.Length; i++)
    //             {
    //                 int x = (int)Char.GetNumericValue(num[i]);
    //                 sum += x * x;
    //             }
    //             num = sum.ToString();
    //         }
    //         return sum == 1 ? true : false;
    //     }
    // }
}