function removeElement(nums: number[], val: number): number {
    let lastId = nums.length - 1;
    let i = 0;

    while (i < nums.length && i <= lastId)
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
};