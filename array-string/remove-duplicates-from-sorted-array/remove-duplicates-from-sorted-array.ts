function removeDuplicates(nums: number[]): number {
    if (nums.length == 1)
        return 1;

    let k: number = 0;
    for (let i = 1; i < nums.length; i++)
    {
        if (nums[k] != nums[i])
        {
            k++;
            nums[k] = nums[i];
        }
    }
    k++;

    return k;
};