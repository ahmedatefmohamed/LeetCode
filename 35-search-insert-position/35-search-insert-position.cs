public class Solution {
   public int SearchInsert(int[] nums, int target)
    {
        int index = 0, counter=0;
        foreach (var item in nums.Select((value, i) => new { i, value }))
        {
            if (item.value == target )
            {
                index= item .i ;
                counter++; 
            }
        }
        if (counter == 0)
        {
            foreach (var item in nums.Select((value, i) => new { i, value }))
            {
                if (item.value > target)
                {
                    index = item.i;
                    break;
                }else
                {
                    index = nums.Length;
                }
            }
        }
        return index;
    }
}