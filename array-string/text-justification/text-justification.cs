public class Solution
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        var res = new List<string>();
        int n = words.Length, i = 0;

        while (i < n)
        {
            int j = i, lineLen = 0;
            while (j < n && lineLen + words[j].Length + (j - i) <= maxWidth)
            {
                lineLen += words[j].Length;
                j++;
            }

            int gaps = j - i - 1;
            bool lastLine = (j == n);
            if (lastLine || gaps == 0)
            {
                var line = string.Join(" ", words[i..j]);
                res.Add(line + new string(' ', maxWidth - line.Length));
            }
            else
            {
                int totalSpaces = maxWidth - lineLen;
                int spaceEach = totalSpaces / gaps;
                int extra = totalSpaces % gaps;

                var sb = new System.Text.StringBuilder(maxWidth);
                for (int k = i; k < j; k++)
                {
                    sb.Append(words[k]);
                    if (k < j - 1)
                    {
                        int spaces = spaceEach + (k - i < extra ? 1 : 0);
                        sb.Append(' ', spaces);
                    }
                }
                res.Add(sb.ToString());
            }

            i = j;
        }
        return res;
    }
}