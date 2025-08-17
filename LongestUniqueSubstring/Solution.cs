namespace LongestUniqueSubstring;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new HashSet<char>();
        int longest = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[right]);
            longest = Math.Max(longest, right - left + 1);
        }

        return longest;

    }
}
