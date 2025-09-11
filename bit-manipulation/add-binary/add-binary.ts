function addBinary(a: string, b: string): string {
    let i = a.length - 1, j = b.length - 1;
    let carry = 0;
    let result: string[] = [];

    while (i >= 0 || j >= 0 || carry > 0) {
        let sum = carry;
        if (i >= 0) sum += +a[i--];   // символ -> число
        if (j >= 0) sum += +b[j--];

        result.push((sum % 2).toString());
        carry = Math.floor(sum / 2);
    }

    return result.reverse().join("");
};