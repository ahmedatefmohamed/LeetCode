public class Solution {
    public bool IsPalindrome(int x) {
        
        if(x < 0 || (x % 10 == 0 && x != 0)) {
            return false;
        }
        
        int reversed_x=0;
        while (x>reversed_x) 
        {
           reversed_x = reversed_x*10 + x%10;
           x /= 10;
        }
        return (x == reversed_x || x == reversed_x/10)? true : false;
        
    }
}