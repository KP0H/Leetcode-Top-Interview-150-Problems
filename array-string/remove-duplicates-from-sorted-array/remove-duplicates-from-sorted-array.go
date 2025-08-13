func removeDuplicates(nums []int) int {
    if (len(nums) == 1) {
        return 1
    }

    var k int = 0;
    var i int = 1;
    for (i < len (nums)){
        if (nums[k] != nums[i]){
            k++;
            nums[k] = nums[i]
        }
        i++
    }
    k++;

    return k
};