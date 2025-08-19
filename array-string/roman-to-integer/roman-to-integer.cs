public class Solution
{
    public int RomanToInt(string s)
    {
        var dict = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int value = dict[s[i]];
            if (i + 1 < s.Length && value < dict[s[i + 1]])
            {
                result -= value;
            }
            else
            {
                result += value;
            }
        }

        return result;
    }
}