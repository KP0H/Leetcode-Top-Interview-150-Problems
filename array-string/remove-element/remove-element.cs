public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int lastId = nums.Length - 1;
        int i = 0;

        while (i < nums.Length && i <= lastId)
        {
            if (nums[i] == val)
            {
                nums[i] = nums[lastId];
                lastId--;
                continue;
            }

            i++;
        }

        return i;
    }
}