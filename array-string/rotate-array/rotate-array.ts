/**
 Do not return anything, modify nums in-place instead.
 */
function rotate(nums: number[], k: number): void {
    const n = nums.length;
    if (n <= 1) return;
    k %= n;
    if (k === 0) return;

    reverse(nums, 0, n - 1);
    reverse(nums, 0, k - 1);
    reverse(nums, k, n - 1);

    function reverse(a: number[], l: number, r: number) {
        while (l < r) {
            [a[l], a[r]] = [a[r], a[l]];
            l++; r--;
        }
    }
};

function rotateExtraArray(nums: number[], k: number): void {
  const n = nums.length;
  if (n <= 1) return;
  k %= n;
  if (k === 0) return;

  const tmp = new Array<number>(n);
  for (let i = 0; i < n; i++) tmp[(i + k) % n] = nums[i];
  for (let i = 0; i < n; i++) nums[i] = tmp[i];
}
