// See https://aka.ms/new-console-template for more information

using LongestUniqueSubstring;

Solution sol = new Solution();

for (int i = 0; i < args.Length; i++)
{
    string str = args[i];

    int longest = sol.LengthOfLongestSubstring(str);

    Console.WriteLine($"{str}: {longest}");
}



