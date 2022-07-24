public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> TwoSumDictionary= new();
        int numsLength= nums.Length;
        if(nums==null || numsLength<2){ return Array.Empty<int>(); }
        
        for(int i=0; i<numsLength ; i++){
            int validFirstNum= nums[i];
            int validSecondNum= target-validFirstNum;
            if(TwoSumDictionary.TryGetValue(validSecondNum, out int index)){
                return new[] {index, i};
            }
            TwoSumDictionary[validFirstNum]= i;
        }
        return Array.Empty<int>();
    }
}