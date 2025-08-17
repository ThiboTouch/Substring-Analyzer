// See https://aka.ms/new-console-template for more information

using LongestUniqueSubstring;

for (int i = 0; i < args.Length; i++)
{
    Solution sol = new Solution();
    string str = args[i];

    int longest = sol.LengthOfLongestSubstring(str);

    Console.WriteLine($"{str}: {longest}");
}



