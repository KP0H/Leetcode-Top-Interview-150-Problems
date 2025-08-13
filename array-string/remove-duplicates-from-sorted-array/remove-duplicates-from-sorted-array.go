func removeDuplicates(nums []int) int {
    if (len(nums) == 1) {
        return 1
    }

    pos := 0;
    for i := 1; i < len(nums); i++ {
        if (nums[pos] != nums[i]){
            pos++;
            nums[pos] = nums[i]
        }
    }

    return pos + 1
};