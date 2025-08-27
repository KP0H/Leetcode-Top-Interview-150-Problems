public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var counter = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            counter[s[i] - 'a']++;
            counter[t[i] - 'a']--;
        }

        foreach (int x in counter)
        {
            if (x != 0) return false;
        }

        return true;
    }

    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var map = new Dictionary<char, int>();

        foreach (var r in s.EnumerateRunes())
        {
            map.TryGetValue(r, out var v);
            map[r] = v + 1;
        }

        foreach (var r in t.EnumerateRunes())
        {
            map.TryGetValue(r, out var v);
            map[r] = v - 1;
        }

        foreach (var val in map.Values)
        {
            if (val != 0) return false;
        }

        return true;
    }
}