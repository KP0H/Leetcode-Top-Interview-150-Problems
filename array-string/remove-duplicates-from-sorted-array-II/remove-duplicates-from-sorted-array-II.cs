public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0;
        foreach (int num in nums) {
            if (k < 2 || num != nums[k - 2]) {
                nums[k] = num;
                k++;
            }
        }
        return k;
    }
}