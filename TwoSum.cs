public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       int[] temp = new int[2];
        foreach (int number in nums) {
            for  (int i = Array.IndexOf(nums, number); i < nums.Count(); i++) {
                if (number + nums[i] == target) {
                    temp[0] = Array.IndexOf(nums, number);
                    temp[1] = i;
                }
            }
        }
        
        return temp;
    }
}
/* 
Runtime: 1064 ms
Memory Usage: 44 MB
*/
