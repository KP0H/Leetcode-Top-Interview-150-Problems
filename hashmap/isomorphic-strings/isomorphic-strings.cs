public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length == 1) return true;

        var dict = new Dictionary<char, char>();
        var used = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char a = s[i], b = t[i];

            if (dict.TryGetValue(a, out var dictedB))
            {
                if (dictedB != b) return false;
                continue;
            }

            if (used.Contains(b)) return false;
            dict[a] = b;
            used.Add(b);
        }

        return true;
    }
}