public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split(' ');

        if (pattern.Length != words.Length) return false;

        var p2w = new Dictionary<char, string>();
        var w2p = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++)
        {
            char p = pattern[i];
            string w = words[i];

            if (p2w.TryGetValue(p, out var mappedW))
            {
                if (mappedW != w) return false;
            }
            else
            {
                if (w2p.TryGetValue(w, out var mappedP) && mappedP != p) return false;
                p2w[p] = w;
                w2p[w] = p;
            }
        }

        return true;
    }
}