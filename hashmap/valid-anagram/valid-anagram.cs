public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var map = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                map[s[i]]++;
                if (map[s[i]] == 0)
                {
                    map.Remove(s[i]);
                }
            }
            else
            {
                map.Add(s[i], 1);
            }

            if (map.ContainsKey(t[i]))
            {
                map[t[i]]--;
                if (map[t[i]] == 0)
                {
                    map.Remove(t[i]);
                }
            }
            else
            {
                map.Add(t[i], -1);
            }
        }

        return map.Count == 0;
    }
}