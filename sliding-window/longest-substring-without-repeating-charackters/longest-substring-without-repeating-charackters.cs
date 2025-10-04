public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var last = new Dictionary<char, int>();
        int best = 0, start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            if (last.TryGetValue(ch, out int prev) && prev >= start)
            {
                start = prev + 1;
            }
            last[ch] = i;
            best = Math.Max(best, i - start + 1);
        }
        return best;
    }
}