function isHappy(n: number): boolean {
    let slow = n, fast = n;
    do
    {
        slow = SumSquares(slow);
        fast = SumSquares(SumSquares(fast));
    } while (slow != fast);

    return slow == 1;
};

function SumSquares(x: number): number {
    let s = 0;
    while (x > 0)
    {
        const d = x % 10;
        s += d * d;
        x = Math.floor(x / 10);
    }
    return s;
}