function plusOne(digits: number[]): number[] {
    for (let i = digits.length - 1; i >= 0; i--) {
        if (digits[i] < 9) {
            digits[i]++;
            return digits;
        }
        digits[i] = 0;
    }
    
    let result:number[] = new Array(digits.length + 1).fill(0);
    result[0] = 1;
    return result;
};