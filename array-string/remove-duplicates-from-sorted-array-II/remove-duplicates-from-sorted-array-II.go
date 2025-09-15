func removeDuplicates(nums []int) int {
    k := 0

    for _, num := range nums {
        if k < 2 || num != nums[k-2] {
            nums[k] = num
            k++
        }
    }

    return k
}