public class Solution
{
    public static int RomanToInt(string s)
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

        int count = 1;
        int result = 0;
        for (int i = 1; i <= s.Length; i++)
        {
            if (i == s.Length)
            {
                result += count * dict[s[i - 1]];
                continue;
            }

            if (s[i] == s[i - 1])
            {
                count++;
                continue;
            }

            if (dict[s[i]] > dict[s[i - 1]])
            {
                result -= count * dict[s[i - 1]];
            }
            else
            {
                result += count * dict[s[i - 1]];
            }
            count = 1;
        }

        return result;
    }
}