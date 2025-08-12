func removeElement(nums []int, val int) int {
    var k int = 0;
    var i int = 0;

    for (i < len(nums)){
        if (nums[i] != val){
            nums[k] = nums[i];
            k++;
        }
        i++;
    }

    return k;
}