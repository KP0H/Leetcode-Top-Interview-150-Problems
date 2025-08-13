public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 1)
            return 1;

        int k = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[k] != nums[i])
            {
                k++;
                nums[k] = nums[i];
            }
        }
        k++;

        return k;
    }
}