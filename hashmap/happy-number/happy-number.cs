public class Solution
{
    public bool IsHappy(int n)
    {
        var hashSet = new HashSet<int>();
        while (n != 1 && hashSet.Add(n))
        {
            n = SumSquares(n);
        }
        return n == 1;
    }

    public bool IsHappy(int n)
    {
        int slow = n, fast = n;
        do
        {
            slow = SumSquares(slow);
            fast = SumSquares(SumSquares(fast));
        } while (slow != fast);

        return slow == 1;
    }

    private static int SumSquares(int x)
    {
        int s = 0;
        while (x > 0)
        {
            int d = x % 10;
            s += d * d;
            x /= 10;
        }
        return s;
    }
}