public class Solution
{
    public int HIndex(int[] citations)
    {
        int n = citations.Length;
        var bucket = new int[n + 1];

        foreach (int c in citations)
        {
            if (c >= n) bucket[n]++;
            else bucket[c]++;
        }

        int papers = 0;
        for (int h = n; h >= 0; h--)
        {
            papers += bucket[h];
            if (papers >= h) return h;
        }
        return 0;
    }
}